using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Diagnostics;
using Newtonsoft.Json.Linq;

namespace Wao
{
    public partial class Wao : Form
    {
        private string exePath;
        private string serversFilePath = Path.Combine(Application.StartupPath, "servers.txt");
        private Dictionary<string, bool> serverStatuses = new Dictionary<string, bool>();

        public Wao()
        {
            InitializeComponent();
            LoadExePath();
            LoadServers();
            serverListBox.DrawMode = DrawMode.OwnerDrawFixed;
            serverListBox.DrawItem += serverListBox_DrawItem;
            refreshBtn.Click += refreshBtn_Click;

            Task.Run(() => PingServers());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async Task PingServers()
        {
            // Initial ping of the servers right away when the form opens
            await PingAndUpdateServers();

            // Start the continuous pinging process every 15 seconds
            while (true)
            {
                // Wait for 15 seconds between each ping cycle
                await Task.Delay(15000);
            }
        }

        private async Task<bool> PingServerAsync(string ip, int port, int timeout = 1000) // 1 second for the first ping
        {
            try
            {
                using (TcpClient tcpClient = new TcpClient())
                {
                    var connectTask = tcpClient.ConnectAsync(ip, port);
                    var timeoutTask = Task.Delay(timeout);

                    var completedTask = await Task.WhenAny(connectTask, timeoutTask);

                    if (completedTask == connectTask && tcpClient.Connected)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch
            {
                return false;
            }
        }


        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimiseBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        Point mousePoint;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) != MouseButtons.Left) return;

            this.Location = new Point(this.Left - (mousePoint.X - e.X),
                this.Top - (mousePoint.Y - e.Y));
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            using (Form2 form2 = new Form2())
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    string serverName = form2.ServerName;
                    string serverIP = form2.ServerIP;
                    string serverPort = form2.ServerPort;

                    serverListBox.Items.Add(serverName);
                    SaveServerToFile(serverName, serverIP, serverPort);
                }
            }
        }

        private void SaveServerToFile(string name, string ip, string port)
        {
            using (StreamWriter writer = new StreamWriter(serversFilePath, true))
            {
                writer.WriteLine($"{name}:{ip}:{port}");
            }
        }

        private void LoadServers()
        {
            if (File.Exists(serversFilePath))
            {
                var lines = File.ReadAllLines(serversFilePath);
                foreach (var line in lines)
                {
                    var serverDetails = line.Split(':');
                    if (serverDetails.Length == 3)
                    {
                        serverListBox.Items.Add(serverDetails[0]);
                    }
                }
            }
        }

        private void serverListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            string serverName = serverListBox.Items[e.Index].ToString();

            bool isOnline = serverStatuses.ContainsKey(serverName) && serverStatuses[serverName];
            e.DrawBackground();

            // Draw the dot (green if online, red if offline)
            Color dotColor = isOnline ? Color.Green : Color.Red;
            using (Brush brush = new SolidBrush(dotColor))
            {
                e.Graphics.FillEllipse(brush, e.Bounds.Left + 2, e.Bounds.Top + 2, 10, 10);
            }

            // Draw the server name
            using (Brush textBrush = new SolidBrush(e.ForeColor))
            {
                e.Graphics.DrawString(serverName, e.Font, textBrush, e.Bounds.Left + 15, e.Bounds.Top);
            }

            e.DrawFocusRectangle();
        }

        private string[] GetServerDetails(string serverName)
        {
            if (File.Exists(serversFilePath))
            {
                var lines = File.ReadAllLines(serversFilePath);
                foreach (var line in lines)
                {
                    var serverDetails = line.Split(':');
                    if (serverDetails.Length == 3 && serverDetails[0] == serverName)
                    {
                        return serverDetails;
                    }
                }
            }
            return null;
        }

        private void serverListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (serverListBox.SelectedItem != null)
            {
                string selectedServer = serverListBox.SelectedItem.ToString();
                var serverDetails = GetServerDetails(selectedServer);

                if (serverDetails != null)
                {
                    string ip = serverDetails[1];
                    string port = serverDetails[2];
                }
            }
        }

        private void clientSelectBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Executable Files (*.exe)|*.exe";
                openFileDialog.Title = "Select MapleStory2.exe";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Store the selected exe path
                    exePath = openFileDialog.FileName;
                    SaveExePath();

                    MessageBox.Show("MapleStory2.exe selected: " + "\n" + exePath);
                }
            }
        }

        private void SaveExePath()
        {
            Properties.Settings.Default.ExePath = exePath;
            Properties.Settings.Default.Save();
        }

        private void LoadExePath()
        {
            exePath = Properties.Settings.Default.ExePath;

            if (string.IsNullOrEmpty(exePath) || !File.Exists(exePath))
            {
                MessageBox.Show("MapleStory2.exe not found or invalid path: " + "\n" + exePath);
            }
        }

        private void clientPathBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(exePath) && File.Exists(exePath))
            {
                string exeDirectory = Path.GetDirectoryName(exePath);

                if (!string.IsNullOrEmpty(exeDirectory) && Directory.Exists(exeDirectory))
                {
                    System.Diagnostics.Process.Start("explorer.exe", exeDirectory);
                }
                else
                {
                    MessageBox.Show("The directory path is not valid. Please select the file again.");
                }
            }
            else
            {
                MessageBox.Show("The file path is not valid. Please select the file again.");
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (serverListBox.SelectedItem != null)
            {
                string selectedServer = serverListBox.SelectedItem.ToString();
                serverListBox.Items.Remove(selectedServer);
                RemoveServerFromFile(selectedServer);
            }
            else
            {
                MessageBox.Show("Please select a server to remove.");
            }
        }

        private void RemoveServerFromFile(string serverName)
        {
            if (File.Exists(serversFilePath))
            {
                var lines = File.ReadAllLines(serversFilePath);
                var updatedLines = lines.Where(line => !line.StartsWith(serverName + ":")).ToArray();

                File.WriteAllLines(serversFilePath, updatedLines);
            }
        }

        private void launchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if Xml or Image checkboxes are checked
                bool isXmlChecked = chBoxXml.Checked;
                bool isImageChecked = chBoxImage.Checked;

                // If neither Xml nor Image is checked, proceed directly to launch the game
                if (!isXmlChecked && !isImageChecked)
                {
                    LaunchGame();
                }
                else
                {
                    formLaunchOption launchOptionForm = new formLaunchOption(exePath);

                    if (launchOptionForm.ShowDialog() == DialogResult.OK)
                    {
                        string mode = launchOptionForm.radioAsync.Checked ? "0" : "1"; // 0 for Async, 1 for Sync
                        string logLevel = "0"; // Log level 2 = Info (MS2Tools)

                        string toolsFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Tools");
                        string ms2CreatePath = Path.Combine(toolsFolderPath, "MS2Create.exe");

                        if (!File.Exists(ms2CreatePath))
                        {
                            MessageBox.Show("MS2Create.exe not found in the Tools folder.");
                            return;
                        }

                        string waoExeFolderPath = AppDomain.CurrentDomain.BaseDirectory;
                        string exeDirForPacking = Path.GetDirectoryName(exePath);
                        string rootDirectory = Directory.GetParent(exeDirForPacking).FullName;
                        string dataFolderPath = Path.Combine(rootDirectory, "Data");
                        string resourceFolderPath = Path.Combine(dataFolderPath, "Resource");

                        // Pack Xml if checked
                        if (isXmlChecked)
                        {
                            string xmlSourcePath = Path.Combine(waoExeFolderPath, "Xml");
                            string xmlDestinationPath = dataFolderPath;
                            string xmlArchiveName = "Xml";

                            // Run MS2Create.exe for Xml and wait for the process to complete
                            RunMs2CreateCommand(ms2CreatePath, xmlSourcePath, xmlDestinationPath, xmlArchiveName, mode, logLevel);
                        }

                        // Pack Image if checked
                        if (isImageChecked)
                        {
                            string imageSourcePath = Path.Combine(waoExeFolderPath, "Image");
                            string imageDestinationPath = resourceFolderPath;
                            string imageArchiveName = "Image";

                            // Run MS2Create.exe for Image and wait for the process to complete
                            RunMs2CreateCommand(ms2CreatePath, imageSourcePath, imageDestinationPath, imageArchiveName, mode, logLevel);
                        }

                        // After packing, proceed to launch the game
                        LaunchGame();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void RunMs2CreateCommand(string ms2CreatePath, string source, string destination, string archiveName, string mode, string logLevel)
        {
            try
            {
                // Prepare the command for MS2Create.exe with the mode and log level
                string command = $"{ms2CreatePath} {source} {destination} {archiveName} MS2F {mode} {logLevel}";

                // Run the command in cmd.exe
                ProcessStartInfo processStartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/c {command}", // Use /c to close the command prompt window after execution
                    UseShellExecute = false,     // False to allow waiting for the process to exit
                    CreateNoWindow = false       // Show the command prompt window
                };

                using (Process process = Process.Start(processStartInfo))
                {
                    // Wait for the process to complete
                    process.WaitForExit();

                    if (process.ExitCode == 0)
                    {
                        MessageBox.Show($"{archiveName} repacking completed successfully.");
                    }
                    else
                    {
                        MessageBox.Show($"Error repacking {archiveName}. Exit code: {process.ExitCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while repacking {archiveName}: {ex.Message}");
            }
        }

        private void LaunchGame()
        {
            try
            {
                if (!string.IsNullOrEmpty(exePath) && File.Exists(exePath))
                {
                    System.Diagnostics.Process.Start(exePath);
                }
                else
                {
                    MessageBox.Show("File path is not valid. Please select the file again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to launch the executable: " + ex.Message);
            }
        }


        private async Task PingAndUpdateServers()
        {
            // Make a copy of the server names for safe iteration
            var serverNames = serverListBox.Items.Cast<string>().ToList();

            foreach (string serverName in serverNames)
            {
                var serverDetails = GetServerDetails(serverName);
                if (serverDetails != null)
                {
                    string ip = serverDetails[1];
                    int port = int.Parse(serverDetails[2]);

                    bool isOnline = await PingServerAsync(ip, port);

                    this.Invoke((MethodInvoker)delegate {
                        serverStatuses[serverName] = isOnline;
                        serverListBox.Invalidate(); // Redraw to reflect the change
                    });
                }
            }
        }

        private async void refreshBtn_Click(object sender, EventArgs e)
        {
            RefreshServers();
            await PingAndUpdateServers();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (serverListBox.SelectedItem != null)
            {
                string selectedServer = serverListBox.SelectedItem.ToString();
                var serverDetails = GetServerDetails(selectedServer);
                if (serverDetails != null)
                {
                    using (Form3 form3 = new Form3(serverDetails[0], serverDetails[1], serverDetails[2]))
                    {
                        if (form3.ShowDialog() == DialogResult.OK)
                        {
                            // Update the server in the text file
                            UpdateServerInFile(serverDetails[0], form3.ServerName, form3.ServerIP, form3.ServerPort);

                            // Refresh the ListBox
                            RefreshServers();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a server to edit.");
            }
        }

        private void UpdateServerInFile(string oldName, string newName, string newIP, string newPort)
        {
            var lines = File.ReadAllLines(serversFilePath).ToList();
            int index = lines.FindIndex(line => line.StartsWith(oldName + ":"));
            if (index != -1)
            {
                lines[index] = $"{newName}:{newIP}:{newPort}";
                File.WriteAllLines(serversFilePath, lines);
            }
        }

        private void RefreshServers()
        {
            serverListBox.Items.Clear();
            LoadServers();
        }

        private async void btnZinXml_Click(object sender, EventArgs e)
        {
            await DownloadAndReplaceZinsXmlFiles();
        }

        private async Task DownloadAndReplaceZinsXmlFiles()
        {
            try
            {
                if (string.IsNullOrEmpty(exePath) || !File.Exists(exePath))
                {
                    MessageBox.Show("Please select a valid MapleStory2.exe before proceeding.");
                    return;
                }

                // Navigate up one directory from the x64 client folder to find the Data folder
                string exeDirectory = Path.GetDirectoryName(exePath);
                string rootDirectory = Directory.GetParent(exeDirectory).FullName;
                string dataFolderPath = Path.Combine(rootDirectory, "Data");

                // Ensure the Data folder exists
                if (!Directory.Exists(dataFolderPath))
                {
                    MessageBox.Show("The Data folder does not exist. Please verify the client path.");
                    return;
                }

                // Create Backup Folder if it doesn't exist
                string backupFolderPath = Path.Combine(dataFolderPath, "! Backup");
                if (!Directory.Exists(backupFolderPath))
                {
                    Directory.CreateDirectory(backupFolderPath);
                }

                // Files to be backed up and replaced
                string[] filesToBackup = { "Image.m2d", "Image.m2h", "Xml.m2d", "Xml.m2h" };

                // Backup existing files
                foreach (var fileName in filesToBackup)
                {
                    string filePath = Path.Combine(dataFolderPath, fileName);
                    string backupFilePath = Path.Combine(backupFolderPath, fileName);

                    if (File.Exists(filePath))
                    {
                        File.Copy(filePath, backupFilePath, true);
                    }
                }

                // Get the latest release assets from GitHub API
                string apiUrl = "https://api.github.com/repos/Zintixx/MapleStory2-XML/releases/latest";
                HttpClient client = new HttpClient();

                // GitHub requires a user-agent for requests
                client.DefaultRequestHeaders.Add("User-Agent", "MapleStory2-XML-Downloader");

                var response = await client.GetStringAsync(apiUrl);
                var releaseData = JObject.Parse(response);
                var assets = releaseData["assets"];

                // Find the necessary files in the assets
                Dictionary<string, string> downloadUrls = new Dictionary<string, string>();
                foreach (var asset in assets)
                {
                    string name = asset["name"].ToString();
                    string downloadUrl = asset["browser_download_url"].ToString();

                    if (name == "Server.m2d" || name == "Server.m2h" || name == "Xml.m2d" || name == "Xml.m2h")
                    {
                        downloadUrls[name] = downloadUrl;
                    }
                }

                if (downloadUrls.Count < 4)
                {
                    MessageBox.Show("Failed to locate all necessary files in the release.");
                    return;
                }

                // Track the download stage
                int fileCounter = 1;
                int totalFiles = downloadUrls.Count;

                // Download and replace the files
                foreach (var fileUrl in downloadUrls)
                {
                    string fileName = fileUrl.Key;
                    string destinationPath = Path.Combine(dataFolderPath, fileName);

                    // Update the label with the current file and stage
                    UpdateLabelStatus($"{fileName} ({fileCounter}/{totalFiles})");

                    await DownloadFileAsync(fileUrl.Value, destinationPath);

                    fileCounter++; // Increment the file counter after each download
                }

                // Reset the status after completion
                UpdateLabelStatus("Done!");
                MessageBox.Show("Files downloaded and replaced successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void UpdateLabelStatus(string message)
        {
            // Ensure the label update is on the UI thread
            if (InvokeRequired)
            {
                Invoke(new Action<string>(UpdateLabelStatus), message);
            }
            else
            {
                lblStatus.Text = message;
            }
        }


        private async Task DownloadFileAsync(string url, string destinationPath)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url, HttpCompletionOption.ResponseHeadersRead);
                response.EnsureSuccessStatusCode();

                // Get the total size of the file
                long totalBytes = response.Content.Headers.ContentLength ?? -1;
                long totalBytesRead = 0;
                byte[] buffer = new byte[8192];  // Buffer for chunks of data

                using (var fs = new FileStream(destinationPath, FileMode.Create, FileAccess.Write, FileShare.None))
                using (var stream = await response.Content.ReadAsStreamAsync())
                {
                    int bytesRead;
                    while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                    {
                        await fs.WriteAsync(buffer, 0, bytesRead);
                        totalBytesRead += bytesRead;

                        // If we know the total size of the file, update the progress bar
                        if (totalBytes != -1)
                        {
                            int progressPercentage = (int)((totalBytesRead * 100) / totalBytes);
                            UpdateProgressBar(progressPercentage);
                        }
                    }
                }
            }
        }

        private void UpdateProgressBar(int progressPercentage)
        {
            // Ensure this runs on the UI thread
            if (InvokeRequired)
            {
                Invoke(new Action<int>(UpdateProgressBar), progressPercentage);
            }
            else
            {
                progressBar1.Value = progressPercentage;
            }
        }

        private void btnExtractXml_Click(object sender, EventArgs e)
        {
            formExtractOption extractOptionForm = new formExtractOption(exePath, progressBar1);
            extractOptionForm.ShowDialog();
        }

        private void btnExtractImage_Click(object sender, EventArgs e)
        {
            formExtractImage extractImageForm = new formExtractImage(exePath, progressBar1);
            extractImageForm.ShowDialog();
        }

        private void btnModPath_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the directory where the Wao.exe is located
                string waoExeFolderPath = AppDomain.CurrentDomain.BaseDirectory;

                // Check if the folder exists before opening it
                if (Directory.Exists(waoExeFolderPath))
                {
                    // Open the folder in Windows Explorer
                    System.Diagnostics.Process.Start("explorer.exe", waoExeFolderPath);
                }
                else
                {
                    MessageBox.Show("The directory path is not valid or does not exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}