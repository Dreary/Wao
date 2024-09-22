using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Wao
{
    public partial class formExtractImage : Form
    {
        private string exePath;
        private System.Windows.Forms.ProgressBar progressBar;

        public formExtractImage(string exePath, System.Windows.Forms.ProgressBar progressBar)
        {
            InitializeComponent();
            this.exePath = exePath; // Store the exePath for later use
            this.progressBar = progressBar; // Store the reference to progressBar1 from Form1
        }

        private void btnExtractImage_Click(object sender, EventArgs e)
        {
            string exeDirectory = Path.GetDirectoryName(exePath);
            string rootDirectory = Directory.GetParent(exeDirectory).FullName;
            string dataFolderPath = Path.Combine(rootDirectory, "Data");

            // Check if the backup checkbox is checked
            if (chBoxBackup.Checked)
            {
                // Backup Image files using the progress bar from Form1
                string[] filesToBackup = { "Image.m2d", "Image.m2h" };
                FileUtilities.BackupFiles(dataFolderPath, filesToBackup, "Resource", progressBar); // Pass progressBar from Form1
            }

            ExtractImage(); // Proceed with Image extraction
        }

        private void ExtractImage()
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

                // Navigate to the /Data/Resource/ folder, where the Image.m2d and Image.m2h files are located
                string resourceFolderPath = Path.Combine(rootDirectory, "Data", "Resource");

                // Ensure the Resource folder exists
                if (!Directory.Exists(resourceFolderPath))
                {
                    MessageBox.Show("The Resource folder does not exist at: " + resourceFolderPath);
                    return;
                }

                // Check if Image.m2d and Image.m2h exist in the Resource folder
                string imageM2dPath = Path.Combine(resourceFolderPath, "Image.m2d");
                string imageM2hPath = Path.Combine(resourceFolderPath, "Image.m2h");

                if (!File.Exists(imageM2dPath) || !File.Exists(imageM2hPath))
                {
                    MessageBox.Show("Image.m2d or Image.m2h is missing in the Resource folder.");
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

                // Prepare the command to run specifically with Image.m2d as source, destination, mode, and loglevel
                string command = $"{ms2ExtractPath} {imageM2dPath} {waoExeFolderPath} {mode} {logLevel}";

                // Prepare the ProcessStartInfo to run the command in cmd.exe
                ProcessStartInfo processStartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/k {command}", // Execute the command and keep the window open
                    UseShellExecute = false,      // Use shell to open the cmd window
                    CreateNoWindow = false       // Show the command prompt window
                };

                using (Process process = Process.Start(processStartInfo))
                {
                    process.WaitForExit(); // Wait for the process to complete

                    // Capture the output and error messages
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();

                    // Show a message box when extraction is complete or if an error occurred
                    if (process.ExitCode == 0)
                    {
                        MessageBox.Show("Image extraction completed successfully.");
                        this.Close(); // Close the form after the message box is closed
                    }
                    else
                    {
                        // Only show the error if there was an issue
                        MessageBox.Show($"Error during extraction: {error}");
                        this.Close(); // Close the form after the message box is closed
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                this.Close(); // Close the form in case of exception
            }
        }

        private void exitBtn_Click_1(object sender, EventArgs e)
        {
            this.Close(); // Closes the form when the exit button is clicked
        }

        private void minimiseBtn_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Minimizes the form
        }
    }
}
