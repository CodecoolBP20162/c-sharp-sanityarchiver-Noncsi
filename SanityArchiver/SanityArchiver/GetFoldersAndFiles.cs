using System;
using System.IO;
using System.Windows.Forms;

namespace SanityArchiver
{
    public class GetFoldersAndFiles
    {
        public void GetFolders(string path, ListView Table)
        {
            try
            {
                DirectoryInfo dInfo = new DirectoryInfo(path);
                DirectoryInfo[] Folders = dInfo.GetDirectories();
                foreach (DirectoryInfo folder in Folders)
                {
                    ListViewItem list = new ListViewItem();
                    list.ImageIndex = 0;
                    list.SubItems.Add(folder.Name);
                    list.SubItems.Add(folder.Extension.ToUpper());
                    list.SubItems.Add("Nah..Too complex on Thursday 11 PM");
                    Table.Items.Add(list);
                };
            }
            catch { }
        }

        public void GetFiles(string path, ListView Table)
        {
            try
            {
                DirectoryInfo dInfo = new DirectoryInfo(path);
                FileInfo[] Files = dInfo.GetFiles();
                foreach (FileInfo file in Files)
                {
                    ListViewItem list = new ListViewItem();
                    list.ImageIndex = 1;
                    list.SubItems.Add(file.Name);
                    list.SubItems.Add(file.Extension.ToUpper());
                        // Calculate size in a way that simple humans can read it too
                        string[] sizes = { "B", "KB", "MB", "GB", "TB" };
                        double len = file.Length;
                        int order = 0;
                        while (len >= 1024 && order < sizes.Length - 1)
                        {
                            order++;
                            len = len / 1024;
                        }
                        string size = String.Format("{0:0.##} {1}", len, sizes[order]);
                    list.SubItems.Add(size);
                    Table.Items.Add(list);
                };
            }
            catch { }
        }
    }
}
