namespace MyFirstWinformsProject
{
    partial class FrmNotifyIcon
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
            this.components = new System.ComponentModel.Container();
            this.btnShowNotify = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // btnShowNotify
            // 
            this.btnShowNotify.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowNotify.Location = new System.Drawing.Point(301, 140);
            this.btnShowNotify.Name = "btnShowNotify";
            this.btnShowNotify.Size = new System.Drawing.Size(207, 67);
            this.btnShowNotify.TabIndex = 0;
            this.btnShowNotify.Text = "Show Notify";
            this.btnShowNotify.UseVisualStyleBackColor = true;
            this.btnShowNotify.Click += new System.EventHandler(this.btnShowNotify_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClicked);
            // 
            // FrmNotifyIcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowNotify);
            this.Name = "FrmNotifyIcon";
            this.Text = "FrmNotifyIcon";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowNotify;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}