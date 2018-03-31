using System;
using System.IO;
using System.Windows.Forms;

namespace PMW3Practice
{
    public partial class FileSelectionForm : Form
    {
        string[] files = new string[] { "CliffsFight4Skip", "ValeRingsSkip", "ZephyrSyphon",
            "CatacombsDetonator", "CatacombsEnd", "GogekkaHeightsTriplePillarless",
            "GogekkaHeightsEnd", "CanyonEarly", "ErwinsFightSkip",
            "DungenFight", "ZenithEarly", "ZenithLate" };

        string appDataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        string gameDirectory = @"Electronic Arts\Pac-Man World 3";
        string savesDirectory = @"D:\PMW3\PMW3Practice\PracticeFiles";

        public FileSelectionForm()
        {
            InitializeComponent();

            cmbFile1.Items.AddRange(files);
            cmbFile2.Items.AddRange(files);
            cmbFile3.Items.AddRange(files);
        }

        private void cmbFile1_SelectedIndexChanged(object sender, EventArgs e)
        {
            copyFile((string)cmbFile1.SelectedItem, "A");
        }

        private void cmbFile2_SelectedIndexChanged(object sender, EventArgs e)
        {
            copyFile((string)cmbFile1.SelectedItem, "B");
        }

        private void cmbFile3_SelectedIndexChanged(object sender, EventArgs e)
        {
            copyFile((string)cmbFile1.SelectedItem, "C");
        }

        private void copyFile(string fileName, string slot)
        {
            var sourcePath = Path.Combine(savesDirectory, fileName);
            var destPath = Path.Combine(appDataDirectory, gameDirectory, "PMW3" + slot);
            File.Copy(sourcePath, destPath, true);
        }
    }
}
