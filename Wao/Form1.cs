using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wao
{
    public partial class Form1 : Form
    {
        private string exePath;
        private string serversFilePath = Path.Combine(Application.StartupPath, "servers.txt");

        public Form1()
        {
            InitializeComponent();
            LoadExePath();
            LoadServers();

            // Connect the Refresh button to its event handler
            refreshBtn.Click += refreshBtn_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

                    // Add the server name to the ListBox
                    serverListBox.Items.Add(serverName);

                    // Save the server details to a text file
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

        private void clientSelectBtn_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Select your MapleStory2 file location";

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    // Store the selected folder path
                    exePath = folderBrowserDialog.SelectedPath;

                    // Save the folder path for future use
                    SaveExePath();

                    // Show a message confirming the folder selection
                    MessageBox.Show("MapleStory2 folder selected: " + "\n" + exePath);
                }
            }
        }

        private void SaveExePath()
        {
            // Store the folder path in application settings
            Properties.Settings.Default.ExePath = exePath;
            Properties.Settings.Default.Save();
        }

        private void LoadExePath()
        {
            // Load the stored folder path
            exePath = Properties.Settings.Default.ExePath;

            if (string.IsNullOrEmpty(exePath) || !Directory.Exists(exePath))
            {
                MessageBox.Show("MapleStory2 folder not found or invalid path: " + "\n" + exePath);
            }
            else
            {
                // No action needed, the path is valid
            }
        }


        private void clientPathBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(exePath) && Directory.Exists(exePath))
            {
                // Open the directory in File Explorer
                System.Diagnostics.Process.Start("explorer.exe", exePath);
            }
            else
            {
                MessageBox.Show("The folder path is not valid. Please select the folder again.");
            }
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

                    // Use the IP and Port for launching the client, or store them for later use
                    // MessageBox.Show($"Selected Server IP: {ip}, Port: {port}");
                }
            }
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

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (serverListBox.SelectedItem != null)
            {
                // Get the selected server name
                string selectedServer = serverListBox.SelectedItem.ToString();

                // Remove the server from the ListBox
                serverListBox.Items.Remove(selectedServer);

                // Remove the server details from the file
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
                // Read all lines from the file
                var lines = File.ReadAllLines(serversFilePath);

                // Filter out the line that matches the server name
                var updatedLines = lines.Where(line => !line.StartsWith(serverName + ":")).ToArray();

                // Write the updated lines back to the file
                File.WriteAllLines(serversFilePath, updatedLines);
            }
        }

        private void launchBtn_Click(object sender, EventArgs e)
        {
            // Retrieve the stored folder path from the settings
            string exeFolderPath = Properties.Settings.Default.ExePath;

            // Check if the path is valid
            if (!string.IsNullOrEmpty(exeFolderPath) && Directory.Exists(exeFolderPath))
            {
                // Construct the path to the x64 folder
                string x64FolderPath = Path.Combine(exeFolderPath, "x64");

                // Check if the x64 folder exists
                if (Directory.Exists(x64FolderPath))
                {
                    try
                    {
                        // Construct the full path to the executable inside the x64 folder
                        string exeFullPath = Path.Combine(x64FolderPath, "MapleStory2.exe");

                        // Check if the executable exists
                        if (File.Exists(exeFullPath))
                        {
                            // Launch the executable
                            System.Diagnostics.Process.Start(exeFullPath);
                        }
                        else
                        {
                            MessageBox.Show("MapleStory2.exe not found in the x64 folder.");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any errors that might occur during launch
                        MessageBox.Show("Failed to launch the executable: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("x64 folder not found in the selected directory.");
                }
            }
            else
            {
                MessageBox.Show("Folder path is not valid. Please set the correct path.");
            }
        }

        private void setServerBtn_Click(object sender, EventArgs e)
        {
            if (serverListBox.SelectedItem != null)
            {
                string selectedServer = serverListBox.SelectedItem.ToString();
                var serverDetails = GetServerDetails(selectedServer);

                if (serverDetails != null)
                {
                    string serverName = serverDetails[0];
                    string serverIP = serverDetails[1];
                    string serverPort = serverDetails[2];

                    string exeFolderPath = Properties.Settings.Default.ExePath;

                    string x64FolderPath = Path.Combine(exeFolderPath, "x64");

                    string iniFilePath = Path.Combine(x64FolderPath, "maple2.ini");

                    // Check if the maple2.ini file exists
                    if (File.Exists(iniFilePath))
                    {
                        try
                        {
                            var lines = File.ReadAllLines(iniFilePath);

                            // Replace the relevant fields
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

                            MessageBox.Show("maple2.ini updated successfully.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Failed to update the ini file: " + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("maple2.ini file not found in the x64 folder.");
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

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            serverListBox.Items.Clear();
            LoadServers();
        }
    } 
}