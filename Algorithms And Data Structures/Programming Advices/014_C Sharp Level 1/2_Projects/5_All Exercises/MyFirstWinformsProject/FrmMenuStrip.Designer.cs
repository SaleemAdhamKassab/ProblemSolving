namespace MyFirstWinformsProject
{
    partial class FrmMenuStrip
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addClientToolStripMenuItem,
            this.findClientToolStripMenuItem,
            this.deleteClientToolStripMenuItem,
            this.updateClientToolStripMenuItem});
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.clientsToolStripMenuItem.Text = "Clients";
            // 
            // addClientToolStripMenuItem
            // 
            this.addClientToolStripMenuItem.Name = "addClientToolStripMenuItem";
            this.addClientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addClientToolStripMenuItem.Text = "Add Client";
            this.addClientToolStripMenuItem.Click += new System.EventHandler(this.addClientToolStripMenuItem_Click);
            // 
            // findClientToolStripMenuItem
            // 
            this.findClientToolStripMenuItem.Name = "findClientToolStripMenuItem";
            this.findClientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.findClientToolStripMenuItem.Text = "Find Client";
            this.findClientToolStripMenuItem.Click += new System.EventHandler(this.findClientToolStripMenuItem_Click);
            // 
            // deleteClientToolStripMenuItem
            // 
            this.deleteClientToolStripMenuItem.Name = "deleteClientToolStripMenuItem";
            this.deleteClientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteClientToolStripMenuItem.Text = "Delete Client";
            // 
            // updateClientToolStripMenuItem
            // 
            this.updateClientToolStripMenuItem.Name = "updateClientToolStripMenuItem";
            this.updateClientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateClientToolStripMenuItem.Text = "Update Client";
            // 
            // FrmMenuStrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenuStrip";
            this.Text = "FrmMenuStrip";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateClientToolStripMenuItem;
    }
}