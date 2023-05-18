namespace MyFirstWinformsProject
{
    partial class FrrmProgressBar
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblLoading = new System.Windows.Forms.Label();
            this.btnLoading = new System.Windows.Forms.Button();
            this.btnResetLoading = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(246, 83);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(270, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Location = new System.Drawing.Point(243, 67);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(44, 13);
            this.lblLoading.TabIndex = 1;
            this.lblLoading.Text = "Loading";
            // 
            // btnLoading
            // 
            this.btnLoading.Location = new System.Drawing.Point(246, 152);
            this.btnLoading.Name = "btnLoading";
            this.btnLoading.Size = new System.Drawing.Size(75, 23);
            this.btnLoading.TabIndex = 2;
            this.btnLoading.Text = "Loading";
            this.btnLoading.UseVisualStyleBackColor = true;
            this.btnLoading.Click += new System.EventHandler(this.btnLoading_Click);
            // 
            // btnResetLoading
            // 
            this.btnResetLoading.Location = new System.Drawing.Point(396, 152);
            this.btnResetLoading.Name = "btnResetLoading";
            this.btnResetLoading.Size = new System.Drawing.Size(120, 23);
            this.btnResetLoading.TabIndex = 2;
            this.btnResetLoading.Text = "Reset Loading";
            this.btnResetLoading.UseVisualStyleBackColor = true;
            this.btnResetLoading.Click += new System.EventHandler(this.btnResetLoading_Click);
            // 
            // FrrmProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnResetLoading);
            this.Controls.Add(this.btnLoading);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.progressBar1);
            this.Name = "FrrmProgressBar";
            this.Text = "FrrmProgressBar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Button btnLoading;
        private System.Windows.Forms.Button btnResetLoading;
    }
}