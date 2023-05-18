namespace MyFirstWinformsProject
{
    partial class FrmCheckedListBox
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnAddItems = new System.Windows.Forms.Button();
            this.btnShowSelectedItems = new System.Windows.Forms.Button();
            this.btnCheckAllItems = new System.Windows.Forms.Button();
            this.btnUnCheckAllItems = new System.Windows.Forms.Button();
            this.btnRemoveFirstItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(328, 37);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 0;
            // 
            // btnAddItems
            // 
            this.btnAddItems.Location = new System.Drawing.Point(89, 175);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(117, 45);
            this.btnAddItems.TabIndex = 1;
            this.btnAddItems.Text = "Add Items";
            this.btnAddItems.UseVisualStyleBackColor = true;
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // btnShowSelectedItems
            // 
            this.btnShowSelectedItems.Location = new System.Drawing.Point(226, 175);
            this.btnShowSelectedItems.Name = "btnShowSelectedItems";
            this.btnShowSelectedItems.Size = new System.Drawing.Size(117, 45);
            this.btnShowSelectedItems.TabIndex = 1;
            this.btnShowSelectedItems.Text = "Show Checked Items";
            this.btnShowSelectedItems.UseVisualStyleBackColor = true;
            this.btnShowSelectedItems.Click += new System.EventHandler(this.btnShowSelectedItems_Click);
            // 
            // btnCheckAllItems
            // 
            this.btnCheckAllItems.Location = new System.Drawing.Point(358, 175);
            this.btnCheckAllItems.Name = "btnCheckAllItems";
            this.btnCheckAllItems.Size = new System.Drawing.Size(117, 45);
            this.btnCheckAllItems.TabIndex = 1;
            this.btnCheckAllItems.Text = "Check All Items";
            this.btnCheckAllItems.UseVisualStyleBackColor = true;
            this.btnCheckAllItems.Click += new System.EventHandler(this.btnCheckAllItems_Click);
            // 
            // btnUnCheckAllItems
            // 
            this.btnUnCheckAllItems.Location = new System.Drawing.Point(497, 175);
            this.btnUnCheckAllItems.Name = "btnUnCheckAllItems";
            this.btnUnCheckAllItems.Size = new System.Drawing.Size(117, 45);
            this.btnUnCheckAllItems.TabIndex = 1;
            this.btnUnCheckAllItems.Text = "Un Check All Items";
            this.btnUnCheckAllItems.UseVisualStyleBackColor = true;
            this.btnUnCheckAllItems.Click += new System.EventHandler(this.btnUnCheckAllItems_Click);
            // 
            // btnRemoveFirstItem
            // 
            this.btnRemoveFirstItem.Location = new System.Drawing.Point(634, 175);
            this.btnRemoveFirstItem.Name = "btnRemoveFirstItem";
            this.btnRemoveFirstItem.Size = new System.Drawing.Size(117, 45);
            this.btnRemoveFirstItem.TabIndex = 1;
            this.btnRemoveFirstItem.Text = "Remove First Item";
            this.btnRemoveFirstItem.UseVisualStyleBackColor = true;
            this.btnRemoveFirstItem.Click += new System.EventHandler(this.btnRemoveFirstItem_Click);
            // 
            // FrmCheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemoveFirstItem);
            this.Controls.Add(this.btnUnCheckAllItems);
            this.Controls.Add(this.btnCheckAllItems);
            this.Controls.Add(this.btnShowSelectedItems);
            this.Controls.Add(this.btnAddItems);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "FrmCheckedListBox";
            this.Text = "FrmCheckedListBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnAddItems;
        private System.Windows.Forms.Button btnShowSelectedItems;
        private System.Windows.Forms.Button btnCheckAllItems;
        private System.Windows.Forms.Button btnUnCheckAllItems;
        private System.Windows.Forms.Button btnRemoveFirstItem;
    }
}