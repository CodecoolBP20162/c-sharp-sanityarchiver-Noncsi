namespace SanityArchiver
{
    partial class FileRenameForm
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
            this.ApproveNewFileNameButton = new System.Windows.Forms.Button();
            this.NewFileNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ApproveNewFileNameButton
            // 
            this.ApproveNewFileNameButton.Location = new System.Drawing.Point(156, 92);
            this.ApproveNewFileNameButton.Name = "ApproveNewFileNameButton";
            this.ApproveNewFileNameButton.Size = new System.Drawing.Size(75, 23);
            this.ApproveNewFileNameButton.TabIndex = 0;
            this.ApproveNewFileNameButton.Text = "Ok";
            this.ApproveNewFileNameButton.UseVisualStyleBackColor = true;
            this.ApproveNewFileNameButton.Click += new System.EventHandler(this.ApproveNewFileNameButton_Click);
            // 
            // NewFileNameTextBox
            // 
            this.NewFileNameTextBox.Location = new System.Drawing.Point(60, 56);
            this.NewFileNameTextBox.Name = "NewFileNameTextBox";
            this.NewFileNameTextBox.Size = new System.Drawing.Size(268, 20);
            this.NewFileNameTextBox.TabIndex = 1;
            this.NewFileNameTextBox.TextChanged += new System.EventHandler(this.NewFileNameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Write the new file name in the text box. The extension have to be the same!";
            // 
            // FileRenameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 139);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewFileNameTextBox);
            this.Controls.Add(this.ApproveNewFileNameButton);
            this.Name = "FileRenameForm";
            this.Text = "Rename file";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ApproveNewFileNameButton;
        private System.Windows.Forms.TextBox NewFileNameTextBox;
        private System.Windows.Forms.Label label1;
    }
}