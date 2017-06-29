using System.IO;
using System.Windows.Forms;

namespace SanityArchiver
{
    public class EncryptAndDecrypt
    {
        public void EncryptFile(string path)
        {
            try { File.Encrypt(path); }
            catch { MessageBox.Show("Encryption failed", "Encrypting error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void DecryptFile(string path)
        {
            try { File.Decrypt(path); }
            catch { MessageBox.Show("Decryption failed.", "Decrypting error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
