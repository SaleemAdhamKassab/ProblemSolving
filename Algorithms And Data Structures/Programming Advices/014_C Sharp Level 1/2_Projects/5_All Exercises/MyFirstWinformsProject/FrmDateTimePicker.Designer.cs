namespace MyFirstWinformsProject
{
    partial class FrmDateTimePicker
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShortDate = new System.Windows.Forms.Button();
            this.btnLongDate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(89, 111);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(426, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // btnShortDate
            // 
            this.btnShortDate.Location = new System.Drawing.Point(89, 173);
            this.btnShortDate.Name = "btnShortDate";
            this.btnShortDate.Size = new System.Drawing.Size(75, 23);
            this.btnShortDate.TabIndex = 2;
            this.btnShortDate.Text = "Short Date";
            this.btnShortDate.UseVisualStyleBackColor = true;
            this.btnShortDate.Click += new System.EventHandler(this.btnShortDate_Click);
            // 
            // btnLongDate
            // 
            this.btnLongDate.Location = new System.Drawing.Point(214, 173);
            this.btnLongDate.Name = "btnLongDate";
            this.btnLongDate.Size = new System.Drawing.Size(75, 23);
            this.btnLongDate.TabIndex = 2;
            this.btnLongDate.Text = "Long Date";
            this.btnLongDate.UseVisualStyleBackColor = true;
            this.btnLongDate.Click += new System.EventHandler(this.btnLongDate_Click);
            // 
            // FrmDateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLongDate);
            this.Controls.Add(this.btnShortDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "FrmDateTimePicker";
            this.Text = "FrmDateTimePicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShortDate;
        private System.Windows.Forms.Button btnLongDate;
    }
}