namespace MyFirstWinformsProject
{
    partial class FrmDialogs
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnChangeBackColor = new System.Windows.Forms.Button();
            this.btnChangeForeColor = new System.Windows.Forms.Button();
            this.btnChangeFont = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenfile = new System.Windows.Forms.Button();
            this.btnOpenMultiFiles = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnFolderBrowsing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btnChangeBackColor
            // 
            this.btnChangeBackColor.Location = new System.Drawing.Point(73, 78);
            this.btnChangeBackColor.Name = "btnChangeBackColor";
            this.btnChangeBackColor.Size = new System.Drawing.Size(118, 23);
            this.btnChangeBackColor.TabIndex = 1;
            this.btnChangeBackColor.Text = "Change Back Color";
            this.btnChangeBackColor.UseVisualStyleBackColor = true;
            this.btnChangeBackColor.Click += new System.EventHandler(this.btnChangeBackColor_Click);
            // 
            // btnChangeForeColor
            // 
            this.btnChangeForeColor.Location = new System.Drawing.Point(197, 78);
            this.btnChangeForeColor.Name = "btnChangeForeColor";
            this.btnChangeForeColor.Size = new System.Drawing.Size(118, 23);
            this.btnChangeForeColor.TabIndex = 1;
            this.btnChangeForeColor.Text = "Change Fore Color";
            this.btnChangeForeColor.UseVisualStyleBackColor = true;
            this.btnChangeForeColor.Click += new System.EventHandler(this.btnChangeForeColor_Click);
            // 
            // btnChangeFont
            // 
            this.btnChangeFont.Location = new System.Drawing.Point(73, 134);
            this.btnChangeFont.Name = "btnChangeFont";
            this.btnChangeFont.Size = new System.Drawing.Size(118, 23);
            this.btnChangeFont.TabIndex = 1;
            this.btnChangeFont.Text = "ChangeFont";
            this.btnChangeFont.UseVisualStyleBackColor = true;
            this.btnChangeFont.Click += new System.EventHandler(this.btnChangeFont_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(73, 185);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(118, 23);
            this.btnSaveFile.TabIndex = 1;
            this.btnSaveFile.Text = "Save File";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnOpenfile
            // 
            this.btnOpenfile.Location = new System.Drawing.Point(73, 236);
            this.btnOpenfile.Name = "btnOpenfile";
            this.btnOpenfile.Size = new System.Drawing.Size(118, 23);
            this.btnOpenfile.TabIndex = 1;
            this.btnOpenfile.Text = "Open File ";
            this.btnOpenfile.UseVisualStyleBackColor = true;
            this.btnOpenfile.Click += new System.EventHandler(this.btnOpenfile_Click);
            // 
            // btnOpenMultiFiles
            // 
            this.btnOpenMultiFiles.Location = new System.Drawing.Point(197, 236);
            this.btnOpenMultiFiles.Name = "btnOpenMultiFiles";
            this.btnOpenMultiFiles.Size = new System.Drawing.Size(118, 23);
            this.btnOpenMultiFiles.TabIndex = 1;
            this.btnOpenMultiFiles.Text = "Open Multi Files";
            this.btnOpenMultiFiles.UseVisualStyleBackColor = true;
            this.btnOpenMultiFiles.Click += new System.EventHandler(this.btnOpenMultiFiles_Click);
            // 
            // btnFolderBrowsing
            // 
            this.btnFolderBrowsing.Location = new System.Drawing.Point(73, 275);
            this.btnFolderBrowsing.Name = "btnFolderBrowsing";
            this.btnFolderBrowsing.Size = new System.Drawing.Size(118, 23);
            this.btnFolderBrowsing.TabIndex = 1;
            this.btnFolderBrowsing.Text = "Folder Browsing";
            this.btnFolderBrowsing.UseVisualStyleBackColor = true;
            this.btnFolderBrowsing.Click += new System.EventHandler(this.btnFolderBrowsing_Click);
            // 
            // FrmDialogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChangeForeColor);
            this.Controls.Add(this.btnOpenMultiFiles);
            this.Controls.Add(this.btnFolderBrowsing);
            this.Controls.Add(this.btnOpenfile);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnChangeFont);
            this.Controls.Add(this.btnChangeBackColor);
            this.Controls.Add(this.textBox1);
            this.Name = "FrmDialogs";
            this.Text = "Dialogs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnChangeBackColor;
        private System.Windows.Forms.Button btnChangeForeColor;
        private System.Windows.Forms.Button btnChangeFont;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnOpenfile;
        private System.Windows.Forms.Button btnOpenMultiFiles;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnFolderBrowsing;
    }
}