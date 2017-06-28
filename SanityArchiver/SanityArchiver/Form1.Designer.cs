namespace SanityArchiver
{
    partial class Base
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Base));
            this.StepBackButton = new System.Windows.Forms.PictureBox();
            this.DirectoryOutput = new System.Windows.Forms.ListBox();
            this.CompressButton = new System.Windows.Forms.PictureBox();
            this.DecompressButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.StepBackButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompressButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DecompressButton)).BeginInit();
            this.SuspendLayout();
            // 
            // StepBackButton
            // 
            this.StepBackButton.BackColor = System.Drawing.Color.White;
            this.StepBackButton.Image = ((System.Drawing.Image)(resources.GetObject("StepBackButton.Image")));
            this.StepBackButton.Location = new System.Drawing.Point(12, 13);
            this.StepBackButton.Name = "StepBackButton";
            this.StepBackButton.Size = new System.Drawing.Size(48, 36);
            this.StepBackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StepBackButton.TabIndex = 1;
            this.StepBackButton.TabStop = false;
            this.StepBackButton.Click += new System.EventHandler(this.StepBackButton_Click);
            // 
            // DirectoryOutput
            // 
            this.DirectoryOutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DirectoryOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DirectoryOutput.ForeColor = System.Drawing.Color.Black;
            this.DirectoryOutput.FormattingEnabled = true;
            this.DirectoryOutput.ItemHeight = 16;
            this.DirectoryOutput.Location = new System.Drawing.Point(12, 68);
            this.DirectoryOutput.Name = "DirectoryOutput";
            this.DirectoryOutput.Size = new System.Drawing.Size(296, 676);
            this.DirectoryOutput.TabIndex = 3;
            this.DirectoryOutput.DoubleClick += new System.EventHandler(this.DirectoryOutput_DoubleClick);
            // 
            // CompressButton
            // 
            this.CompressButton.BackColor = System.Drawing.Color.White;
            this.CompressButton.Image = ((System.Drawing.Image)(resources.GetObject("CompressButton.Image")));
            this.CompressButton.Location = new System.Drawing.Point(83, 12);
            this.CompressButton.Name = "CompressButton";
            this.CompressButton.Size = new System.Drawing.Size(36, 37);
            this.CompressButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CompressButton.TabIndex = 4;
            this.CompressButton.TabStop = false;
            this.CompressButton.Click += new System.EventHandler(this.CompressButton_Click);
            // 
            // DecompressButton
            // 
            this.DecompressButton.BackColor = System.Drawing.Color.Transparent;
            this.DecompressButton.Image = ((System.Drawing.Image)(resources.GetObject("DecompressButton.Image")));
            this.DecompressButton.Location = new System.Drawing.Point(125, 12);
            this.DecompressButton.Name = "DecompressButton";
            this.DecompressButton.Size = new System.Drawing.Size(36, 35);
            this.DecompressButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DecompressButton.TabIndex = 6;
            this.DecompressButton.TabStop = false;
            this.DecompressButton.Click += new System.EventHandler(this.DecompressButton_Click);
            // 
            // Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(664, 770);
            this.Controls.Add(this.DecompressButton);
            this.Controls.Add(this.CompressButton);
            this.Controls.Add(this.DirectoryOutput);
            this.Controls.Add(this.StepBackButton);
            this.Name = "Base";
            this.Text = "Total Catmander";
            this.Load += new System.EventHandler(this.Base_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StepBackButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompressButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DecompressButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox StepBackButton;
        private System.Windows.Forms.ListBox DirectoryOutput;
        private System.Windows.Forms.PictureBox CompressButton;
        private System.Windows.Forms.PictureBox DecompressButton;
    }
}

