using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PMW3Practice
{
    public partial class FileSelectionForm : Form
    {
        static string appDataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        static string gameDirectory = @"Electronic Arts\Pac-Man World 3";
        static string savesDirectory = @"PracticeFiles";
        static FileItem[] files = GetFiles();

        public FileSelectionForm()
        {
            InitializeComponent();

            var displayNames = SelectDisplayNames(files);

            cmbFile1.Items.AddRange(displayNames);
            cmbFile2.Items.AddRange(displayNames);
            cmbFile3.Items.AddRange(displayNames);
        }

        private static FileItem[] GetFiles()
        {
            var files = Directory.GetFiles(savesDirectory);
            var fileItems = files.Select(path => new FileItem(GetDisplayName(path), path));
            return fileItems.ToArray();
        }

        private static string GetDisplayName(string path)
        {
            return Path.GetFileName(path).Trim('_').Replace("_", " - ");
        }

        private static string[] SelectDisplayNames(FileItem[] files)
        {
            return files.Select(file => file.DisplayName).ToArray();
        }

        private void cmbFile1_SelectedIndexChanged(object sender, EventArgs e)
        {
            copyFile(cmbFile1.SelectedIndex, "A");
        }

        private void cmbFile2_SelectedIndexChanged(object sender, EventArgs e)
        {
            copyFile(cmbFile2.SelectedIndex, "B");
        }

        private void cmbFile3_SelectedIndexChanged(object sender, EventArgs e)
        {
            copyFile(cmbFile3.SelectedIndex, "C");
        }

        private void copyFile(int index, string slot)
        {
            if (index >= 0 && index < files.Length)
            {
                var fileItem = files[index];
                var sourcePath = fileItem.FilePath;
                var destPath = Path.Combine(appDataDirectory, gameDirectory, "PMW3" + slot);
                File.Copy(sourcePath, destPath, true);
            }
        }

        struct FileItem
        {
            public string DisplayName;
            public string FilePath;

            public FileItem(string displayName, string filePath)
            {
                DisplayName = displayName;
                FilePath = filePath;
            }
        }
    }
}
