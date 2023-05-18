namespace MyFirstWinformsProject
{
    partial class FrmTreeView
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Ebrahim");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Kareem");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Saleem");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Nasseem");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Adham", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Ola", 1, 1);
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Sawsan", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode6});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTreeView));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(122, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node3";
            treeNode1.Text = "Ebrahim";
            treeNode2.Name = "Node4";
            treeNode2.Text = "Kareem";
            treeNode3.Name = "Node5";
            treeNode3.Text = "Saleem";
            treeNode4.Name = "Node6";
            treeNode4.Text = "Nasseem";
            treeNode5.Name = "Node0";
            treeNode5.Text = "Adham";
            treeNode6.ImageIndex = 1;
            treeNode6.Name = "Node2";
            treeNode6.SelectedImageIndex = 1;
            treeNode6.Text = "Ola";
            treeNode7.ImageIndex = 1;
            treeNode7.Name = "Node7";
            treeNode7.SelectedImageIndex = 1;
            treeNode7.Text = "Sawsan";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode7});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(444, 358);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            this.treeView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Boy.png");
            this.imageList1.Images.SetKeyName(1, "Girl.png");
            // 
            // FrmTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView1);
            this.Name = "FrmTreeView";
            this.Text = "FrmTreeView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
    }
}