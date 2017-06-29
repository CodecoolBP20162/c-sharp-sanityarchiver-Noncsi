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
                    Table.Items.Add(list);
                };
            }
            catch { }
        }
    }
}
