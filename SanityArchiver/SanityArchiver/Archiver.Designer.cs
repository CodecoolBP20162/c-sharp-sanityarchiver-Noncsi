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
            this.ApproveNewFileNameButton = new System.Windows.Forms.Button();
            this.RenameFileTextBox = new System.Windows.Forms.TextBox();
            this.RenameFileLabel = new System.Windows.Forms.Label();
            this.OpenFileButton = new System.Windows.Forms.PictureBox();
            this.Table = new System.Windows.Forms.ListView();
            this.image = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Extension = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DeleteFileButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.StepBackButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompressButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DecompressButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RenameButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenFileButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteFileButton)).BeginInit();
            this.SuspendLayout();
            // 
            // StepBackButton
            // 
            this.StepBackButton.BackColor = System.Drawing.Color.White;
            this.StepBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StepBackButton.Image = ((System.Drawing.Image)(resources.GetObject("StepBackButton.Image")));
            this.StepBackButton.Location = new System.Drawing.Point(12, 39);
            this.StepBackButton.Name = "StepBackButton";
            this.StepBackButton.Size = new System.Drawing.Size(34, 29);
            this.StepBackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StepBackButton.TabIndex = 1;
            this.StepBackButton.TabStop = false;
            this.StepBackButton.Click += new System.EventHandler(this.StepBackButton_Click);
            // 
            // CompressButton
            // 
            this.CompressButton.BackColor = System.Drawing.Color.White;
            this.CompressButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CompressButton.Image = ((System.Drawing.Image)(resources.GetObject("CompressButton.Image")));
            this.CompressButton.Location = new System.Drawing.Point(52, 39);
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
            this.DecompressButton.Location = new System.Drawing.Point(88, 39);
            this.DecompressButton.Name = "DecompressButton";
            this.DecompressButton.Size = new System.Drawing.Size(29, 29);
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
            this.RenameButton.Location = new System.Drawing.Point(123, 39);
            this.RenameButton.Name = "RenameButton";
            this.RenameButton.Size = new System.Drawing.Size(29, 27);
            this.RenameButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RenameButton.TabIndex = 7;
            this.RenameButton.TabStop = false;
            this.RenameButton.Click += new System.EventHandler(this.RenameButton_Click);
            // 
            // ApproveNewFileNameButton
            // 
            this.ApproveNewFileNameButton.Location = new System.Drawing.Point(577, 25);
            this.ApproveNewFileNameButton.Name = "ApproveNewFileNameButton";
            this.ApproveNewFileNameButton.Size = new System.Drawing.Size(75, 23);
            this.ApproveNewFileNameButton.TabIndex = 8;
            this.ApproveNewFileNameButton.Text = "Save";
            this.ApproveNewFileNameButton.UseVisualStyleBackColor = true;
            this.ApproveNewFileNameButton.Visible = false;
            this.ApproveNewFileNameButton.Click += new System.EventHandler(this.ApproveNewFileNameButton_Click);
            // 
            // RenameFileTextBox
            // 
            this.RenameFileTextBox.Location = new System.Drawing.Point(342, 25);
            this.RenameFileTextBox.Name = "RenameFileTextBox";
            this.RenameFileTextBox.Size = new System.Drawing.Size(229, 20);
            this.RenameFileTextBox.TabIndex = 9;
            this.RenameFileTextBox.Visible = false;
            // 
            // RenameFileLabel
            // 
            this.RenameFileLabel.AutoSize = true;
            this.RenameFileLabel.Location = new System.Drawing.Point(339, 9);
            this.RenameFileLabel.Name = "RenameFileLabel";
            this.RenameFileLabel.Size = new System.Drawing.Size(278, 13);
            this.RenameFileLabel.TabIndex = 10;
            this.RenameFileLabel.Text = "Rename the selected file. You have to add the extension!";
            this.RenameFileLabel.Visible = false;
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.BackColor = System.Drawing.Color.Transparent;
            this.OpenFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenFileButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenFileButton.Image")));
            this.OpenFileButton.Location = new System.Drawing.Point(158, 39);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(41, 25);
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
            this.Extension});
            this.Table.FullRowSelect = true;
            this.Table.Location = new System.Drawing.Point(12, 74);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(640, 684);
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
            this.Name.Width = 155;
            // 
            // Extension
            // 
            this.Extension.Text = "Extension";
            // 
            // DeleteFileButton
            // 
            this.DeleteFileButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteFileButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteFileButton.Image")));
            this.DeleteFileButton.Location = new System.Drawing.Point(205, 39);
            this.DeleteFileButton.Name = "DeleteFileButton";
            this.DeleteFileButton.Size = new System.Drawing.Size(23, 25);
            this.DeleteFileButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DeleteFileButton.TabIndex = 13;
            this.DeleteFileButton.TabStop = false;
            this.DeleteFileButton.Click += new System.EventHandler(this.DeleteFileButton_Click);
            // 
            // SanityArchiver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(664, 770);
            this.Controls.Add(this.DeleteFileButton);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.RenameFileLabel);
            this.Controls.Add(this.RenameFileTextBox);
            this.Controls.Add(this.ApproveNewFileNameButton);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox StepBackButton;
        private System.Windows.Forms.PictureBox CompressButton;
        private System.Windows.Forms.PictureBox DecompressButton;
        private System.Windows.Forms.PictureBox RenameButton;
        private System.Windows.Forms.Button ApproveNewFileNameButton;
        private System.Windows.Forms.TextBox RenameFileTextBox;
        private System.Windows.Forms.Label RenameFileLabel;
        private System.Windows.Forms.PictureBox OpenFileButton;
        private System.Windows.Forms.ListView Table;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Extension;
        private System.Windows.Forms.ColumnHeader image;
        private System.Windows.Forms.PictureBox DeleteFileButton;
    }
}

