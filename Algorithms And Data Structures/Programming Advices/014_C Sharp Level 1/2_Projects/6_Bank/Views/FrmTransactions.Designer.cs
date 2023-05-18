namespace Bank.Views
{
    partial class FrmTransactions
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
            this.tabControlTransactions = new System.Windows.Forms.TabControl();
            this.tabPageDeposite = new System.Windows.Forms.TabPage();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.numDepositeAmount = new System.Windows.Forms.NumericUpDown();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblDepositeCurrentBalance = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbDepositeAccNum = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPageWithdraw = new System.Windows.Forms.TabPage();
            this.lblWithdrawCurrentBalance = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.numWithdrawAmount = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbWithdrawAccNum = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPageTotalBalances = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalBalancesNumber = new System.Windows.Forms.Label();
            this.lblTotalBalancesWord = new System.Windows.Forms.Label();
            this.lblTotalBalancesClientsCount = new System.Windows.Forms.Label();
            this.grbSort = new System.Windows.Forms.GroupBox();
            this.rbTotalBalancesAsc = new System.Windows.Forms.RadioButton();
            this.rbTotalBalancesDesc = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtTotalBalancesSearch = new System.Windows.Forms.TextBox();
            this.lstViewTotalBalances = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageTransfer = new System.Windows.Forms.TabPage();
            this.lblTransferCurrentBalanceTo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTransferCurrentBalanceFrom = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblNewToAccBalance = new System.Windows.Forms.Label();
            this.lblNewFromAccBalance = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.numTransferAmount = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTransferAccNumTo = new System.Windows.Forms.ComboBox();
            this.cbTransferAccNumFrom = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageTransferLog = new System.Windows.Forms.TabPage();
            this.lblTransferLogCount = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTransferLogAsc = new System.Windows.Forms.RadioButton();
            this.rbTransferLogDesc = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTransferSearch = new System.Windows.Forms.TextBox();
            this.lstViewTransferLog = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errProvTransactions = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControlTransactions.SuspendLayout();
            this.tabPageDeposite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDepositeAmount)).BeginInit();
            this.tabPageWithdraw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWithdrawAmount)).BeginInit();
            this.tabPageTotalBalances.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grbSort.SuspendLayout();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPageTransfer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTransferAmount)).BeginInit();
            this.tabPageTransferLog.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlTransactions
            // 
            this.tabControlTransactions.Controls.Add(this.tabPageDeposite);
            this.tabControlTransactions.Controls.Add(this.tabPageWithdraw);
            this.tabControlTransactions.Controls.Add(this.tabPageTotalBalances);
            this.tabControlTransactions.Controls.Add(this.tabPageTransfer);
            this.tabControlTransactions.Controls.Add(this.tabPageTransferLog);
            this.tabControlTransactions.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControlTransactions.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControlTransactions.Location = new System.Drawing.Point(207, 0);
            this.tabControlTransactions.Name = "tabControlTransactions";
            this.tabControlTransactions.SelectedIndex = 0;
            this.tabControlTransactions.Size = new System.Drawing.Size(797, 556);
            this.tabControlTransactions.TabIndex = 0;
            this.tabControlTransactions.SelectedIndexChanged += new System.EventHandler(this.tabControlTransactions_SelectedIndexChanged);
            // 
            // tabPageDeposite
            // 
            this.tabPageDeposite.Controls.Add(this.btnDeposit);
            this.tabPageDeposite.Controls.Add(this.numDepositeAmount);
            this.tabPageDeposite.Controls.Add(this.panel7);
            this.tabPageDeposite.Controls.Add(this.lblDepositeCurrentBalance);
            this.tabPageDeposite.Controls.Add(this.label8);
            this.tabPageDeposite.Controls.Add(this.cbDepositeAccNum);
            this.tabPageDeposite.Controls.Add(this.label7);
            this.tabPageDeposite.Controls.Add(this.label13);
            this.tabPageDeposite.Location = new System.Drawing.Point(4, 22);
            this.tabPageDeposite.Name = "tabPageDeposite";
            this.tabPageDeposite.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDeposite.Size = new System.Drawing.Size(789, 530);
            this.tabPageDeposite.TabIndex = 0;
            this.tabPageDeposite.Text = "Deposit";
            this.tabPageDeposite.UseVisualStyleBackColor = true;
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeposit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnDeposit.Location = new System.Drawing.Point(66, 314);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(198, 49);
            this.btnDeposit.TabIndex = 38;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // numDepositeAmount
            // 
            this.numDepositeAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.numDepositeAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numDepositeAmount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDepositeAmount.Location = new System.Drawing.Point(66, 229);
            this.numDepositeAmount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numDepositeAmount.Name = "numDepositeAmount";
            this.numDepositeAmount.Size = new System.Drawing.Size(198, 27);
            this.numDepositeAmount.TabIndex = 37;
            this.numDepositeAmount.Validating += new System.ComponentModel.CancelEventHandler(this.numDepositeAmount_Validating);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel7.ForeColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(66, 260);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panel7.Size = new System.Drawing.Size(198, 1);
            this.panel7.TabIndex = 34;
            // 
            // lblDepositeCurrentBalance
            // 
            this.lblDepositeCurrentBalance.AutoSize = true;
            this.lblDepositeCurrentBalance.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepositeCurrentBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblDepositeCurrentBalance.Location = new System.Drawing.Point(220, 133);
            this.lblDepositeCurrentBalance.Name = "lblDepositeCurrentBalance";
            this.lblDepositeCurrentBalance.Size = new System.Drawing.Size(0, 23);
            this.lblDepositeCurrentBalance.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label8.Location = new System.Drawing.Point(62, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 19);
            this.label8.TabIndex = 35;
            this.label8.Text = "Deposit Amount";
            // 
            // cbDepositeAccNum
            // 
            this.cbDepositeAccNum.BackColor = System.Drawing.Color.White;
            this.cbDepositeAccNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepositeAccNum.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepositeAccNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.cbDepositeAccNum.FormattingEnabled = true;
            this.cbDepositeAccNum.Location = new System.Drawing.Point(66, 87);
            this.cbDepositeAccNum.Name = "cbDepositeAccNum";
            this.cbDepositeAccNum.Size = new System.Drawing.Size(198, 24);
            this.cbDepositeAccNum.TabIndex = 27;
            this.cbDepositeAccNum.SelectedIndexChanged += new System.EventHandler(this.cbDepositeAccNum_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label7.Location = new System.Drawing.Point(62, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 19);
            this.label7.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label13.Location = new System.Drawing.Point(62, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 19);
            this.label13.TabIndex = 26;
            this.label13.Text = "Acc. Number";
            // 
            // tabPageWithdraw
            // 
            this.tabPageWithdraw.Controls.Add(this.lblWithdrawCurrentBalance);
            this.tabPageWithdraw.Controls.Add(this.label11);
            this.tabPageWithdraw.Controls.Add(this.btnWithdraw);
            this.tabPageWithdraw.Controls.Add(this.numWithdrawAmount);
            this.tabPageWithdraw.Controls.Add(this.panel1);
            this.tabPageWithdraw.Controls.Add(this.label1);
            this.tabPageWithdraw.Controls.Add(this.label2);
            this.tabPageWithdraw.Controls.Add(this.cbWithdrawAccNum);
            this.tabPageWithdraw.Controls.Add(this.label3);
            this.tabPageWithdraw.Location = new System.Drawing.Point(4, 22);
            this.tabPageWithdraw.Name = "tabPageWithdraw";
            this.tabPageWithdraw.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWithdraw.Size = new System.Drawing.Size(789, 530);
            this.tabPageWithdraw.TabIndex = 1;
            this.tabPageWithdraw.Text = "Withdraw";
            this.tabPageWithdraw.UseVisualStyleBackColor = true;
            // 
            // lblWithdrawCurrentBalance
            // 
            this.lblWithdrawCurrentBalance.AutoSize = true;
            this.lblWithdrawCurrentBalance.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWithdrawCurrentBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblWithdrawCurrentBalance.Location = new System.Drawing.Point(220, 133);
            this.lblWithdrawCurrentBalance.Name = "lblWithdrawCurrentBalance";
            this.lblWithdrawCurrentBalance.Size = new System.Drawing.Size(0, 23);
            this.lblWithdrawCurrentBalance.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label11.Location = new System.Drawing.Point(62, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 19);
            this.label11.TabIndex = 46;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.SystemColors.Control;
            this.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdraw.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnWithdraw.Location = new System.Drawing.Point(66, 314);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(198, 49);
            this.btnWithdraw.TabIndex = 45;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // numWithdrawAmount
            // 
            this.numWithdrawAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.numWithdrawAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numWithdrawAmount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numWithdrawAmount.Location = new System.Drawing.Point(66, 229);
            this.numWithdrawAmount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numWithdrawAmount.Name = "numWithdrawAmount";
            this.numWithdrawAmount.Size = new System.Drawing.Size(198, 27);
            this.numWithdrawAmount.TabIndex = 44;
            this.numWithdrawAmount.Validating += new System.ComponentModel.CancelEventHandler(this.numWithdrawAmount_Validating);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(66, 260);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panel1.Size = new System.Drawing.Size(198, 1);
            this.panel1.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(44, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label2.Location = new System.Drawing.Point(62, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 19);
            this.label2.TabIndex = 43;
            this.label2.Text = "Withdraw Amount";
            // 
            // cbWithdrawAccNum
            // 
            this.cbWithdrawAccNum.BackColor = System.Drawing.Color.White;
            this.cbWithdrawAccNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWithdrawAccNum.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWithdrawAccNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.cbWithdrawAccNum.FormattingEnabled = true;
            this.cbWithdrawAccNum.Location = new System.Drawing.Point(66, 87);
            this.cbWithdrawAccNum.Name = "cbWithdrawAccNum";
            this.cbWithdrawAccNum.Size = new System.Drawing.Size(198, 24);
            this.cbWithdrawAccNum.TabIndex = 40;
            this.cbWithdrawAccNum.SelectedIndexChanged += new System.EventHandler(this.comboBoxWithdrawAccountNumber_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label3.Location = new System.Drawing.Point(62, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 39;
            this.label3.Text = "Acc. Number";
            // 
            // tabPageTotalBalances
            // 
            this.tabPageTotalBalances.Controls.Add(this.panel2);
            this.tabPageTotalBalances.Controls.Add(this.lblTotalBalancesClientsCount);
            this.tabPageTotalBalances.Controls.Add(this.grbSort);
            this.tabPageTotalBalances.Controls.Add(this.label14);
            this.tabPageTotalBalances.Controls.Add(this.panel14);
            this.tabPageTotalBalances.Controls.Add(this.lstViewTotalBalances);
            this.tabPageTotalBalances.Location = new System.Drawing.Point(4, 22);
            this.tabPageTotalBalances.Name = "tabPageTotalBalances";
            this.tabPageTotalBalances.Size = new System.Drawing.Size(789, 530);
            this.tabPageTotalBalances.TabIndex = 2;
            this.tabPageTotalBalances.Text = "Total Balances";
            this.tabPageTotalBalances.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.lblTotalBalancesNumber);
            this.panel2.Controls.Add(this.lblTotalBalancesWord);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(789, 95);
            this.panel2.TabIndex = 18;
            // 
            // lblTotalBalancesNumber
            // 
            this.lblTotalBalancesNumber.AutoSize = true;
            this.lblTotalBalancesNumber.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBalancesNumber.ForeColor = System.Drawing.Color.White;
            this.lblTotalBalancesNumber.Location = new System.Drawing.Point(10, 9);
            this.lblTotalBalancesNumber.Name = "lblTotalBalancesNumber";
            this.lblTotalBalancesNumber.Size = new System.Drawing.Size(0, 25);
            this.lblTotalBalancesNumber.TabIndex = 17;
            // 
            // lblTotalBalancesWord
            // 
            this.lblTotalBalancesWord.AutoSize = true;
            this.lblTotalBalancesWord.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBalancesWord.ForeColor = System.Drawing.Color.White;
            this.lblTotalBalancesWord.Location = new System.Drawing.Point(10, 42);
            this.lblTotalBalancesWord.Name = "lblTotalBalancesWord";
            this.lblTotalBalancesWord.Size = new System.Drawing.Size(0, 25);
            this.lblTotalBalancesWord.TabIndex = 17;
            // 
            // lblTotalBalancesClientsCount
            // 
            this.lblTotalBalancesClientsCount.AutoSize = true;
            this.lblTotalBalancesClientsCount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBalancesClientsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblTotalBalancesClientsCount.Location = new System.Drawing.Point(11, 200);
            this.lblTotalBalancesClientsCount.Name = "lblTotalBalancesClientsCount";
            this.lblTotalBalancesClientsCount.Size = new System.Drawing.Size(0, 19);
            this.lblTotalBalancesClientsCount.TabIndex = 17;
            // 
            // grbSort
            // 
            this.grbSort.Controls.Add(this.rbTotalBalancesAsc);
            this.grbSort.Controls.Add(this.rbTotalBalancesDesc);
            this.grbSort.Location = new System.Drawing.Point(457, 200);
            this.grbSort.Name = "grbSort";
            this.grbSort.Size = new System.Drawing.Size(135, 52);
            this.grbSort.TabIndex = 16;
            this.grbSort.TabStop = false;
            this.grbSort.Text = "Sorting";
            // 
            // rbTotalBalancesAsc
            // 
            this.rbTotalBalancesAsc.AutoSize = true;
            this.rbTotalBalancesAsc.Location = new System.Drawing.Point(16, 19);
            this.rbTotalBalancesAsc.Name = "rbTotalBalancesAsc";
            this.rbTotalBalancesAsc.Size = new System.Drawing.Size(42, 17);
            this.rbTotalBalancesAsc.TabIndex = 9;
            this.rbTotalBalancesAsc.TabStop = true;
            this.rbTotalBalancesAsc.Text = "Asc";
            this.rbTotalBalancesAsc.UseVisualStyleBackColor = true;
            this.rbTotalBalancesAsc.CheckedChanged += new System.EventHandler(this.rbAsc_CheckedChanged);
            // 
            // rbTotalBalancesDesc
            // 
            this.rbTotalBalancesDesc.AutoSize = true;
            this.rbTotalBalancesDesc.Location = new System.Drawing.Point(64, 19);
            this.rbTotalBalancesDesc.Name = "rbTotalBalancesDesc";
            this.rbTotalBalancesDesc.Size = new System.Drawing.Size(48, 17);
            this.rbTotalBalancesDesc.TabIndex = 9;
            this.rbTotalBalancesDesc.TabStop = true;
            this.rbTotalBalancesDesc.Text = "Desc";
            this.rbTotalBalancesDesc.UseVisualStyleBackColor = true;
            this.rbTotalBalancesDesc.CheckedChanged += new System.EventHandler(this.rbDesc_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label14.Location = new System.Drawing.Point(11, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(171, 19);
            this.label14.TabIndex = 15;
            this.label14.Text = "Search Acc. Number";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel14.Controls.Add(this.pictureBox2);
            this.panel14.Controls.Add(this.txtTotalBalancesSearch);
            this.panel14.ForeColor = System.Drawing.Color.White;
            this.panel14.Location = new System.Drawing.Point(15, 148);
            this.panel14.Name = "panel14";
            this.panel14.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panel14.Size = new System.Drawing.Size(198, 21);
            this.panel14.TabIndex = 14;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::Bank.Properties.Resources.search2;
            this.pictureBox2.Location = new System.Drawing.Point(157, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // txtTotalBalancesSearch
            // 
            this.txtTotalBalancesSearch.BackColor = System.Drawing.Color.White;
            this.txtTotalBalancesSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalBalancesSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotalBalancesSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalBalancesSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txtTotalBalancesSearch.Location = new System.Drawing.Point(0, 0);
            this.txtTotalBalancesSearch.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.txtTotalBalancesSearch.Name = "txtTotalBalancesSearch";
            this.txtTotalBalancesSearch.Size = new System.Drawing.Size(198, 20);
            this.txtTotalBalancesSearch.TabIndex = 0;
            this.txtTotalBalancesSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTotalBalancesSearch_KeyUp);
            // 
            // lstViewTotalBalances
            // 
            this.lstViewTotalBalances.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader8});
            this.lstViewTotalBalances.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstViewTotalBalances.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstViewTotalBalances.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lstViewTotalBalances.FullRowSelect = true;
            this.lstViewTotalBalances.GridLines = true;
            this.lstViewTotalBalances.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstViewTotalBalances.HideSelection = false;
            this.lstViewTotalBalances.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstViewTotalBalances.Location = new System.Drawing.Point(15, 258);
            this.lstViewTotalBalances.MultiSelect = false;
            this.lstViewTotalBalances.Name = "lstViewTotalBalances";
            this.lstViewTotalBalances.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstViewTotalBalances.Size = new System.Drawing.Size(577, 232);
            this.lstViewTotalBalances.TabIndex = 13;
            this.lstViewTotalBalances.UseCompatibleStateImageBehavior = false;
            this.lstViewTotalBalances.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Acc. Num";
            this.columnHeader1.Width = 198;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "First Name";
            this.columnHeader2.Width = 217;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Balance ($)";
            this.columnHeader8.Width = 411;
            // 
            // tabPageTransfer
            // 
            this.tabPageTransfer.Controls.Add(this.lblTransferCurrentBalanceTo);
            this.tabPageTransfer.Controls.Add(this.label10);
            this.tabPageTransfer.Controls.Add(this.lblTransferCurrentBalanceFrom);
            this.tabPageTransfer.Controls.Add(this.label12);
            this.tabPageTransfer.Controls.Add(this.lblNewToAccBalance);
            this.tabPageTransfer.Controls.Add(this.lblNewFromAccBalance);
            this.tabPageTransfer.Controls.Add(this.btnTransfer);
            this.tabPageTransfer.Controls.Add(this.numTransferAmount);
            this.tabPageTransfer.Controls.Add(this.panel3);
            this.tabPageTransfer.Controls.Add(this.label6);
            this.tabPageTransfer.Controls.Add(this.cbTransferAccNumTo);
            this.tabPageTransfer.Controls.Add(this.cbTransferAccNumFrom);
            this.tabPageTransfer.Controls.Add(this.label5);
            this.tabPageTransfer.Controls.Add(this.label4);
            this.tabPageTransfer.Location = new System.Drawing.Point(4, 22);
            this.tabPageTransfer.Name = "tabPageTransfer";
            this.tabPageTransfer.Size = new System.Drawing.Size(789, 530);
            this.tabPageTransfer.TabIndex = 3;
            this.tabPageTransfer.Text = "Transfer Balances";
            this.tabPageTransfer.UseVisualStyleBackColor = true;
            // 
            // lblTransferCurrentBalanceTo
            // 
            this.lblTransferCurrentBalanceTo.AutoSize = true;
            this.lblTransferCurrentBalanceTo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransferCurrentBalanceTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTransferCurrentBalanceTo.Location = new System.Drawing.Point(602, 94);
            this.lblTransferCurrentBalanceTo.Name = "lblTransferCurrentBalanceTo";
            this.lblTransferCurrentBalanceTo.Size = new System.Drawing.Size(0, 23);
            this.lblTransferCurrentBalanceTo.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label10.Location = new System.Drawing.Point(453, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 19);
            this.label10.TabIndex = 48;
            // 
            // lblTransferCurrentBalanceFrom
            // 
            this.lblTransferCurrentBalanceFrom.AutoSize = true;
            this.lblTransferCurrentBalanceFrom.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransferCurrentBalanceFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTransferCurrentBalanceFrom.Location = new System.Drawing.Point(220, 95);
            this.lblTransferCurrentBalanceFrom.Name = "lblTransferCurrentBalanceFrom";
            this.lblTransferCurrentBalanceFrom.Size = new System.Drawing.Size(0, 23);
            this.lblTransferCurrentBalanceFrom.TabIndex = 49;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label12.Location = new System.Drawing.Point(64, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 19);
            this.label12.TabIndex = 48;
            // 
            // lblNewToAccBalance
            // 
            this.lblNewToAccBalance.AutoSize = true;
            this.lblNewToAccBalance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewToAccBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblNewToAccBalance.Location = new System.Drawing.Point(265, 385);
            this.lblNewToAccBalance.Name = "lblNewToAccBalance";
            this.lblNewToAccBalance.Size = new System.Drawing.Size(0, 19);
            this.lblNewToAccBalance.TabIndex = 47;
            // 
            // lblNewFromAccBalance
            // 
            this.lblNewFromAccBalance.AutoSize = true;
            this.lblNewFromAccBalance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewFromAccBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblNewFromAccBalance.Location = new System.Drawing.Point(265, 355);
            this.lblNewFromAccBalance.Name = "lblNewFromAccBalance";
            this.lblNewFromAccBalance.Size = new System.Drawing.Size(0, 19);
            this.lblNewFromAccBalance.TabIndex = 47;
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.SystemColors.Control;
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnTransfer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnTransfer.Location = new System.Drawing.Point(68, 283);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(198, 49);
            this.btnTransfer.TabIndex = 46;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // numTransferAmount
            // 
            this.numTransferAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.numTransferAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numTransferAmount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTransferAmount.Location = new System.Drawing.Point(68, 226);
            this.numTransferAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numTransferAmount.Name = "numTransferAmount";
            this.numTransferAmount.Size = new System.Drawing.Size(198, 27);
            this.numTransferAmount.TabIndex = 45;
            this.numTransferAmount.Validating += new System.ComponentModel.CancelEventHandler(this.numTransferAmount_Validating);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(68, 257);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panel3.Size = new System.Drawing.Size(198, 1);
            this.panel3.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label6.Location = new System.Drawing.Point(64, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 19);
            this.label6.TabIndex = 44;
            this.label6.Text = "Transfer Amount";
            // 
            // cbTransferAccNumTo
            // 
            this.cbTransferAccNumTo.BackColor = System.Drawing.Color.White;
            this.cbTransferAccNumTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTransferAccNumTo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTransferAccNumTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.cbTransferAccNumTo.FormattingEnabled = true;
            this.cbTransferAccNumTo.Location = new System.Drawing.Point(457, 60);
            this.cbTransferAccNumTo.Name = "cbTransferAccNumTo";
            this.cbTransferAccNumTo.Size = new System.Drawing.Size(198, 24);
            this.cbTransferAccNumTo.TabIndex = 42;
            this.cbTransferAccNumTo.SelectedIndexChanged += new System.EventHandler(this.cbTransferAccNumTo_SelectedIndexChanged);
            // 
            // cbTransferAccNumFrom
            // 
            this.cbTransferAccNumFrom.BackColor = System.Drawing.Color.White;
            this.cbTransferAccNumFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTransferAccNumFrom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTransferAccNumFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.cbTransferAccNumFrom.FormattingEnabled = true;
            this.cbTransferAccNumFrom.Location = new System.Drawing.Point(68, 60);
            this.cbTransferAccNumFrom.Name = "cbTransferAccNumFrom";
            this.cbTransferAccNumFrom.Size = new System.Drawing.Size(198, 24);
            this.cbTransferAccNumFrom.TabIndex = 42;
            this.cbTransferAccNumFrom.SelectedIndexChanged += new System.EventHandler(this.cbTransferAccNumFrom_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label5.Location = new System.Drawing.Point(453, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 19);
            this.label5.TabIndex = 41;
            this.label5.Text = "To Acc. Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label4.Location = new System.Drawing.Point(64, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 19);
            this.label4.TabIndex = 41;
            this.label4.Text = "From Acc. Number";
            // 
            // tabPageTransferLog
            // 
            this.tabPageTransferLog.Controls.Add(this.lblTransferLogCount);
            this.tabPageTransferLog.Controls.Add(this.groupBox1);
            this.tabPageTransferLog.Controls.Add(this.label9);
            this.tabPageTransferLog.Controls.Add(this.panel4);
            this.tabPageTransferLog.Controls.Add(this.lstViewTransferLog);
            this.tabPageTransferLog.Location = new System.Drawing.Point(4, 22);
            this.tabPageTransferLog.Name = "tabPageTransferLog";
            this.tabPageTransferLog.Size = new System.Drawing.Size(789, 530);
            this.tabPageTransferLog.TabIndex = 4;
            this.tabPageTransferLog.Text = "Transfer Log";
            this.tabPageTransferLog.UseVisualStyleBackColor = true;
            // 
            // lblTransferLogCount
            // 
            this.lblTransferLogCount.AutoSize = true;
            this.lblTransferLogCount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransferLogCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblTransferLogCount.Location = new System.Drawing.Point(11, 164);
            this.lblTransferLogCount.Name = "lblTransferLogCount";
            this.lblTransferLogCount.Size = new System.Drawing.Size(0, 19);
            this.lblTransferLogCount.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTransferLogAsc);
            this.groupBox1.Controls.Add(this.rbTransferLogDesc);
            this.groupBox1.Location = new System.Drawing.Point(628, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 52);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sorting";
            // 
            // rbTransferLogAsc
            // 
            this.rbTransferLogAsc.AutoSize = true;
            this.rbTransferLogAsc.Location = new System.Drawing.Point(16, 19);
            this.rbTransferLogAsc.Name = "rbTransferLogAsc";
            this.rbTransferLogAsc.Size = new System.Drawing.Size(42, 17);
            this.rbTransferLogAsc.TabIndex = 9;
            this.rbTransferLogAsc.TabStop = true;
            this.rbTransferLogAsc.Text = "Asc";
            this.rbTransferLogAsc.UseVisualStyleBackColor = true;
            this.rbTransferLogAsc.CheckedChanged += new System.EventHandler(this.rbTransferLogAsc_CheckedChanged);
            // 
            // rbTransferLogDesc
            // 
            this.rbTransferLogDesc.AutoSize = true;
            this.rbTransferLogDesc.Location = new System.Drawing.Point(64, 19);
            this.rbTransferLogDesc.Name = "rbTransferLogDesc";
            this.rbTransferLogDesc.Size = new System.Drawing.Size(48, 17);
            this.rbTransferLogDesc.TabIndex = 9;
            this.rbTransferLogDesc.TabStop = true;
            this.rbTransferLogDesc.Text = "Desc";
            this.rbTransferLogDesc.UseVisualStyleBackColor = true;
            this.rbTransferLogDesc.CheckedChanged += new System.EventHandler(this.rbTransferLogDesc_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label9.Location = new System.Drawing.Point(11, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "Search Acc. Number";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.txtTransferSearch);
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(15, 103);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panel4.Size = new System.Drawing.Size(198, 21);
            this.panel4.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Bank.Properties.Resources.search2;
            this.pictureBox1.Location = new System.Drawing.Point(167, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // txtTransferSearch
            // 
            this.txtTransferSearch.BackColor = System.Drawing.Color.White;
            this.txtTransferSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTransferSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTransferSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransferSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txtTransferSearch.Location = new System.Drawing.Point(0, 0);
            this.txtTransferSearch.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.txtTransferSearch.Name = "txtTransferSearch";
            this.txtTransferSearch.Size = new System.Drawing.Size(198, 20);
            this.txtTransferSearch.TabIndex = 0;
            this.txtTransferSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTransferSearch_KeyUp);
            // 
            // lstViewTransferLog
            // 
            this.lstViewTransferLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.lstViewTransferLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstViewTransferLog.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstViewTransferLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lstViewTransferLog.FullRowSelect = true;
            this.lstViewTransferLog.GridLines = true;
            this.lstViewTransferLog.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstViewTransferLog.HideSelection = false;
            this.lstViewTransferLog.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstViewTransferLog.Location = new System.Drawing.Point(15, 206);
            this.lstViewTransferLog.MultiSelect = false;
            this.lstViewTransferLog.Name = "lstViewTransferLog";
            this.lstViewTransferLog.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstViewTransferLog.Size = new System.Drawing.Size(748, 228);
            this.lstViewTransferLog.TabIndex = 18;
            this.lstViewTransferLog.UseCompatibleStateImageBehavior = false;
            this.lstViewTransferLog.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Date";
            this.columnHeader6.Width = 162;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "s.Acct";
            this.columnHeader7.Width = 96;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "d.Acct";
            this.columnHeader9.Width = 86;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Amount";
            this.columnHeader10.Width = 91;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "s.Balance";
            this.columnHeader11.Width = 117;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "d.Balance";
            this.columnHeader12.Width = 130;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "User Name";
            this.columnHeader13.Width = 224;
            // 
            // errProvTransactions
            // 
            this.errProvTransactions.ContainerControl = this;
            // 
            // FrmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 556);
            this.Controls.Add(this.tabControlTransactions);
            this.Name = "FrmTransactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transactions";
            this.tabControlTransactions.ResumeLayout(false);
            this.tabPageDeposite.ResumeLayout(false);
            this.tabPageDeposite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDepositeAmount)).EndInit();
            this.tabPageWithdraw.ResumeLayout(false);
            this.tabPageWithdraw.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWithdrawAmount)).EndInit();
            this.tabPageTotalBalances.ResumeLayout(false);
            this.tabPageTotalBalances.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grbSort.ResumeLayout(false);
            this.grbSort.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPageTransfer.ResumeLayout(false);
            this.tabPageTransfer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTransferAmount)).EndInit();
            this.tabPageTransferLog.ResumeLayout(false);
            this.tabPageTransferLog.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvTransactions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlTransactions;
        private System.Windows.Forms.TabPage tabPageDeposite;
        private System.Windows.Forms.TabPage tabPageWithdraw;
        private System.Windows.Forms.ComboBox cbDepositeAccNum;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numDepositeAmount;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.NumericUpDown numWithdrawAmount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbWithdrawAccNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPageTotalBalances;
        private System.Windows.Forms.GroupBox grbSort;
        private System.Windows.Forms.RadioButton rbTotalBalancesAsc;
        private System.Windows.Forms.RadioButton rbTotalBalancesDesc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtTotalBalancesSearch;
        private System.Windows.Forms.ListView lstViewTotalBalances;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label lblTotalBalancesClientsCount;
        private System.Windows.Forms.Label lblTotalBalancesWord;
        private System.Windows.Forms.Label lblTotalBalancesNumber;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage tabPageTransfer;
        private System.Windows.Forms.Label lblNewToAccBalance;
        private System.Windows.Forms.Label lblNewFromAccBalance;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.NumericUpDown numTransferAmount;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTransferAccNumTo;
        private System.Windows.Forms.ComboBox cbTransferAccNumFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPageTransferLog;
        private System.Windows.Forms.Label lblTransferLogCount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTransferLogAsc;
        private System.Windows.Forms.RadioButton rbTransferLogDesc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTransferSearch;
        private System.Windows.Forms.ListView lstViewTransferLog;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.Label lblDepositeCurrentBalance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblWithdrawCurrentBalance;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider errProvTransactions;
        private System.Windows.Forms.Label lblTransferCurrentBalanceTo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTransferCurrentBalanceFrom;
        private System.Windows.Forms.Label label12;
    }
}