namespace MyFirstWinformsProject
{
    partial class FrmChkRadioGroup
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
            this.chkEmail = new System.Windows.Forms.CheckBox();
            this.btnSenEmail = new System.Windows.Forms.Button();
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbMeduim = new System.Windows.Forms.RadioButton();
            this.rbLarg = new System.Windows.Forms.RadioButton();
            this.btnIsSmall = new System.Windows.Forms.Button();
            this.grpCrust = new System.Windows.Forms.GroupBox();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.btnThick = new System.Windows.Forms.RadioButton();
            this.btnDisablePizzaSize = new System.Windows.Forms.Button();
            this.grpSize.SuspendLayout();
            this.grpCrust.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkEmail
            // 
            this.chkEmail.AutoSize = true;
            this.chkEmail.Location = new System.Drawing.Point(87, 94);
            this.chkEmail.Name = "chkEmail";
            this.chkEmail.Size = new System.Drawing.Size(177, 17);
            this.chkEmail.TabIndex = 0;
            this.chkEmail.Text = "Do You Want To Receive Email?";
            this.chkEmail.UseVisualStyleBackColor = true;
            this.chkEmail.CheckedChanged += new System.EventHandler(this.chkEmail_CheckedChanged);
            // 
            // btnSenEmail
            // 
            this.btnSenEmail.Location = new System.Drawing.Point(87, 126);
            this.btnSenEmail.Name = "btnSenEmail";
            this.btnSenEmail.Size = new System.Drawing.Size(75, 23);
            this.btnSenEmail.TabIndex = 1;
            this.btnSenEmail.Text = "Send Email";
            this.btnSenEmail.UseVisualStyleBackColor = true;
            this.btnSenEmail.Click += new System.EventHandler(this.btnSenEmail_Click);
            // 
            // grpSize
            // 
            this.grpSize.Controls.Add(this.rbSmall);
            this.grpSize.Controls.Add(this.rbMeduim);
            this.grpSize.Controls.Add(this.rbLarg);
            this.grpSize.Location = new System.Drawing.Point(365, 94);
            this.grpSize.Name = "grpSize";
            this.grpSize.Size = new System.Drawing.Size(200, 106);
            this.grpSize.TabIndex = 2;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "PizzaSize";
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(22, 26);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(49, 17);
            this.rbSmall.TabIndex = 3;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            // 
            // rbMeduim
            // 
            this.rbMeduim.AutoSize = true;
            this.rbMeduim.Location = new System.Drawing.Point(22, 49);
            this.rbMeduim.Name = "rbMeduim";
            this.rbMeduim.Size = new System.Drawing.Size(61, 17);
            this.rbMeduim.TabIndex = 4;
            this.rbMeduim.TabStop = true;
            this.rbMeduim.Text = "Meduim";
            this.rbMeduim.UseVisualStyleBackColor = true;
            // 
            // rbLarg
            // 
            this.rbLarg.AutoSize = true;
            this.rbLarg.Location = new System.Drawing.Point(22, 72);
            this.rbLarg.Name = "rbLarg";
            this.rbLarg.Size = new System.Drawing.Size(46, 17);
            this.rbLarg.TabIndex = 5;
            this.rbLarg.TabStop = true;
            this.rbLarg.Text = "Larg";
            this.rbLarg.UseVisualStyleBackColor = true;
            // 
            // btnIsSmall
            // 
            this.btnIsSmall.Location = new System.Drawing.Point(365, 216);
            this.btnIsSmall.Name = "btnIsSmall";
            this.btnIsSmall.Size = new System.Drawing.Size(99, 33);
            this.btnIsSmall.TabIndex = 1;
            this.btnIsSmall.Text = "Is Small Pizza";
            this.btnIsSmall.UseVisualStyleBackColor = true;
            this.btnIsSmall.Click += new System.EventHandler(this.btnIsSmall_Click);
            // 
            // grpCrust
            // 
            this.grpCrust.Controls.Add(this.rbThin);
            this.grpCrust.Controls.Add(this.btnThick);
            this.grpCrust.Location = new System.Drawing.Point(588, 94);
            this.grpCrust.Name = "grpCrust";
            this.grpCrust.Size = new System.Drawing.Size(200, 106);
            this.grpCrust.TabIndex = 2;
            this.grpCrust.TabStop = false;
            this.grpCrust.Text = "PizzaSize";
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.Location = new System.Drawing.Point(22, 26);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(45, 17);
            this.rbThin.TabIndex = 3;
            this.rbThin.TabStop = true;
            this.rbThin.Text = "Thin";
            this.rbThin.UseVisualStyleBackColor = true;
            // 
            // btnThick
            // 
            this.btnThick.AutoSize = true;
            this.btnThick.Location = new System.Drawing.Point(22, 49);
            this.btnThick.Name = "btnThick";
            this.btnThick.Size = new System.Drawing.Size(49, 17);
            this.btnThick.TabIndex = 4;
            this.btnThick.TabStop = true;
            this.btnThick.Text = "Thick";
            this.btnThick.UseVisualStyleBackColor = true;
            // 
            // btnDisablePizzaSize
            // 
            this.btnDisablePizzaSize.Location = new System.Drawing.Point(365, 266);
            this.btnDisablePizzaSize.Name = "btnDisablePizzaSize";
            this.btnDisablePizzaSize.Size = new System.Drawing.Size(99, 36);
            this.btnDisablePizzaSize.TabIndex = 1;
            this.btnDisablePizzaSize.Text = "Disable Pizza Size";
            this.btnDisablePizzaSize.UseVisualStyleBackColor = true;
            this.btnDisablePizzaSize.Click += new System.EventHandler(this.btnDisablePizzaSize_Click);
            // 
            // FrmChkRadioGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpCrust);
            this.Controls.Add(this.grpSize);
            this.Controls.Add(this.btnDisablePizzaSize);
            this.Controls.Add(this.btnIsSmall);
            this.Controls.Add(this.btnSenEmail);
            this.Controls.Add(this.chkEmail);
            this.Name = "FrmChkRadioGroup";
            this.Text = "FrmChkRadioGroup";
            this.Load += new System.EventHandler(this.FrmChkRadioGroup_Load);
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            this.grpCrust.ResumeLayout(false);
            this.grpCrust.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkEmail;
        private System.Windows.Forms.Button btnSenEmail;
        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbMeduim;
        private System.Windows.Forms.RadioButton rbLarg;
        private System.Windows.Forms.Button btnIsSmall;
        private System.Windows.Forms.GroupBox grpCrust;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.RadioButton btnThick;
        private System.Windows.Forms.Button btnDisablePizzaSize;
    }
}