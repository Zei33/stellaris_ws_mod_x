using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MetroFramework.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace stellaris_ws_mod_x
{
    public partial class MainForm : MetroForm
    {
        public string modFolderDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Documents\\Paradox Interactive\\Stellaris\\mod";
        public string modZipFileLocation = "C:\\";

        public MainForm()
        {
            InitializeComponent();

            ModFolderLocationText.Text = modFolderDirectory;
            ModZipFileLocationText.Text = modZipFileLocation;
        }

        private void ModFolderSelect_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog folderDialog = new CommonOpenFileDialog();

            folderDialog.InitialDirectory = modFolderDirectory;
            folderDialog.IsFolderPicker = true;

            if (folderDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                modFolderDirectory = folderDialog.FileName;
            }

            ModFolderLocationText.Text = modFolderDirectory;
        }

        private void ModZipFileSelect_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog fileDialog = new CommonOpenFileDialog();

            fileDialog.InitialDirectory = modZipFileLocation;
            fileDialog.IsFolderPicker = false;

            if (fileDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                modZipFileLocation = fileDialog.FileName;
            }

            ModZipFileLocationText.Text = modZipFileLocation;
        }

        private void InstallModButton_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(modFolderDirectory) || !File.GetAttributes(modFolderDirectory).HasFlag(FileAttributes.Directory))
            {
                MessageBox.Show("The mod folder either does not exist or was not a folder.");

                return;
            }

            if (!File.Exists(modZipFileLocation) || Path.GetExtension(modZipFileLocation) != ".zip")
            {
                MessageBox.Show("The mod zip file either does not exist or was not a zip file.");

                return;
            }

            if (File.Exists(modFolderDirectory + "\\" + Path.GetFileName(modZipFileLocation)))
            {
                MessageBox.Show("A mod already exists of the name " + Path.GetFileName(modZipFileLocation));

                return;
            }

            if (File.Exists(modFolderDirectory + "\\" + Path.GetFileNameWithoutExtension(modZipFileLocation) + ".mod"))
            {
                MessageBox.Show("A mod descriptor already exists of the name " + Path.GetFileNameWithoutExtension(modZipFileLocation) + ".mod");

                return;
            }

            File.Copy(modZipFileLocation, modFolderDirectory + "\\" + Path.GetFileName(modZipFileLocation));

            using (var zip = Ionic.Zip.ZipFile.Read(modZipFileLocation))
            {
                zip.ExtractSelectedEntries("descriptor.mod", null, modFolderDirectory);
            }

            string descriptorLocation = modFolderDirectory + "\\descriptor.mod";
            string newModZipFileLocationUnescaped = Regex.Replace(modFolderDirectory + "\\" + Path.GetFileName(modZipFileLocation), @"\\", @"\\");

            string descriptorText = File.ReadAllText(descriptorLocation);
            descriptorText = Regex.Replace(descriptorText, @"archive\=\"".*\""", @"archive=""" + newModZipFileLocationUnescaped + @"""");
            descriptorText = Regex.Replace(descriptorText, @"remote_file_id\=\"".*\""\n", @"");
            File.WriteAllText(descriptorLocation, descriptorText);

            File.Move(descriptorLocation, modFolderDirectory + "\\" + Path.GetFileNameWithoutExtension(modZipFileLocation) + ".mod");

            MessageBox.Show("Installation succeeded.");
        }

        private void CreatedByLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://zeiworld.net");
        }
    }
}
