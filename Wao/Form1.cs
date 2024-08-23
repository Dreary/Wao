using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net.Sockets;

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
            while (true)
            {
                foreach (string serverName in serverListBox.Items)
                {
                    var serverDetails = GetServerDetails(serverName);
                    if (serverDetails != null)
                    {
                        string ip = serverDetails[1];
                        int port = int.Parse(serverDetails[2]);

                        bool isOnline = await PingServerAsync(ip, port);
                        serverStatuses[serverName] = isOnline;
                    }
                }

                serverListBox.Invoke(new Action(() => serverListBox.Invalidate()));

                // 60s delay before pinging again
                await Task.Delay(60000);
            }
        }

        private async Task<bool> PingServerAsync(string ip, int port)
        {
            try
            {
                using (TcpClient tcpClient = new TcpClient())
                {
                    var connectTask = tcpClient.ConnectAsync(ip, port);
                    var timeoutTask = Task.Delay(5000); // 5 seconds timeout

                    var completedTask = await Task.WhenAny(connectTask, timeoutTask);

                    if (completedTask == connectTask && tcpClient.Connected)
                    {
                        return true; // Server is online and listening on the specified port
                    }
                    else
                    {
                        return false; // Connection timed out or failed
                    }
                }
            }
            catch
            {
                return false; // Connection failed
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

                    // Add the server name to the ListBox + save it
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

            // Get the server status
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
            // Check if a server is selected in the ListBox
            if (serverListBox.SelectedItem != null)
            {
                string selectedServer = serverListBox.SelectedItem.ToString();
                var serverDetails = GetServerDetails(selectedServer);

                if (serverDetails != null)
                {
                    string serverName = serverDetails[0];
                    string serverIP = serverDetails[1];
                    string serverPort = serverDetails[2];

                    if (!string.IsNullOrEmpty(exePath) && File.Exists(exePath))
                    {
                        string exeDirectory = Path.GetDirectoryName(exePath);
                        string iniFilePath = Path.Combine(exeDirectory, "maple2.ini");

                        if (File.Exists(iniFilePath))
                        {
                            try
                            {
                                var lines = File.ReadAllLines(iniFilePath);

                                // Replace the relevant fields in the .ini file
                                for (int i = 0; i < lines.Length; i++)
                                {
                                    if (lines[i].StartsWith("name="))
                                    {
                                        lines[i] = "name=" + serverName;
                                    }
                                    else if (lines[i].StartsWith("host="))
                                    {
                                        lines[i] = "host=" + serverIP;
                                    }
                                    else if (lines[i].StartsWith("port="))
                                    {
                                        lines[i] = "port=" + serverPort;
                                    }
                                }

                                File.WriteAllLines(iniFilePath, lines);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Failed to update the ini file: " + ex.Message);
                                return; 
                            }
                        }
                        else
                        {
                            MessageBox.Show("maple2.ini file not found in the selected directory.");
                            return; 
                        }

                        // Launch the executable after updating the .ini file
                        try
                        {
                            System.Diagnostics.Process.Start(exePath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Failed to launch the executable: " + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("File path is not valid. Please select the file again.");
                    }
                }
                else
                {
                    MessageBox.Show("Failed to retrieve server details.");
                }
            }
            else
            {
                MessageBox.Show("Please select a server from the list.");
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

    }
}