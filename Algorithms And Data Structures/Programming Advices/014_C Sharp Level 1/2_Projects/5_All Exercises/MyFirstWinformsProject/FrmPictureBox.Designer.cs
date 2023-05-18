namespace MyFirstWinformsProject
{
    partial class FrmPictureBox
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
            this.btnWeak = new System.Windows.Forms.Button();
            this.btnStrong = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWeak
            // 
            this.btnWeak.Location = new System.Drawing.Point(295, 283);
            this.btnWeak.Name = "btnWeak";
            this.btnWeak.Size = new System.Drawing.Size(75, 23);
            this.btnWeak.TabIndex = 1;
            this.btnWeak.Text = "Weak";
            this.btnWeak.UseVisualStyleBackColor = true;
            this.btnWeak.Click += new System.EventHandler(this.btnWeak_Click);
            // 
            // btnStrong
            // 
            this.btnStrong.Location = new System.Drawing.Point(389, 283);
            this.btnStrong.Name = "btnStrong";
            this.btnStrong.Size = new System.Drawing.Size(75, 23);
            this.btnStrong.TabIndex = 1;
            this.btnStrong.Text = "Strong";
            this.btnStrong.UseVisualStyleBackColor = true;
            this.btnStrong.Click += new System.EventHandler(this.btnStrong_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyFirstWinformsProject.Properties.Resources.Weak;
            this.pictureBox1.Location = new System.Drawing.Point(295, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStrong);
            this.Controls.Add(this.btnWeak);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmPictureBox";
            this.Text = "FrmPictureBox";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnWeak;
        private System.Windows.Forms.Button btnStrong;
    }
}