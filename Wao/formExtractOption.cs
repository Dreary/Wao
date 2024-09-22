using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Wao
{
    public partial class formExtractOption : Form
    {
        private string exePath;
        private System.Windows.Forms.ProgressBar progressBar;

        public formExtractOption(string exePath, System.Windows.Forms.ProgressBar progressBar)
        {
            InitializeComponent();
            this.exePath = exePath; // Store the exePath for later use
            this.progressBar = progressBar; // Store the reference to progressBar1 from Form1
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimiseBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExtractXml_Click_1(object sender, EventArgs e)
        {
            string exeDirectory = Path.GetDirectoryName(exePath);
            string rootDirectory = Directory.GetParent(exeDirectory).FullName;
            string dataFolderPath = Path.Combine(rootDirectory, "Data");

            // Check if the backup checkbox is checked
            if (chBoxBackup.Checked)
            {
                // Backup Xml files using the progress bar from Form1
                string[] filesToBackup = { "Xml.m2d", "Xml.m2h" };
                FileUtilities.BackupFiles(dataFolderPath, filesToBackup, "", progressBar); // Pass progressBar from Form1
            }

            ExtractXml(); // Proceed with Xml extraction
        }

        private void ExtractXml()
        {
            try
            {
                // Ensure the exePath contains the x64 path
                if (string.IsNullOrEmpty(exePath) || !File.Exists(exePath))
                {
                    MessageBox.Show("Please select a valid MapleStory2.exe before proceeding.");
                    return;
                }

                // The stored path is in the /x64/ folder, remove the /x64/ part
                string exeDirectory = Path.GetDirectoryName(exePath); // The x64 folder
                string rootDirectory = Directory.GetParent(exeDirectory).FullName; // Go one level up, which removes /x64/

                // Navigate to the /Data/ folder, where the Xml.m2d and Xml.m2h files are located
                string dataFolderPath = Path.Combine(rootDirectory, "Data");

                // Ensure the Data folder exists
                if (!Directory.Exists(dataFolderPath))
                {
                    MessageBox.Show("The Data folder does not exist at: " + dataFolderPath);
                    return;
                }

                // Check if Xml.m2d and Xml.m2h exist in the Data folder
                string xmlM2dPath = Path.Combine(dataFolderPath, "Xml.m2d");
                string xmlM2hPath = Path.Combine(dataFolderPath, "Xml.m2h");

                if (!File.Exists(xmlM2dPath) || !File.Exists(xmlM2hPath))
                {
                    MessageBox.Show("Xml.m2d or Xml.m2h is missing in the Data folder.");
                    return;
                }

                // Path to the MS2Extract.exe tool in the Tools folder located where Wao.exe is located
                string toolsFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Tools");
                string ms2ExtractPath = Path.Combine(toolsFolderPath, "MS2Extract.exe");

                if (!File.Exists(ms2ExtractPath))
                {
                    MessageBox.Show("MS2Extract.exe not found in the Tools folder.");
                    return;
                }

                // Get the current folder where Wao.exe is located (destination)
                string waoExeFolderPath = AppDomain.CurrentDomain.BaseDirectory;

                // Check which radio button is selected (Sync or Async)
                string mode = radioAsync.Checked ? "0" : "1"; // 0 for Async, 1 for Sync

                // Add loglevel (2) at the end of the command
                string logLevel = "2";

                // Prepare the command to run specifically with Xml.m2d as source and selected mode
                string command = $"{ms2ExtractPath} {xmlM2dPath} {waoExeFolderPath} {mode} {logLevel}";

                // Prepare the ProcessStartInfo to run the command in cmd.exe
                ProcessStartInfo processStartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/k {command}", // Execute the command and keep the window open
                    UseShellExecute = false,      // Use shell to open the cmd window
                    CreateNoWindow = false       // Show the command prompt window
                };

                Process.Start(processStartInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                this.Close(); // Close the form in case of exception
            }
        }
    }
}
