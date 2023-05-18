namespace MyFirstWinformsProject
{
    partial class FrmListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListView));
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnFillRandom = new System.Windows.Forms.Button();
            this.grpView = new System.Windows.Forms.GroupBox();
            this.rbLargIcon = new System.Windows.Forms.RadioButton();
            this.rbSmallIcon = new System.Windows.Forms.RadioButton();
            this.rbList = new System.Windows.Forms.RadioButton();
            this.rbTile = new System.Windows.Forms.RadioButton();
            this.rbDetails = new System.Windows.Forms.RadioButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.imgLstSmallIcon = new System.Windows.Forms.ImageList(this.components);
            this.imgLstLargIcon = new System.Windows.Forms.ImageList(this.components);
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpView.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(81, 34);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(120, 20);
            this.txtId.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(81, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(120, 20);
            this.txtName.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(245, 34);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 47);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(340, 34);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(89, 47);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnFillRandom
            // 
            this.btnFillRandom.Location = new System.Drawing.Point(435, 33);
            this.btnFillRandom.Name = "btnFillRandom";
            this.btnFillRandom.Size = new System.Drawing.Size(89, 47);
            this.btnFillRandom.TabIndex = 4;
            this.btnFillRandom.Text = "Fill Random";
            this.btnFillRandom.UseVisualStyleBackColor = true;
            this.btnFillRandom.Click += new System.EventHandler(this.btnFillRandom_Click);
            // 
            // grpView
            // 
            this.grpView.Controls.Add(this.rbLargIcon);
            this.grpView.Controls.Add(this.rbSmallIcon);
            this.grpView.Controls.Add(this.rbList);
            this.grpView.Controls.Add(this.rbTile);
            this.grpView.Controls.Add(this.rbDetails);
            this.grpView.Location = new System.Drawing.Point(595, 34);
            this.grpView.Name = "grpView";
            this.grpView.Size = new System.Drawing.Size(149, 107);
            this.grpView.TabIndex = 5;
            this.grpView.TabStop = false;
            this.grpView.Text = "View";
            // 
            // rbLargIcon
            // 
            this.rbLargIcon.AutoSize = true;
            this.rbLargIcon.Location = new System.Drawing.Point(6, 73);
            this.rbLargIcon.Name = "rbLargIcon";
            this.rbLargIcon.Size = new System.Drawing.Size(70, 17);
            this.rbLargIcon.TabIndex = 7;
            this.rbLargIcon.TabStop = true;
            this.rbLargIcon.Text = "Larg Icon";
            this.rbLargIcon.UseVisualStyleBackColor = true;
            this.rbLargIcon.CheckedChanged += new System.EventHandler(this.rbLargIcon_CheckedChanged);
            // 
            // rbSmallIcon
            // 
            this.rbSmallIcon.AutoSize = true;
            this.rbSmallIcon.Location = new System.Drawing.Point(6, 50);
            this.rbSmallIcon.Name = "rbSmallIcon";
            this.rbSmallIcon.Size = new System.Drawing.Size(73, 17);
            this.rbSmallIcon.TabIndex = 6;
            this.rbSmallIcon.TabStop = true;
            this.rbSmallIcon.Text = "Small Icon";
            this.rbSmallIcon.UseVisualStyleBackColor = true;
            this.rbSmallIcon.CheckedChanged += new System.EventHandler(this.rbSmallIcon_CheckedChanged);
            // 
            // rbList
            // 
            this.rbList.AutoSize = true;
            this.rbList.Location = new System.Drawing.Point(96, 50);
            this.rbList.Name = "rbList";
            this.rbList.Size = new System.Drawing.Size(41, 17);
            this.rbList.TabIndex = 9;
            this.rbList.TabStop = true;
            this.rbList.Text = "List";
            this.rbList.UseVisualStyleBackColor = true;
            this.rbList.CheckedChanged += new System.EventHandler(this.rbList_CheckedChanged);
            // 
            // rbTile
            // 
            this.rbTile.AutoSize = true;
            this.rbTile.Location = new System.Drawing.Point(96, 27);
            this.rbTile.Name = "rbTile";
            this.rbTile.Size = new System.Drawing.Size(41, 17);
            this.rbTile.TabIndex = 8;
            this.rbTile.TabStop = true;
            this.rbTile.Text = "Tile";
            this.rbTile.UseVisualStyleBackColor = true;
            this.rbTile.CheckedChanged += new System.EventHandler(this.rbTile_CheckedChanged);
            // 
            // rbDetails
            // 
            this.rbDetails.AutoSize = true;
            this.rbDetails.Location = new System.Drawing.Point(6, 27);
            this.rbDetails.Name = "rbDetails";
            this.rbDetails.Size = new System.Drawing.Size(57, 17);
            this.rbDetails.TabIndex = 5;
            this.rbDetails.TabStop = true;
            this.rbDetails.Text = "Details";
            this.rbDetails.UseVisualStyleBackColor = true;
            this.rbDetails.CheckedChanged += new System.EventHandler(this.rbDetails_CheckedChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imgLstLargIcon;
            this.listView1.Location = new System.Drawing.Point(33, 195);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(711, 243);
            this.listView1.SmallImageList = this.imgLstSmallIcon;
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(81, 107);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(47, 17);
            this.rbMale.TabIndex = 6;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(142, 107);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 6;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // imgLstSmallIcon
            // 
            this.imgLstSmallIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLstSmallIcon.ImageStream")));
            this.imgLstSmallIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLstSmallIcon.Images.SetKeyName(0, "Boy.png");
            this.imgLstSmallIcon.Images.SetKeyName(1, "Girl.png");
            // 
            // imgLstLargIcon
            // 
            this.imgLstLargIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLstLargIcon.ImageStream")));
            this.imgLstLargIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLstLargIcon.Images.SetKeyName(0, "Boy.png");
            this.imgLstLargIcon.Images.SetKeyName(1, "Girl.png");
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            // 
            // FrmListView
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.grpView);
            this.Controls.Add(this.btnFillRandom);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Name = "FrmListView";
            this.Text = "FrmListView";
            this.grpView.ResumeLayout(false);
            this.grpView.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnFillRandom;
        private System.Windows.Forms.GroupBox grpView;
        private System.Windows.Forms.RadioButton rbLargIcon;
        private System.Windows.Forms.RadioButton rbSmallIcon;
        private System.Windows.Forms.RadioButton rbList;
        private System.Windows.Forms.RadioButton rbTile;
        private System.Windows.Forms.RadioButton rbDetails;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.ImageList imgLstSmallIcon;
        private System.Windows.Forms.ImageList imgLstLargIcon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}