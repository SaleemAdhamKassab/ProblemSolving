using Bank.Views;
using Bank.Views.Clients;
using Lab.Bank.Models;
using System;
using System.Windows.Forms;

namespace Bank.Shared
{
    public partial class FrmHome : FrmLayout
    {
        public FrmHome() : base("Home")
        {
            InitializeComponent();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            FrmClients frmClientsHome = new FrmClients();
            frmClientsHome.ShowDialog();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            FrmTransactions frmTransactions = new FrmTransactions();
            frmTransactions.ShowDialog();
        }
        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            FrmManageUsers frmManageUsers = new FrmManageUsers();
            frmManageUsers.ShowDialog();
        }

        private void btnCurrencyExchange_Click(object sender, EventArgs e)
        {
            FrmCurrencyExchange frmCurrencyExchange = new FrmCurrencyExchange();
            frmCurrencyExchange.ShowDialog();
        }
    }
}