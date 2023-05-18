namespace Bank.Shared
{
    partial class FrmHome
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

        bool _checkUserAccessPrivelege(int menueNumber, int userSessionPrivelege)
        {
            if (userSessionPrivelege == -1)
                return true;

            if ((menueNumber & userSessionPrivelege) == menueNumber)
                return true;

            return false;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();

            // 
            // btnManageClients
            // 
            if (_checkUserAccessPrivelege(1, LoggedUser.loggedUser.Permissions))
            {
                this.btnManageClients = new System.Windows.Forms.Button();

                this.btnManageClients.BackColor = System.Drawing.SystemColors.Control;
                this.btnManageClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.btnManageClients.Font = new System.Drawing.Font("Century Gothic", 15.75F);
                this.btnManageClients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
                this.btnManageClients.Location = new System.Drawing.Point(290, 36);
                this.btnManageClients.Name = "btnManageClients";
                this.btnManageClients.Size = new System.Drawing.Size(290, 49);
                this.btnManageClients.TabIndex = 36;
                this.btnManageClients.Text = "Manage Clients";
                this.btnManageClients.UseVisualStyleBackColor = false;
                this.btnManageClients.Click += new System.EventHandler(this.btnClients_Click);

                this.Controls.Add(this.btnManageClients);
            }

            // 
            // btnManageUsers
            // 
            if (_checkUserAccessPrivelege(2, LoggedUser.loggedUser.Permissions))
            {
                this.btnManageUsers = new System.Windows.Forms.Button();

                this.btnManageUsers.BackColor = System.Drawing.SystemColors.Control;
                this.btnManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.btnManageUsers.Font = new System.Drawing.Font("Century Gothic", 15.75F);
                this.btnManageUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
                this.btnManageUsers.Location = new System.Drawing.Point(290, 201);
                this.btnManageUsers.Name = "btnManageUsers";
                this.btnManageUsers.Size = new System.Drawing.Size(290, 49);
                this.btnManageUsers.TabIndex = 36;
                this.btnManageUsers.Text = "Manage Users";
                this.btnManageUsers.UseVisualStyleBackColor = false;
                this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);

                this.Controls.Add(this.btnManageUsers);
            }

            // 
            // btnClientsTransactions
            // 
            if (_checkUserAccessPrivelege(4, LoggedUser.loggedUser.Permissions))
            {
                this.btnClientsTransactions = new System.Windows.Forms.Button();

                this.btnClientsTransactions.BackColor = System.Drawing.SystemColors.Control;
                this.btnClientsTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.btnClientsTransactions.Font = new System.Drawing.Font("Century Gothic", 15.75F);
                this.btnClientsTransactions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
                this.btnClientsTransactions.Location = new System.Drawing.Point(290, 113);
                this.btnClientsTransactions.Name = "btnClientsTransactions";
                this.btnClientsTransactions.Size = new System.Drawing.Size(290, 49);
                this.btnClientsTransactions.TabIndex = 36;
                this.btnClientsTransactions.Text = "Clients Transactions";
                this.btnClientsTransactions.UseVisualStyleBackColor = false;
                this.btnClientsTransactions.Click += new System.EventHandler(this.btnTransactions_Click);

                this.Controls.Add(this.btnClientsTransactions);
            }

            // 
            // btnCurrencyExchange
            // 
            if (_checkUserAccessPrivelege(8, LoggedUser.loggedUser.Permissions))
            {
                this.btnCurrencyExchange = new System.Windows.Forms.Button();

                this.btnCurrencyExchange.BackColor = System.Drawing.SystemColors.Control;
                this.btnCurrencyExchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.btnCurrencyExchange.Font = new System.Drawing.Font("Century Gothic", 15.75F);
                this.btnCurrencyExchange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
                this.btnCurrencyExchange.Location = new System.Drawing.Point(290, 286);
                this.btnCurrencyExchange.Name = "btnCurrencyExchange";
                this.btnCurrencyExchange.Size = new System.Drawing.Size(290, 49);
                this.btnCurrencyExchange.TabIndex = 36;
                this.btnCurrencyExchange.Text = "Currency Exchange";
                this.btnCurrencyExchange.UseVisualStyleBackColor = false;
                this.btnCurrencyExchange.Click += new System.EventHandler(this.btnCurrencyExchange_Click);

                this.Controls.Add(this.btnCurrencyExchange);
            }
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 450);
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button btnManageClients;
        private System.Windows.Forms.Button btnClientsTransactions;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnCurrencyExchange;
    }
}