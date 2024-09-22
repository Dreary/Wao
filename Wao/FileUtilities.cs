using System.IO;
using System.Windows.Forms;
using System;

public static class FileUtilities
{
    public static void BackupFiles(string dataFolderPath, string[] filesToBackup, string subDirectory = "", ProgressBar progressBar = null)
    {
        try
        {
            // Ensure we are backing up to the /Data/ folder directly
            if (!string.IsNullOrEmpty(subDirectory))
            {
                // Only append subdirectory path if necessary (this will prevent putting files into /Resource)
                dataFolderPath = Path.Combine(dataFolderPath, subDirectory);
            }

            // Make sure we're in the correct base Data folder
            string dataBaseFolderPath = Directory.GetParent(dataFolderPath).FullName;

            if (!Directory.Exists(dataBaseFolderPath))
            {
                MessageBox.Show($"The folder does not exist: {dataBaseFolderPath}");
                return;
            }

            // Create or use the !Backup folder inside the /Data/ folder
            string backupFolderPath = Path.Combine(dataBaseFolderPath, "! Backup");
            if (!Directory.Exists(backupFolderPath))
            {
                Directory.CreateDirectory(backupFolderPath);
            }

            // Initialize progress bar
            if (progressBar != null)
            {
                progressBar.Minimum = 0;
                progressBar.Maximum = filesToBackup.Length;
                progressBar.Value = 0;
            }

            foreach (string fileName in filesToBackup)
            {
                string filePath = Path.Combine(dataFolderPath, fileName);
                string backupFilePath = Path.Combine(backupFolderPath, fileName);

                if (File.Exists(filePath))
                {
                    File.Copy(filePath, backupFilePath, true); // Overwrite if backup already exists
                }

                // Update progress bar
                if (progressBar != null)
                {
                    progressBar.Value += 1;
                }
            }

            MessageBox.Show("Backup completed successfully.");
        }
        catch (Exception ex)
        {
            MessageBox.Show("An error occurred during backup: " + ex.Message);
        }
    }

}
