using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanityArchiver
{
    public partial class FileRenameForm : System.Windows.Forms.Form
    {
        public FileRenameForm()
        {
            InitializeComponent();
        }

        private void ApproveNewFileNameButton_Click(object sender, EventArgs e)
        {
            /*string oldFilePath = GetSelectedFilesPath();
            string newFilePath = CurrentPath + RenameFileTextBox.Text;
            File.Move(oldFilePath, newFilePath);
            RenameFileTextBox.Hide();
            ApproveNewFileNameButton.Hide();
            RenameFileLabel.Hide();
            Archive.RefreshPage();*/
        }

        private void NewFileNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
