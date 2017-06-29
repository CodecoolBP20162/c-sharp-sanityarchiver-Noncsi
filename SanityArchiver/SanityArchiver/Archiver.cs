using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SanityArchiver
{
    public partial class SanityArchiver : Form
    {
        const string StartingPath = @"C:\\"; //always start with the root of C
        const string FileIcon = "C:\\Test folder\\shit i stole off the internet\\file_icon.png";
        const string FolderIcon = "C:\\Test folder\\shit i stole off the internet\\folder_icon.png";
        public string CurrentPath = StartingPath;    

        public SanityArchiver()
        {
            InitializeComponent();
        }

        private void SanityArchiver_Load(object sender, EventArgs e)
        {
            AddImagesToImageList();
            RefreshPage();
        }

        void AddImagesToImageList()
        {
            ImageList imageList = new ImageList();
            imageList.Images.Add(Image.FromFile(FolderIcon));
            imageList.Images.Add(Image.FromFile(FileIcon));
            Table.SmallImageList = imageList;
        }

        void RefreshPage()
        {
            GetFoldersAndFiles GetData = new GetFoldersAndFiles();
            Table.Items.Clear();
            GetData.GetFolders(CurrentPath, Table);
            GetData.GetFiles(CurrentPath, Table);
        }

        string GetSelectedFilesPath()
        {
            string clickedDirectory = Table.SelectedItems[0].SubItems[1].Text;
            string SelectedPath = CurrentPath + clickedDirectory;
            return SelectedPath;
        }

        void GetSteppedIntoFolderPath()
        {
            string clickedDirectory = Table.SelectedItems[0].SubItems[1].Text;
            string SelectedPath = CurrentPath + clickedDirectory + "\\";
            CurrentPath = SelectedPath;
        }

        private void Table_DoubleClick(object sender, EventArgs e)
        {
            GetSteppedIntoFolderPath();
            RefreshPage();
        }

        private void StepBackButton_Click(object sender, EventArgs e)
        {
            if (CurrentPath != StartingPath)
            {
                string[] SplittedPath = CurrentPath.Split('\\');
                int PathPartToIgnore = SplittedPath[SplittedPath.Length - 2].Length;
                string newPath = "";
                for (int i = 0; i < CurrentPath.Length - PathPartToIgnore - 1; i++) newPath += CurrentPath[i];
                CurrentPath = newPath;
                RefreshPage();
            }
        }

        private void CompressButton_Click(object sender, EventArgs e)
        {
            CompressAndDecompress compress = new CompressAndDecompress();
            string selectedPath = GetSelectedFilesPath();
            FileInfo FileSelected = new FileInfo(selectedPath);
            compress.CompressFile(FileSelected, CurrentPath);
            RefreshPage();
        }

        private void DecompressButton_Click(object sender, EventArgs e)
        {
            CompressAndDecompress compress = new CompressAndDecompress();
            string selectedPath = GetSelectedFilesPath();
            string path = Path.GetFullPath(selectedPath);
            FileInfo FileSelected = new FileInfo(path);
            compress.DecompressFile(FileSelected);
            RefreshPage();
        }

        void RenameFile()
        {
            RenameFileTextBox.Show();
            ApproveNewFileNameButton.Show();
            RenameFileLabel.Show();
        }

        private void RenameButton_Click(object sender, EventArgs e)
        { RenameFile();}

        private void ApproveNewFileNameButton_Click(object sender, EventArgs e)
        {
            string oldFilePath = GetSelectedFilesPath();
            string newFilePath = CurrentPath + RenameFileTextBox.Text;
            File.Move(oldFilePath, newFilePath);
            RenameFileTextBox.Hide();
            ApproveNewFileNameButton.Hide();
            RenameFileLabel.Hide();
            RefreshPage();
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            string OpenThis = GetSelectedFilesPath();
            Process.Start(OpenThis);
        }
        

        private void DeleteFileButton_Click(object sender, EventArgs e)
        {
            string Path = GetSelectedFilesPath();
            FileInfo FileToDelete = new FileInfo(Path);
            FileToDelete.Delete();
            RefreshPage();
        }
    }
}
