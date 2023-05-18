namespace MyFirstWinformsProject
{
    partial class Frm1
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnCopyOnMouseClick = new System.Windows.Forms.Button();
            this.btnCopyOnMouseEnter = new System.Windows.Forms.Button();
            this.btnText1ToRed = new System.Windows.Forms.Button();
            this.btnDisableText1 = new System.Windows.Forms.Button();
            this.btnHideText1 = new System.Windows.Forms.Button();
            this.btnChangeFormTitle = new System.Windows.Forms.Button();
            this.btnText1ToWhite = new System.Windows.Forms.Button();
            this.btnEnableText1 = new System.Windows.Forms.Button();
            this.btnShowText1 = new System.Windows.Forms.Button();
            this.btnChangeLabel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(160, 88);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 0;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(403, 88);
            this.txt2.Name = "txt2";
            this.txt2.ReadOnly = true;
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 1;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Tahoma", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.Red;
            this.lbl1.Location = new System.Drawing.Point(280, 24);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(115, 39);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "label1";
            // 
            // btnCopyOnMouseClick
            // 
            this.btnCopyOnMouseClick.Location = new System.Drawing.Point(160, 177);
            this.btnCopyOnMouseClick.Name = "btnCopyOnMouseClick";
            this.btnCopyOnMouseClick.Size = new System.Drawing.Size(127, 39);
            this.btnCopyOnMouseClick.TabIndex = 2;
            this.btnCopyOnMouseClick.Text = "Copy On Mouse Click";
            this.btnCopyOnMouseClick.UseVisualStyleBackColor = true;
            this.btnCopyOnMouseClick.Click += new System.EventHandler(this.btnCopyOnMouseClick_Click);
            // 
            // btnCopyOnMouseEnter
            // 
            this.btnCopyOnMouseEnter.Location = new System.Drawing.Point(307, 177);
            this.btnCopyOnMouseEnter.Name = "btnCopyOnMouseEnter";
            this.btnCopyOnMouseEnter.Size = new System.Drawing.Size(127, 39);
            this.btnCopyOnMouseEnter.TabIndex = 2;
            this.btnCopyOnMouseEnter.Text = "Copy On Mouse Enter";
            this.btnCopyOnMouseEnter.UseVisualStyleBackColor = true;
            this.btnCopyOnMouseEnter.MouseEnter += new System.EventHandler(this.btnCopyOnMouseEnter_MouseEnter);
            // 
            // btnText1ToRed
            // 
            this.btnText1ToRed.Location = new System.Drawing.Point(454, 177);
            this.btnText1ToRed.Name = "btnText1ToRed";
            this.btnText1ToRed.Size = new System.Drawing.Size(127, 39);
            this.btnText1ToRed.TabIndex = 2;
            this.btnText1ToRed.Text = "Text1 To Red";
            this.btnText1ToRed.UseVisualStyleBackColor = true;
            this.btnText1ToRed.Click += new System.EventHandler(this.btnText1ToRed_Click);
            // 
            // btnDisableText1
            // 
            this.btnDisableText1.Location = new System.Drawing.Point(160, 256);
            this.btnDisableText1.Name = "btnDisableText1";
            this.btnDisableText1.Size = new System.Drawing.Size(127, 39);
            this.btnDisableText1.TabIndex = 2;
            this.btnDisableText1.Text = "Disable Text 1";
            this.btnDisableText1.UseVisualStyleBackColor = true;
            this.btnDisableText1.Click += new System.EventHandler(this.btnDisableText1_Click);
            // 
            // btnHideText1
            // 
            this.btnHideText1.Location = new System.Drawing.Point(307, 256);
            this.btnHideText1.Name = "btnHideText1";
            this.btnHideText1.Size = new System.Drawing.Size(127, 39);
            this.btnHideText1.TabIndex = 2;
            this.btnHideText1.Text = "Hide Text 1";
            this.btnHideText1.UseVisualStyleBackColor = true;
            this.btnHideText1.Click += new System.EventHandler(this.btnHideText1_Click);
            // 
            // btnChangeFormTitle
            // 
            this.btnChangeFormTitle.Location = new System.Drawing.Point(454, 256);
            this.btnChangeFormTitle.Name = "btnChangeFormTitle";
            this.btnChangeFormTitle.Size = new System.Drawing.Size(127, 39);
            this.btnChangeFormTitle.TabIndex = 2;
            this.btnChangeFormTitle.Text = "Change Form Title";
            this.btnChangeFormTitle.UseVisualStyleBackColor = true;
            this.btnChangeFormTitle.Click += new System.EventHandler(this.btnChangeFormTitle_Click);
            // 
            // btnText1ToWhite
            // 
            this.btnText1ToWhite.Location = new System.Drawing.Point(160, 326);
            this.btnText1ToWhite.Name = "btnText1ToWhite";
            this.btnText1ToWhite.Size = new System.Drawing.Size(127, 39);
            this.btnText1ToWhite.TabIndex = 2;
            this.btnText1ToWhite.Text = "Text1 To White";
            this.btnText1ToWhite.UseVisualStyleBackColor = true;
            this.btnText1ToWhite.Click += new System.EventHandler(this.btnText1ToWhite_Click);
            // 
            // btnEnableText1
            // 
            this.btnEnableText1.Location = new System.Drawing.Point(307, 326);
            this.btnEnableText1.Name = "btnEnableText1";
            this.btnEnableText1.Size = new System.Drawing.Size(127, 39);
            this.btnEnableText1.TabIndex = 2;
            this.btnEnableText1.Text = "Enable Text 1";
            this.btnEnableText1.UseVisualStyleBackColor = true;
            this.btnEnableText1.Click += new System.EventHandler(this.btnEnableText1_Click);
            // 
            // btnShowText1
            // 
            this.btnShowText1.Location = new System.Drawing.Point(454, 326);
            this.btnShowText1.Name = "btnShowText1";
            this.btnShowText1.Size = new System.Drawing.Size(127, 39);
            this.btnShowText1.TabIndex = 2;
            this.btnShowText1.Text = "Show Text 1";
            this.btnShowText1.UseVisualStyleBackColor = true;
            this.btnShowText1.Click += new System.EventHandler(this.btnShowText1_Click);
            // 
            // btnChangeLabel
            // 
            this.btnChangeLabel.Location = new System.Drawing.Point(611, 177);
            this.btnChangeLabel.Name = "btnChangeLabel";
            this.btnChangeLabel.Size = new System.Drawing.Size(127, 39);
            this.btnChangeLabel.TabIndex = 2;
            this.btnChangeLabel.Text = "Change Label";
            this.btnChangeLabel.UseVisualStyleBackColor = true;
            this.btnChangeLabel.Click += new System.EventHandler(this.btnChangeLabel_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(611, 240);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(127, 125);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnChangeFormTitle);
            this.Controls.Add(this.btnHideText1);
            this.Controls.Add(this.btnDisableText1);
            this.Controls.Add(this.btnChangeLabel);
            this.Controls.Add(this.btnShowText1);
            this.Controls.Add(this.btnEnableText1);
            this.Controls.Add(this.btnText1ToWhite);
            this.Controls.Add(this.btnText1ToRed);
            this.Controls.Add(this.btnCopyOnMouseEnter);
            this.Controls.Add(this.btnCopyOnMouseClick);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Name = "frm1";
            this.Text = "This is the initial Title";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnCopyOnMouseClick;
        private System.Windows.Forms.Button btnCopyOnMouseEnter;
        private System.Windows.Forms.Button btnText1ToRed;
        private System.Windows.Forms.Button btnDisableText1;
        private System.Windows.Forms.Button btnHideText1;
        private System.Windows.Forms.Button btnChangeFormTitle;
        private System.Windows.Forms.Button btnText1ToWhite;
        private System.Windows.Forms.Button btnEnableText1;
        private System.Windows.Forms.Button btnShowText1;
        private System.Windows.Forms.Button btnChangeLabel;
        private System.Windows.Forms.Button btnClose;
    }
}