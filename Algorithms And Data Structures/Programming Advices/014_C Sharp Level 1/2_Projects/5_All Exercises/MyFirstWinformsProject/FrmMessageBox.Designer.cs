namespace MyFirstWinformsProject
{
    partial class FrmMessageBox
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
            this.btnShowMessage = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnShowMessageWithTitleandButtonsandImage = new System.Windows.Forms.Button();
            this.btnShowMessageWithTitleandButtonsandImageandDefaultButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowMessage
            // 
            this.btnShowMessage.Location = new System.Drawing.Point(68, 55);
            this.btnShowMessage.Name = "btnShowMessage";
            this.btnShowMessage.Size = new System.Drawing.Size(108, 45);
            this.btnShowMessage.TabIndex = 0;
            this.btnShowMessage.Text = "Show Message";
            this.btnShowMessage.UseVisualStyleBackColor = true;
            this.btnShowMessage.Click += new System.EventHandler(this.btnShowMessage_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show Message With Title";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(353, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 45);
            this.button2.TabIndex = 0;
            this.button2.Text = "Show Message With Title and Buttons";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnShowMessageWithTitleandButtonsandImage
            // 
            this.btnShowMessageWithTitleandButtonsandImage.Location = new System.Drawing.Point(353, 126);
            this.btnShowMessageWithTitleandButtonsandImage.Name = "btnShowMessageWithTitleandButtonsandImage";
            this.btnShowMessageWithTitleandButtonsandImage.Size = new System.Drawing.Size(135, 45);
            this.btnShowMessageWithTitleandButtonsandImage.TabIndex = 0;
            this.btnShowMessageWithTitleandButtonsandImage.Text = "Show Message With Title and Buttons and Image";
            this.btnShowMessageWithTitleandButtonsandImage.UseVisualStyleBackColor = true;
            this.btnShowMessageWithTitleandButtonsandImage.Click += new System.EventHandler(this.btnShowMessageWithTitleandButtonsandImage_Click);
            // 
            // btnShowMessageWithTitleandButtonsandImageandDefaultButton
            // 
            this.btnShowMessageWithTitleandButtonsandImageandDefaultButton.Location = new System.Drawing.Point(353, 190);
            this.btnShowMessageWithTitleandButtonsandImageandDefaultButton.Name = "btnShowMessageWithTitleandButtonsandImageandDefaultButton";
            this.btnShowMessageWithTitleandButtonsandImageandDefaultButton.Size = new System.Drawing.Size(135, 56);
            this.btnShowMessageWithTitleandButtonsandImageandDefaultButton.TabIndex = 0;
            this.btnShowMessageWithTitleandButtonsandImageandDefaultButton.Text = "Show Message With Title and Buttons and Image, and Default Button";
            this.btnShowMessageWithTitleandButtonsandImageandDefaultButton.UseVisualStyleBackColor = true;
            this.btnShowMessageWithTitleandButtonsandImageandDefaultButton.Click += new System.EventHandler(this.btnShowMessageWithTitleandButtonsandImageandDefaultButton_Click);
            // 
            // frmMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowMessageWithTitleandButtonsandImageandDefaultButton);
            this.Controls.Add(this.btnShowMessageWithTitleandButtonsandImage);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnShowMessage);
            this.Name = "frmMessageBox";
            this.Text = "frmMessageBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowMessage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnShowMessageWithTitleandButtonsandImage;
        private System.Windows.Forms.Button btnShowMessageWithTitleandButtonsandImageandDefaultButton;
    }
}