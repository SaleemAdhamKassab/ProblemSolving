using Bank.Shared;
using Bank.Views.Clients;
using Lab.Bank.Controllers;
using Lab.Bank.Models;
using Lab.Bank.Shared;
using Lab.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Bank.Views
{
    public partial class FrmTransactions : FrmLayout
    {
        Client _clientToUpdate;
        ClientsController clientsController = new ClientsController();
        TransactionsController transactionsController = new TransactionsController();
        FrontEndFunctions frontEndFunctions = new FrontEndFunctions();
        List<object> _clients = new List<object>();
        List<object> transferBalancesLog = new List<object>();
        List<string> accNumbers = new List<string>();

        public FrmTransactions() : base("Transactions")
        {
            InitializeComponent();
            resetTransactionsForms();
            fillTransactionsComboboxesAccountNumbers();
        }
        public FrmTransactions(int tabIndex, string clientAccountNumber) : base("Transactions")
        {
            InitializeComponent();
            resetTransactionsForms();
            fillTransactionsComboboxesAccountNumbers();

            switch (tabIndex)
            {
                case 0:
                    cbDepositeAccNum.Text = clientAccountNumber;
                    break;
                case 1:
                    cbWithdrawAccNum.Text = clientAccountNumber;
                    break;
                case 3:
                    cbTransferAccNumFrom.Text = clientAccountNumber;
                    break;
            }

            tabControlTransactions.SelectedIndex = tabIndex;
        }
        private void resetTransactionsForms()
        {
            resetDepositeForm();
            resetWithdrawForm();
            resetTatalBalancesForm();
            resetTransferForm();
            resetTransferLogForm();
        }
        private void fillTransactionsComboboxesAccountNumbers()
        {
            accNumbers = clientsController.getAccountNumbers();

            foreach (string accNumber in accNumbers)
            {
                cbDepositeAccNum.Items.Add(accNumber);
                cbWithdrawAccNum.Items.Add(accNumber);
                cbTransferAccNumFrom.Items.Add(accNumber);
            }
        }

        ////////////////////////// Start here /////////////////////////
        private void tabControlTransactions_SelectedIndexChanged(object sender, EventArgs e) => resetTransactionsForms();

        ////////////////////////// Deposite /////////////////////////
        private void resetDepositeForm()
        {
            cbDepositeAccNum.Text = null;
            lblDepositeCurrentBalance.ResetText();
            numDepositeAmount.Value = 0;
            label7.Text = null;
            numDepositeAmount.Enabled = false;
            btnDeposit.Enabled = false;
        }
        private void cbDepositeAccNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cbDepositeAccNum.Text))
            {
                _clientToUpdate = clientsController.Get(cbDepositeAccNum.SelectedItem.ToString());
                label7.Text = "Current Balance is:";
                lblDepositeCurrentBalance.Text = "$ " + _clientToUpdate.AccountBalance;
                numDepositeAmount.Enabled = true;
            }
        }
        private void numDepositeAmount_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (numDepositeAmount.Value < 1)
            {
                e.Cancel = true;
                numDepositeAmount.Focus();
                errProvTransactions.SetError(numDepositeAmount, "Deposit Amount Must be Greater Than $0");
            }
            else
            {
                e.Cancel = false;
                errProvTransactions.SetError(numDepositeAmount, "");
                btnDeposit.Enabled = true;
            }
        }
        private void btnDeposit_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show(
                            "Are you sure to perfoem this transaction?",
                            "Confirm"
                            , MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Question) == DialogResult.OK)
            {
                transactionsController.deposit(cbDepositeAccNum.Text,
                                               int.Parse(numDepositeAmount.Value.ToString()));

                _clientToUpdate = clientsController.Get(cbDepositeAccNum.SelectedItem.ToString());

                lblDepositeCurrentBalance.Text = "$ " + (_clientToUpdate.AccountBalance);

                MessageBox.Show(
                "Amount has been deposited ($" + numDepositeAmount.Value + ") Successfully",
                "Alarm"
                , MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                numDepositeAmount.Value = 0;

                resetDepositeForm();
            }
        }

        ////////////////////////// Withdraw /////////////////////////
        private void resetWithdrawForm()
        {
            cbWithdrawAccNum.Text = null;
            lblWithdrawCurrentBalance.ResetText();
            label11.Text = null;
            numWithdrawAmount.Value = 0;
            numWithdrawAmount.Enabled = false;
            btnWithdraw.Enabled = false;
        }
        private void comboBoxWithdrawAccountNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cbWithdrawAccNum.Text))
            {
                _clientToUpdate = clientsController.Get(cbWithdrawAccNum.SelectedItem.ToString());

                if (_clientToUpdate.AccountBalance == 0)
                {
                    resetWithdrawForm();
                    MessageBox.Show("Empty Balance!!",
                                    "Info",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }

                label11.Text = "Current Balance is:";
                lblWithdrawCurrentBalance.Text = "$ " + _clientToUpdate.AccountBalance;

                numWithdrawAmount.Maximum = int.Parse(_clientToUpdate.AccountBalance.ToString());
                numWithdrawAmount.Value = int.Parse(_clientToUpdate.AccountBalance.ToString());

                numWithdrawAmount.Enabled = true;
            }
        }
        private void numWithdrawAmount_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (numWithdrawAmount.Value < 1)
            {
                e.Cancel = true;
                numWithdrawAmount.Focus();
                errProvTransactions.SetError(numWithdrawAmount, "WithDraw Amount Must be Greater Than $0");
            }
            else
            {
                e.Cancel = false;
                errProvTransactions.SetError(numWithdrawAmount, "");
                btnWithdraw.Enabled = true;
            }
        }
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                            "Are you sure to perfoem this transaction?",
                            "Confirm"
                            , MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Question) == DialogResult.OK)
            {
                transactionsController.withdraw(cbWithdrawAccNum.Text,
                                                int.Parse(numWithdrawAmount.Value.ToString()));

                _clientToUpdate = clientsController.Get(cbWithdrawAccNum.SelectedItem.ToString());

                MessageBox.Show(
                "Amount has been withdrawn ($" + numWithdrawAmount.Value + ") Successfully",
                "Alarm"
                , MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                lblWithdrawCurrentBalance.Text = "$ " + _clientToUpdate.AccountBalance;
                resetWithdrawForm();
            }

        }

        ///////////////////////// Total Balances /////////////////////////
        private void resetTatalBalancesForm()
        {
            txtTotalBalancesSearch.ResetText();
            fillClientListView();
            printTotalBalances();
        }
        private void fillClientListView()
        {
            _clients = clientsController.Get();
            lstViewTotalBalances.Columns[2].Width = lstViewTotalBalances.Columns[0].Width;
            frontEndFunctions.fillListView(_clients, lstViewTotalBalances, lblTotalBalancesClientsCount, "clients", true);
        }
        private void printTotalBalances()
        {
            int totalBalances = transactionsController.clientsTotalBalances();

            lblTotalBalancesNumber.Text = "Total Balances is: ($" + totalBalances + ")";
            lblTotalBalancesWord.Text = "( " + SaleemUtil.NumberToText(totalBalances) + " ) Dollar (s)";
        }
        private void txtTotalBalancesSearch_KeyUp(object sender, KeyEventArgs e) => frontEndFunctions.txtSearch_KeyUp(sender, e, lstViewTotalBalances, _clients, txtTotalBalancesSearch, lblTotalBalancesClientsCount, "clients", true);
        private void rbAsc_CheckedChanged(object sender, EventArgs e) => frontEndFunctions.lstViewSort(sender, e, lstViewTotalBalances);
        private void rbDesc_CheckedChanged(object sender, EventArgs e) => frontEndFunctions.lstViewSort(sender, e, lstViewTotalBalances, SortOrder.Descending);

        ////////////////////////// Transfer /////////////////////////
        private void resetTransferForm()
        {
            cbTransferAccNumFrom.Text = null;
            cbTransferAccNumTo.Text = null;
            label10.ResetText();
            label12.ResetText();
            lblTransferCurrentBalanceFrom.ResetText();
            lblTransferCurrentBalanceTo.ResetText();
            numTransferAmount.Value = 0;
            cbTransferAccNumTo.Enabled = false;
            numTransferAmount.Enabled = false;
            btnTransfer.Enabled = false;

        }
        private void cbTransferAccNumFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cbTransferAccNumFrom.Text))
            {
                _clientToUpdate = clientsController.Get(cbTransferAccNumFrom.SelectedItem.ToString());

                if (_clientToUpdate.AccountBalance == 0)
                {
                    MessageBox.Show(
                            "Cannot Transfer From Acc. (" + _clientToUpdate.AccountNumber + ") \n" + "Balance is: $0",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                    resetTransferForm();
                    return;
                }

                label12.Text = "Current Balance is:";
                lblTransferCurrentBalanceFrom.Text = "$ " + _clientToUpdate.AccountBalance;


                fillTransferCbTransferAccNumTo();
                cbTransferAccNumTo.Enabled = true;
            }
        }
        private void fillTransferCbTransferAccNumTo()
        {
            cbTransferAccNumTo.Items.Clear();

            List<string> accNums = accNumbers
                .Where(e => e != cbTransferAccNumFrom.Text)
                .ToList();

            foreach (string accNumber in accNums)
                cbTransferAccNumTo.Items.Add(accNumber);
        }
        private void cbTransferAccNumTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cbTransferAccNumTo.Text))
            {
                label10.Text = "Current Balance is:";
                lblTransferCurrentBalanceTo.Text = "$ " + clientsController.Get(cbTransferAccNumTo.SelectedItem.ToString()).AccountBalance;

                numTransferAmount.Maximum = _clientToUpdate.AccountBalance;
                numTransferAmount.Value = _clientToUpdate.AccountBalance;
                numTransferAmount.Enabled = true;
            }

        }
        private void numTransferAmount_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (numTransferAmount.Value < 1)
            {
                e.Cancel = true;
                numWithdrawAmount.Focus();
                errProvTransactions.SetError(numTransferAmount, "Transfer Amount Must be Greater Than $0");
            }
            else
            {
                e.Cancel = false;
                errProvTransactions.SetError(numTransferAmount, "");
                btnTransfer.Enabled = true;
            }
        }
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                           "Are you sure to perfoem this transaction?",
                           "Confirm"
                           , MessageBoxButtons.OKCancel,
                           MessageBoxIcon.Question) == DialogResult.OK)
            {
                transactionsController.transfer(
                   int.Parse(numTransferAmount.Value.ToString()),
                   cbTransferAccNumFrom.Text,
                   cbTransferAccNumTo.Text);

                Client toClient = clientsController.Get(cbTransferAccNumTo.SelectedItem.ToString());

                ClientsTransferLog clientsTransferLog = new ClientsTransferLog(

                       DateTime.Now.ToString("MM/dd/yyyy HH:mm"),
                       _clientToUpdate.AccountNumber,
                       toClient.AccountNumber,
                       int.Parse(numTransferAmount.Value.ToString()),
                       _clientToUpdate.AccountBalance,
                        toClient.AccountBalance,
                       _clientToUpdate.FirstName);

                clientsController.addTransferBalanceLog(clientsTransferLog);


                MessageBox.Show(
                "Transfer Done Successfully",
                "Alarm",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);


                resetTransferForm();
            }
        }

        ////////////////////////// Transfer Log /////////////////////////
        private void resetTransferLogForm()
        {
            lstViewTransferLog.Items.Clear();
            txtTransferSearch.Clear();
            fillTransferLogListView();
        }
        private void txtTransferSearch_KeyUp(object sender, KeyEventArgs e) => frontEndFunctions.txtSearch_KeyUp(sender, e, lstViewTransferLog, transferBalancesLog, txtTransferSearch, lblTransferLogCount, "transferLog");
        private void fillTransferLogListView()
        {
            transferBalancesLog = clientsController.getTransferBalancesLog();

            lstViewTransferLog.Columns[6].Width = lstViewTransferLog.Columns[5].Width;

            foreach (ClientsTransferLog clientsTransferLog in transferBalancesLog)
            {
                ListViewItem clientItem = frontEndFunctions.getTransferLogViewItem(clientsTransferLog);
                lstViewTransferLog.Items.Add(clientItem);
            }

            lblTransferLogCount.Text = transferBalancesLog.Count().ToString() + " Client (s)";
            frontEndFunctions.listViewRowsBackcolor(lstViewTransferLog);
        }
        private void rbTransferLogAsc_CheckedChanged(object sender, EventArgs e) => frontEndFunctions.lstViewSort(sender, e, lstViewTransferLog);
        private void rbTransferLogDesc_CheckedChanged(object sender, EventArgs e) => frontEndFunctions.lstViewSort(sender, e, lstViewTransferLog, SortOrder.Descending);
    }
}