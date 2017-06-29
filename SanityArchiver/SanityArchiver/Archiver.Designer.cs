namespace SanityArchiver
{
    partial class SanityArchiver
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanityArchiver));
            this.StepBackButton = new System.Windows.Forms.PictureBox();
            this.CompressButton = new System.Windows.Forms.PictureBox();
            this.DecompressButton = new System.Windows.Forms.PictureBox();
            this.RenameButton = new System.Windows.Forms.PictureBox();
            this.OpenFileButton = new System.Windows.Forms.PictureBox();
            this.Table = new System.Windows.Forms.ListView();
            this.image = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Extension = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DeleteFileButton = new System.Windows.Forms.PictureBox();
            this.EncryptButton = new System.Windows.Forms.PictureBox();
            this.DecryptButton = new System.Windows.Forms.PictureBox();
            this.NewFileNameTextBox = new System.Windows.Forms.TextBox();
            this.NewFileNameOkButton = new System.Windows.Forms.Button();
            this.NewFileNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StepBackButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompressButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DecompressButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RenameButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenFileButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteFileButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EncryptButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DecryptButton)).BeginInit();
            this.SuspendLayout();
            // 
            // StepBackButton
            // 
            this.StepBackButton.BackColor = System.Drawing.Color.Transparent;
            this.StepBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StepBackButton.Image = ((System.Drawing.Image)(resources.GetObject("StepBackButton.Image")));
            this.StepBackButton.Location = new System.Drawing.Point(12, 12);
            this.StepBackButton.Name = "StepBackButton";
            this.StepBackButton.Size = new System.Drawing.Size(34, 24);
            this.StepBackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StepBackButton.TabIndex = 1;
            this.StepBackButton.TabStop = false;
            this.StepBackButton.Click += new System.EventHandler(this.StepBackButton_Click);
            // 
            // CompressButton
            // 
            this.CompressButton.BackColor = System.Drawing.Color.Transparent;
            this.CompressButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CompressButton.Image = ((System.Drawing.Image)(resources.GetObject("CompressButton.Image")));
            this.CompressButton.Location = new System.Drawing.Point(79, 9);
            this.CompressButton.Name = "CompressButton";
            this.CompressButton.Size = new System.Drawing.Size(30, 27);
            this.CompressButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CompressButton.TabIndex = 4;
            this.CompressButton.TabStop = false;
            this.CompressButton.Click += new System.EventHandler(this.CompressButton_Click);
            // 
            // DecompressButton
            // 
            this.DecompressButton.BackColor = System.Drawing.Color.Transparent;
            this.DecompressButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DecompressButton.Image = ((System.Drawing.Image)(resources.GetObject("DecompressButton.Image")));
            this.DecompressButton.Location = new System.Drawing.Point(115, 9);
            this.DecompressButton.Name = "DecompressButton";
            this.DecompressButton.Size = new System.Drawing.Size(29, 27);
            this.DecompressButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DecompressButton.TabIndex = 6;
            this.DecompressButton.TabStop = false;
            this.DecompressButton.Click += new System.EventHandler(this.DecompressButton_Click);
            // 
            // RenameButton
            // 
            this.RenameButton.BackColor = System.Drawing.Color.Transparent;
            this.RenameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RenameButton.Image = ((System.Drawing.Image)(resources.GetObject("RenameButton.Image")));
            this.RenameButton.Location = new System.Drawing.Point(179, 9);
            this.RenameButton.Name = "RenameButton";
            this.RenameButton.Size = new System.Drawing.Size(29, 27);
            this.RenameButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RenameButton.TabIndex = 7;
            this.RenameButton.TabStop = false;
            this.RenameButton.Click += new System.EventHandler(this.RenameButton_Click);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.BackColor = System.Drawing.Color.Transparent;
            this.OpenFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenFileButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenFileButton.Image")));
            this.OpenFileButton.Location = new System.Drawing.Point(214, 9);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(41, 27);
            this.OpenFileButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OpenFileButton.TabIndex = 11;
            this.OpenFileButton.TabStop = false;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // Table
            // 
            this.Table.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.image,
            this.Name,
            this.Extension,
            this.Size});
            this.Table.FullRowSelect = true;
            this.Table.Location = new System.Drawing.Point(12, 47);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(640, 675);
            this.Table.TabIndex = 12;
            this.Table.UseCompatibleStateImageBehavior = false;
            this.Table.View = System.Windows.Forms.View.Details;
            this.Table.DoubleClick += new System.EventHandler(this.Table_DoubleClick);
            // 
            // image
            // 
            this.image.Tag = "asd";
            this.image.Text = "";
            this.image.Width = 25;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 181;
            // 
            // Extension
            // 
            this.Extension.Text = "Extension";
            this.Extension.Width = 68;
            // 
            // Size
            // 
            this.Size.Text = "Size";
            this.Size.Width = 199;
            // 
            // DeleteFileButton
            // 
            this.DeleteFileButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteFileButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteFileButton.Image")));
            this.DeleteFileButton.Location = new System.Drawing.Point(628, 9);
            this.DeleteFileButton.Name = "DeleteFileButton";
            this.DeleteFileButton.Size = new System.Drawing.Size(24, 28);
            this.DeleteFileButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DeleteFileButton.TabIndex = 13;
            this.DeleteFileButton.TabStop = false;
            this.DeleteFileButton.Click += new System.EventHandler(this.DeleteFileButton_Click);
            // 
            // EncryptButton
            // 
            this.EncryptButton.BackColor = System.Drawing.Color.Transparent;
            this.EncryptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EncryptButton.Image = ((System.Drawing.Image)(resources.GetObject("EncryptButton.Image")));
            this.EncryptButton.Location = new System.Drawing.Point(306, 9);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(24, 25);
            this.EncryptButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EncryptButton.TabIndex = 14;
            this.EncryptButton.TabStop = false;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.BackColor = System.Drawing.Color.Transparent;
            this.DecryptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DecryptButton.Image = ((System.Drawing.Image)(resources.GetObject("DecryptButton.Image")));
            this.DecryptButton.Location = new System.Drawing.Point(336, 9);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(24, 25);
            this.DecryptButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DecryptButton.TabIndex = 15;
            this.DecryptButton.TabStop = false;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // NewFileNameTextBox
            // 
            this.NewFileNameTextBox.Location = new System.Drawing.Point(336, 733);
            this.NewFileNameTextBox.Name = "NewFileNameTextBox";
            this.NewFileNameTextBox.Size = new System.Drawing.Size(223, 20);
            this.NewFileNameTextBox.TabIndex = 16;
            this.NewFileNameTextBox.Visible = false;
            this.NewFileNameTextBox.TextChanged += new System.EventHandler(this.NewFileNameTextBox_TextChanged);
            // 
            // NewFileNameOkButton
            // 
            this.NewFileNameOkButton.Location = new System.Drawing.Point(577, 731);
            this.NewFileNameOkButton.Name = "NewFileNameOkButton";
            this.NewFileNameOkButton.Size = new System.Drawing.Size(75, 23);
            this.NewFileNameOkButton.TabIndex = 17;
            this.NewFileNameOkButton.Text = "Ok";
            this.NewFileNameOkButton.UseVisualStyleBackColor = true;
            this.NewFileNameOkButton.Visible = false;
            this.NewFileNameOkButton.Click += new System.EventHandler(this.NewFileNameOkButton_Click);
            // 
            // NewFileNameLabel
            // 
            this.NewFileNameLabel.AutoSize = true;
            this.NewFileNameLabel.Location = new System.Drawing.Point(23, 736);
            this.NewFileNameLabel.Name = "NewFileNameLabel";
            this.NewFileNameLabel.Size = new System.Drawing.Size(296, 13);
            this.NewFileNameLabel.TabIndex = 18;
            this.NewFileNameLabel.Text = "Write the new name for your file. You must add the extension!";
            this.NewFileNameLabel.Visible = false;
            // 
            // SanityArchiver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(664, 770);
            this.Controls.Add(this.NewFileNameLabel);
            this.Controls.Add(this.NewFileNameOkButton);
            this.Controls.Add(this.NewFileNameTextBox);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.DeleteFileButton);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.RenameButton);
            this.Controls.Add(this.DecompressButton);
            this.Controls.Add(this.CompressButton);
            this.Controls.Add(this.StepBackButton);
            this.Text = "Total Catmander";
            this.Load += new System.EventHandler(this.SanityArchiver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StepBackButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompressButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DecompressButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RenameButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenFileButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteFileButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EncryptButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DecryptButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox StepBackButton;
        private System.Windows.Forms.PictureBox CompressButton;
        private System.Windows.Forms.PictureBox DecompressButton;
        private System.Windows.Forms.PictureBox RenameButton;
        private System.Windows.Forms.PictureBox OpenFileButton;
        private System.Windows.Forms.ListView Table;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Extension;
        private System.Windows.Forms.ColumnHeader image;
        private System.Windows.Forms.PictureBox DeleteFileButton;
        private System.Windows.Forms.PictureBox EncryptButton;
        private System.Windows.Forms.PictureBox DecryptButton;
        private System.Windows.Forms.TextBox NewFileNameTextBox;
        private System.Windows.Forms.Button NewFileNameOkButton;
        private System.Windows.Forms.Label NewFileNameLabel;
        private System.Windows.Forms.ColumnHeader Size;
    }
}

