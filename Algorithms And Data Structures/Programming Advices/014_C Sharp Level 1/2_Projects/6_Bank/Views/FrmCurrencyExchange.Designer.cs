namespace Bank.Views
{
    partial class FrmCurrencyExchange
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
            this.tabControlCurrencyExchange = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grbSort = new System.Windows.Forms.GroupBox();
            this.rbShowCurrenciesAsc = new System.Windows.Forms.RadioButton();
            this.rbShowCurrenciesDesc = new System.Windows.Forms.RadioButton();
            this.lblShowCurrenciesCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblClientsCount = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtShowCurrenciesSearch = new System.Windows.Forms.TextBox();
            this.lstViewShowCurrencies = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnUpdateRate = new System.Windows.Forms.Button();
            this.numUpdateRate = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.cbUpdateRateCurrencyCode = new System.Windows.Forms.ComboBox();
            this.lblCurrenyInfo = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnCurrencyCalcConvert = new System.Windows.Forms.Button();
            this.numCurrencyCalcAmountToExchange = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCurrenyCalculaterCurrencyCodeToInfo = new System.Windows.Forms.Label();
            this.lblCurrenyCalculaterCurrencyCodeFromInfo = new System.Windows.Forms.Label();
            this.cbCurrencyCalculaterCurrencyCodeTo = new System.Windows.Forms.ComboBox();
            this.cbCurrencyCalculaterCurrencyCodeFrom = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAmountExchange = new System.Windows.Forms.Label();
            this.tabControlCurrencyExchange.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grbSort.SuspendLayout();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdateRate)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrencyCalcAmountToExchange)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlCurrencyExchange
            // 
            this.tabControlCurrencyExchange.Controls.Add(this.tabPage1);
            this.tabControlCurrencyExchange.Controls.Add(this.tabPage2);
            this.tabControlCurrencyExchange.Controls.Add(this.tabPage3);
            this.tabControlCurrencyExchange.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControlCurrencyExchange.Location = new System.Drawing.Point(215, 0);
            this.tabControlCurrencyExchange.Name = "tabControlCurrencyExchange";
            this.tabControlCurrencyExchange.SelectedIndex = 0;
            this.tabControlCurrencyExchange.Size = new System.Drawing.Size(805, 556);
            this.tabControlCurrencyExchange.TabIndex = 0;
            this.tabControlCurrencyExchange.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grbSort);
            this.tabPage1.Controls.Add(this.lblShowCurrenciesCount);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lblClientsCount);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.panel14);
            this.tabPage1.Controls.Add(this.lstViewShowCurrencies);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(797, 530);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Show Currencies";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grbSort
            // 
            this.grbSort.Controls.Add(this.rbShowCurrenciesAsc);
            this.grbSort.Controls.Add(this.rbShowCurrenciesDesc);
            this.grbSort.Location = new System.Drawing.Point(611, 146);
            this.grbSort.Name = "grbSort";
            this.grbSort.Size = new System.Drawing.Size(135, 52);
            this.grbSort.TabIndex = 18;
            this.grbSort.TabStop = false;
            this.grbSort.Text = "Sorting";
            // 
            // rbShowCurrenciesAsc
            // 
            this.rbShowCurrenciesAsc.AutoSize = true;
            this.rbShowCurrenciesAsc.Location = new System.Drawing.Point(16, 19);
            this.rbShowCurrenciesAsc.Name = "rbShowCurrenciesAsc";
            this.rbShowCurrenciesAsc.Size = new System.Drawing.Size(42, 17);
            this.rbShowCurrenciesAsc.TabIndex = 9;
            this.rbShowCurrenciesAsc.TabStop = true;
            this.rbShowCurrenciesAsc.Text = "Asc";
            this.rbShowCurrenciesAsc.UseVisualStyleBackColor = true;
            this.rbShowCurrenciesAsc.CheckedChanged += new System.EventHandler(this.rbShowCurrenciesAsc_CheckedChanged);
            // 
            // rbShowCurrenciesDesc
            // 
            this.rbShowCurrenciesDesc.AutoSize = true;
            this.rbShowCurrenciesDesc.Location = new System.Drawing.Point(64, 19);
            this.rbShowCurrenciesDesc.Name = "rbShowCurrenciesDesc";
            this.rbShowCurrenciesDesc.Size = new System.Drawing.Size(48, 17);
            this.rbShowCurrenciesDesc.TabIndex = 9;
            this.rbShowCurrenciesDesc.TabStop = true;
            this.rbShowCurrenciesDesc.Text = "Desc";
            this.rbShowCurrenciesDesc.UseVisualStyleBackColor = true;
            this.rbShowCurrenciesDesc.CheckedChanged += new System.EventHandler(this.rbShowCurrenciesDesc_CheckedChanged);
            // 
            // lblShowCurrenciesCount
            // 
            this.lblShowCurrenciesCount.AutoSize = true;
            this.lblShowCurrenciesCount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowCurrenciesCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblShowCurrenciesCount.Location = new System.Drawing.Point(20, 152);
            this.lblShowCurrenciesCount.Name = "lblShowCurrenciesCount";
            this.lblShowCurrenciesCount.Size = new System.Drawing.Size(0, 19);
            this.lblShowCurrenciesCount.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label2.Location = new System.Drawing.Point(367, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(359, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 15;
            // 
            // lblClientsCount
            // 
            this.lblClientsCount.AutoSize = true;
            this.lblClientsCount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblClientsCount.Location = new System.Drawing.Point(351, 237);
            this.lblClientsCount.Name = "lblClientsCount";
            this.lblClientsCount.Size = new System.Drawing.Size(0, 19);
            this.lblClientsCount.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label14.Location = new System.Drawing.Point(20, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(138, 38);
            this.label14.TabIndex = 13;
            this.label14.Text = "Search Currency\r\nCode/Country";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel14.Controls.Add(this.pictureBox2);
            this.panel14.Controls.Add(this.txtShowCurrenciesSearch);
            this.panel14.ForeColor = System.Drawing.Color.White;
            this.panel14.Location = new System.Drawing.Point(24, 94);
            this.panel14.Name = "panel14";
            this.panel14.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panel14.Size = new System.Drawing.Size(198, 21);
            this.panel14.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::Bank.Properties.Resources.search2;
            this.pictureBox2.Location = new System.Drawing.Point(170, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 15);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // txtShowCurrenciesSearch
            // 
            this.txtShowCurrenciesSearch.BackColor = System.Drawing.Color.White;
            this.txtShowCurrenciesSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtShowCurrenciesSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtShowCurrenciesSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowCurrenciesSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txtShowCurrenciesSearch.Location = new System.Drawing.Point(0, 0);
            this.txtShowCurrenciesSearch.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.txtShowCurrenciesSearch.Name = "txtShowCurrenciesSearch";
            this.txtShowCurrenciesSearch.Size = new System.Drawing.Size(198, 20);
            this.txtShowCurrenciesSearch.TabIndex = 0;
            this.txtShowCurrenciesSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtShowCurrenciesSearch_KeyUp);
            // 
            // lstViewShowCurrencies
            // 
            this.lstViewShowCurrencies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader8,
            this.columnHeader10,
            this.columnHeader11});
            this.lstViewShowCurrencies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstViewShowCurrencies.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstViewShowCurrencies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lstViewShowCurrencies.FullRowSelect = true;
            this.lstViewShowCurrencies.GridLines = true;
            this.lstViewShowCurrencies.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstViewShowCurrencies.HideSelection = false;
            this.lstViewShowCurrencies.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstViewShowCurrencies.Location = new System.Drawing.Point(24, 204);
            this.lstViewShowCurrencies.MultiSelect = false;
            this.lstViewShowCurrencies.Name = "lstViewShowCurrencies";
            this.lstViewShowCurrencies.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstViewShowCurrencies.Size = new System.Drawing.Size(722, 247);
            this.lstViewShowCurrencies.TabIndex = 6;
            this.lstViewShowCurrencies.UseCompatibleStateImageBehavior = false;
            this.lstViewShowCurrencies.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Code";
            this.columnHeader9.Width = 118;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Country";
            this.columnHeader8.Width = 258;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Name";
            this.columnHeader10.Width = 197;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Rate/(1$)";
            this.columnHeader11.Width = 144;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnUpdateRate);
            this.tabPage2.Controls.Add(this.numUpdateRate);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.cbUpdateRateCurrencyCode);
            this.tabPage2.Controls.Add(this.lblCurrenyInfo);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(797, 530);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Update Rate";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnUpdateRate
            // 
            this.btnUpdateRate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdateRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateRate.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnUpdateRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnUpdateRate.Location = new System.Drawing.Point(68, 347);
            this.btnUpdateRate.Name = "btnUpdateRate";
            this.btnUpdateRate.Size = new System.Drawing.Size(198, 49);
            this.btnUpdateRate.TabIndex = 38;
            this.btnUpdateRate.Text = "Update Rate";
            this.btnUpdateRate.UseVisualStyleBackColor = false;
            this.btnUpdateRate.Click += new System.EventHandler(this.btnUpdateRate_Click);
            // 
            // numUpdateRate
            // 
            this.numUpdateRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.numUpdateRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUpdateRate.DecimalPlaces = 5;
            this.numUpdateRate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpdateRate.Location = new System.Drawing.Point(68, 261);
            this.numUpdateRate.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numUpdateRate.Name = "numUpdateRate";
            this.numUpdateRate.Size = new System.Drawing.Size(198, 27);
            this.numUpdateRate.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label7.Location = new System.Drawing.Point(64, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 19);
            this.label7.TabIndex = 36;
            this.label7.Text = "New Rate ($)";
            // 
            // cbUpdateRateCurrencyCode
            // 
            this.cbUpdateRateCurrencyCode.AutoCompleteCustomSource.AddRange(new string[] {
            "dasd",
            "dad"});
            this.cbUpdateRateCurrencyCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbUpdateRateCurrencyCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbUpdateRateCurrencyCode.BackColor = System.Drawing.Color.White;
            this.cbUpdateRateCurrencyCode.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUpdateRateCurrencyCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.cbUpdateRateCurrencyCode.FormattingEnabled = true;
            this.cbUpdateRateCurrencyCode.Location = new System.Drawing.Point(68, 79);
            this.cbUpdateRateCurrencyCode.Name = "cbUpdateRateCurrencyCode";
            this.cbUpdateRateCurrencyCode.Size = new System.Drawing.Size(198, 24);
            this.cbUpdateRateCurrencyCode.TabIndex = 27;
            this.cbUpdateRateCurrencyCode.SelectedIndexChanged += new System.EventHandler(this.cbUpdateRateCurrencyCode_SelectedIndexChanged);
            // 
            // lblCurrenyInfo
            // 
            this.lblCurrenyInfo.AutoSize = true;
            this.lblCurrenyInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrenyInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblCurrenyInfo.Location = new System.Drawing.Point(64, 128);
            this.lblCurrenyInfo.Name = "lblCurrenyInfo";
            this.lblCurrenyInfo.Size = new System.Drawing.Size(0, 19);
            this.lblCurrenyInfo.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label13.Location = new System.Drawing.Point(64, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 19);
            this.label13.TabIndex = 26;
            this.label13.Text = "Currency Code";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnCurrencyCalcConvert);
            this.tabPage3.Controls.Add(this.numCurrencyCalcAmountToExchange);
            this.tabPage3.Controls.Add(this.lblAmountExchange);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.lblCurrenyCalculaterCurrencyCodeToInfo);
            this.tabPage3.Controls.Add(this.lblCurrenyCalculaterCurrencyCodeFromInfo);
            this.tabPage3.Controls.Add(this.cbCurrencyCalculaterCurrencyCodeTo);
            this.tabPage3.Controls.Add(this.cbCurrencyCalculaterCurrencyCodeFrom);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(797, 530);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Currency Calculator";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnCurrencyCalcConvert
            // 
            this.btnCurrencyCalcConvert.BackColor = System.Drawing.SystemColors.Control;
            this.btnCurrencyCalcConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrencyCalcConvert.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnCurrencyCalcConvert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnCurrencyCalcConvert.Location = new System.Drawing.Point(68, 339);
            this.btnCurrencyCalcConvert.Name = "btnCurrencyCalcConvert";
            this.btnCurrencyCalcConvert.Size = new System.Drawing.Size(198, 49);
            this.btnCurrencyCalcConvert.TabIndex = 40;
            this.btnCurrencyCalcConvert.Text = "Convert";
            this.btnCurrencyCalcConvert.UseVisualStyleBackColor = false;
            this.btnCurrencyCalcConvert.Click += new System.EventHandler(this.btnCurrencyCalcConvert_Click);
            // 
            // numCurrencyCalcAmountToExchange
            // 
            this.numCurrencyCalcAmountToExchange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.numCurrencyCalcAmountToExchange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numCurrencyCalcAmountToExchange.DecimalPlaces = 5;
            this.numCurrencyCalcAmountToExchange.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCurrencyCalcAmountToExchange.Location = new System.Drawing.Point(68, 260);
            this.numCurrencyCalcAmountToExchange.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numCurrencyCalcAmountToExchange.Name = "numCurrencyCalcAmountToExchange";
            this.numCurrencyCalcAmountToExchange.Size = new System.Drawing.Size(198, 27);
            this.numCurrencyCalcAmountToExchange.TabIndex = 39;
            this.numCurrencyCalcAmountToExchange.ValueChanged += new System.EventHandler(this.numCurrencyCalcAmountToExchange_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label4.Location = new System.Drawing.Point(64, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 19);
            this.label4.TabIndex = 38;
            this.label4.Text = "Amount to Exchange";
            // 
            // lblCurrenyCalculaterCurrencyCodeToInfo
            // 
            this.lblCurrenyCalculaterCurrencyCodeToInfo.AutoSize = true;
            this.lblCurrenyCalculaterCurrencyCodeToInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrenyCalculaterCurrencyCodeToInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblCurrenyCalculaterCurrencyCodeToInfo.Location = new System.Drawing.Point(370, 128);
            this.lblCurrenyCalculaterCurrencyCodeToInfo.Name = "lblCurrenyCalculaterCurrencyCodeToInfo";
            this.lblCurrenyCalculaterCurrencyCodeToInfo.Size = new System.Drawing.Size(0, 19);
            this.lblCurrenyCalculaterCurrencyCodeToInfo.TabIndex = 30;
            // 
            // lblCurrenyCalculaterCurrencyCodeFromInfo
            // 
            this.lblCurrenyCalculaterCurrencyCodeFromInfo.AutoSize = true;
            this.lblCurrenyCalculaterCurrencyCodeFromInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrenyCalculaterCurrencyCodeFromInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblCurrenyCalculaterCurrencyCodeFromInfo.Location = new System.Drawing.Point(64, 128);
            this.lblCurrenyCalculaterCurrencyCodeFromInfo.Name = "lblCurrenyCalculaterCurrencyCodeFromInfo";
            this.lblCurrenyCalculaterCurrencyCodeFromInfo.Size = new System.Drawing.Size(0, 19);
            this.lblCurrenyCalculaterCurrencyCodeFromInfo.TabIndex = 30;
            // 
            // cbCurrencyCalculaterCurrencyCodeTo
            // 
            this.cbCurrencyCalculaterCurrencyCodeTo.AutoCompleteCustomSource.AddRange(new string[] {
            "dasd",
            "dad"});
            this.cbCurrencyCalculaterCurrencyCodeTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbCurrencyCalculaterCurrencyCodeTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCurrencyCalculaterCurrencyCodeTo.BackColor = System.Drawing.Color.White;
            this.cbCurrencyCalculaterCurrencyCodeTo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCurrencyCalculaterCurrencyCodeTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.cbCurrencyCalculaterCurrencyCodeTo.FormattingEnabled = true;
            this.cbCurrencyCalculaterCurrencyCodeTo.Location = new System.Drawing.Point(374, 78);
            this.cbCurrencyCalculaterCurrencyCodeTo.Name = "cbCurrencyCalculaterCurrencyCodeTo";
            this.cbCurrencyCalculaterCurrencyCodeTo.Size = new System.Drawing.Size(198, 24);
            this.cbCurrencyCalculaterCurrencyCodeTo.TabIndex = 29;
            this.cbCurrencyCalculaterCurrencyCodeTo.SelectedIndexChanged += new System.EventHandler(this.cbCurrencyCalculaterCurrencyCodeTo_SelectedIndexChanged);
            // 
            // cbCurrencyCalculaterCurrencyCodeFrom
            // 
            this.cbCurrencyCalculaterCurrencyCodeFrom.AutoCompleteCustomSource.AddRange(new string[] {
            "dasd",
            "dad"});
            this.cbCurrencyCalculaterCurrencyCodeFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbCurrencyCalculaterCurrencyCodeFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCurrencyCalculaterCurrencyCodeFrom.BackColor = System.Drawing.Color.White;
            this.cbCurrencyCalculaterCurrencyCodeFrom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCurrencyCalculaterCurrencyCodeFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.cbCurrencyCalculaterCurrencyCodeFrom.FormattingEnabled = true;
            this.cbCurrencyCalculaterCurrencyCodeFrom.Location = new System.Drawing.Point(68, 78);
            this.cbCurrencyCalculaterCurrencyCodeFrom.Name = "cbCurrencyCalculaterCurrencyCodeFrom";
            this.cbCurrencyCalculaterCurrencyCodeFrom.Size = new System.Drawing.Size(198, 24);
            this.cbCurrencyCalculaterCurrencyCodeFrom.TabIndex = 29;
            this.cbCurrencyCalculaterCurrencyCodeFrom.SelectedIndexChanged += new System.EventHandler(this.cbCurrencyCalculaterCurrencyCodeFrom_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label5.Location = new System.Drawing.Point(370, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 28;
            this.label5.Text = "Convert To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label3.Location = new System.Drawing.Point(64, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "Convert From";
            // 
            // lblAmountExchange
            // 
            this.lblAmountExchange.AutoSize = true;
            this.lblAmountExchange.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountExchange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblAmountExchange.Location = new System.Drawing.Point(64, 430);
            this.lblAmountExchange.Name = "lblAmountExchange";
            this.lblAmountExchange.Size = new System.Drawing.Size(0, 28);
            this.lblAmountExchange.TabIndex = 38;
            // 
            // FrmCurrencyExchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 556);
            this.Controls.Add(this.tabControlCurrencyExchange);
            this.Name = "FrmCurrencyExchange";
            this.Text = "Currency Exchange";
            this.tabControlCurrencyExchange.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.grbSort.ResumeLayout(false);
            this.grbSort.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdateRate)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrencyCalcAmountToExchange)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlCurrencyExchange;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView lstViewShowCurrencies;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtShowCurrenciesSearch;
        private System.Windows.Forms.Label lblShowCurrenciesCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClientsCount;
        private System.Windows.Forms.GroupBox grbSort;
        private System.Windows.Forms.RadioButton rbShowCurrenciesAsc;
        private System.Windows.Forms.RadioButton rbShowCurrenciesDesc;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cbUpdateRateCurrencyCode;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numUpdateRate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCurrenyInfo;
        private System.Windows.Forms.Button btnUpdateRate;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox cbCurrencyCalculaterCurrencyCodeFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numCurrencyCalcAmountToExchange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCurrenyCalculaterCurrencyCodeToInfo;
        private System.Windows.Forms.Label lblCurrenyCalculaterCurrencyCodeFromInfo;
        private System.Windows.Forms.ComboBox cbCurrencyCalculaterCurrencyCodeTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCurrencyCalcConvert;
        private System.Windows.Forms.Label lblAmountExchange;
    }
}