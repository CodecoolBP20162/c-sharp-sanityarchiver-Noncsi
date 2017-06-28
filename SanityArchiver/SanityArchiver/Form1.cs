using System;
using System.IO;
using System.Windows.Forms;
using Ionic.Zlib;
using System.IO.Compression;

namespace SanityArchiver
{
    public partial class Base : Form
    {
        const string StartingPath = @"C:\\"; //always start with the root of C
        string CurrentPath = StartingPath;

        public Base()
        {
            InitializeComponent();
        }

        string GetSelectedFilesPath()
        {
            string clickedDirectory = DirectoryOutput.SelectedItems[0].ToString();
            string SelectedPath = CurrentPath + clickedDirectory;
            return SelectedPath;
        }

        void GetsteppedIntoFilesPath()
        {
            string clickedDirectory = DirectoryOutput.SelectedItems[0].ToString();
            string SelectedPath = CurrentPath + clickedDirectory + "\\";
            CurrentPath = SelectedPath;
           
        }

        private void Base_Load(object sender, EventArgs e)
        {
            GetFolders(StartingPath);
            GetFiles(StartingPath);
        }

        private void DirectoryOutput_DoubleClick(object sender, EventArgs e)
        {
            GetsteppedIntoFilesPath();
            DirectoryOutput.Items.Clear();          
            GetFolders(CurrentPath);
            GetFiles(CurrentPath);
        }
        
        private void GetFolders(string path)
        {
            DirectoryOutput.Items.Add("Folders:");
            DirectoryOutput.Items.Add("\r\n");
            try
            {
                DirectoryInfo dInfo = new DirectoryInfo(path);
                DirectoryInfo[] Folders = dInfo.GetDirectories();
                foreach (DirectoryInfo folders in Folders) DirectoryOutput.Items.Add(folders.Name);
            } catch {}
        }

        private void GetFiles(string path)
        {
            DirectoryOutput.Items.Add("\r\n");
            DirectoryOutput.Items.Add("Files:");
            DirectoryOutput.Items.Add("\r\n");
            try
            {
                DirectoryInfo dInfo = new DirectoryInfo(path);
                FileInfo[] Files = dInfo.GetFiles();
                foreach (FileInfo file in Files) DirectoryOutput.Items.Add(file.Name);
            } catch {}           
        }

        private void StepBackButton_Click(object sender, EventArgs e)
        {
            if (CurrentPath != StartingPath)
            {
                string[] SplittedPath = CurrentPath.Split('\\');
                int PathPartToIgnore = SplittedPath[SplittedPath.Length - 2].Length;
                string newPath = "";
                for (int i = 0; i < CurrentPath.Length - PathPartToIgnore - 1; i++) newPath += CurrentPath[i];
                DirectoryOutput.Items.Clear();
                CurrentPath = newPath;
                GetFolders(CurrentPath);
                GetFiles(CurrentPath);
            }           
        }

        private void CompressFile(DirectoryInfo directorySelected)
        {

            foreach (FileInfo fileToCompress in directorySelected.GetFiles())
            {
                using (FileStream originalFileStream = fileToCompress.OpenRead())
                {
                    if ((File.GetAttributes(fileToCompress.FullName) &
                       FileAttributes.Hidden) != FileAttributes.Hidden & fileToCompress.Extension != ".gz")
                    {
                        using (FileStream compressedFileStream = File.Create(fileToCompress.FullName + ".gz"))
                        {
                            using (System.IO.Compression.GZipStream compressionStream = new System.IO.Compression.GZipStream(compressedFileStream,
                               System.IO.Compression.CompressionMode.Compress))
                            {
                                originalFileStream.CopyTo(compressionStream);

                            }
                        }
                        FileInfo info = new FileInfo(CurrentPath + "\\" + fileToCompress.Name + ".gz");
                    }

                }
            }
        }

        public static void DecompressFile(FileInfo fileToDecompress)
        {
            try
            {
                using (FileStream originalFileStream = fileToDecompress.OpenRead())
                {
                    string currentFileName = fileToDecompress.FullName;
                    string newFileName = currentFileName.Remove(currentFileName.Length - fileToDecompress.Extension.Length);
                    using (FileStream decompressedFileStream = File.Create(newFileName))
                    {
                        using (System.IO.Compression.GZipStream decompressionStream = new System.IO.Compression.GZipStream(originalFileStream, System.IO.Compression.CompressionMode.Decompress))
                        {
                            decompressionStream.CopyTo(decompressedFileStream);
                        }
                    }
                }
            } catch {
                MessageBox.Show("You can decompress only .gz files.", "Decompression error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void CompressButton_Click(object sender, EventArgs e)
        {
            string selectedPath = GetSelectedFilesPath();
            DirectoryInfo directorySelected = new DirectoryInfo(selectedPath);
            CompressFile(directorySelected);
        }

        private void DecompressButton_Click(object sender, EventArgs e)
        {
            string selectedPath = GetSelectedFilesPath();
            string path = Path.GetFullPath(selectedPath);
            FileInfo FileSelected = new FileInfo(path);
            DecompressFile(FileSelected);
        }
    }
}
