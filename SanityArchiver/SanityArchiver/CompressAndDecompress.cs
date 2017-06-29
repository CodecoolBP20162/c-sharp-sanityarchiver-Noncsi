using System.IO;
using System.Windows.Forms;

namespace SanityArchiver
{
    public class CompressAndDecompress
    { 
        public void CompressFile(FileInfo FileSelected, string CurrentPath)
        {
            try
            {
                using (FileStream originalFileStream = FileSelected.OpenRead())
                {
                    if ((File.GetAttributes(FileSelected.FullName) &
                        FileAttributes.Hidden) != FileAttributes.Hidden & FileSelected.Extension != ".gz")
                    {
                        using (FileStream compressedFileStream = File.Create(FileSelected.FullName + ".gz"))
                        {
                            using (System.IO.Compression.GZipStream compressionStream = new System.IO.Compression.GZipStream(compressedFileStream,
                                System.IO.Compression.CompressionMode.Compress))
                            {
                                originalFileStream.CopyTo(compressionStream);

                            }
                        }
                        FileInfo info = new FileInfo(CurrentPath + "\\" + FileSelected.Name + ".gz");
                    }
                }
            }  catch { MessageBox.Show("Compresssion failed.", "Compression error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }


        public void DecompressFile(FileInfo fileToDecompress)
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
            }
            catch { MessageBox.Show("Extraction failed.", "Decompression error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}

