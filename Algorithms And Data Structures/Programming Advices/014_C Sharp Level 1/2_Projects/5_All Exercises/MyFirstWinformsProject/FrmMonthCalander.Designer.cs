namespace MyFirstWinformsProject
{
    partial class FrmMonthCalander
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnStartRange = new System.Windows.Forms.Button();
            this.btnEndRange = new System.Windows.Forms.Button();
            this.btnSelectedrange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(242, 30);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // btnStartRange
            // 
            this.btnStartRange.Location = new System.Drawing.Point(242, 213);
            this.btnStartRange.Name = "btnStartRange";
            this.btnStartRange.Size = new System.Drawing.Size(75, 23);
            this.btnStartRange.TabIndex = 1;
            this.btnStartRange.Text = "Start Range";
            this.btnStartRange.UseVisualStyleBackColor = true;
            this.btnStartRange.Click += new System.EventHandler(this.btnStartRange_Click);
            // 
            // btnEndRange
            // 
            this.btnEndRange.Location = new System.Drawing.Point(242, 242);
            this.btnEndRange.Name = "btnEndRange";
            this.btnEndRange.Size = new System.Drawing.Size(75, 23);
            this.btnEndRange.TabIndex = 1;
            this.btnEndRange.Text = "End Range";
            this.btnEndRange.UseVisualStyleBackColor = true;
            this.btnEndRange.Click += new System.EventHandler(this.btnEndRange_Click);
            // 
            // btnSelectedrange
            // 
            this.btnSelectedrange.Location = new System.Drawing.Point(242, 271);
            this.btnSelectedrange.Name = "btnSelectedrange";
            this.btnSelectedrange.Size = new System.Drawing.Size(92, 23);
            this.btnSelectedrange.TabIndex = 1;
            this.btnSelectedrange.Text = "Selected range";
            this.btnSelectedrange.UseVisualStyleBackColor = true;
            this.btnSelectedrange.Click += new System.EventHandler(this.btnSelectedrange_Click);
            // 
            // FrmMonthCalander
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEndRange);
            this.Controls.Add(this.btnSelectedrange);
            this.Controls.Add(this.btnStartRange);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "FrmMonthCalander";
            this.Text = "FrmMonthCalander";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnStartRange;
        private System.Windows.Forms.Button btnEndRange;
        private System.Windows.Forms.Button btnSelectedrange;
    }
}