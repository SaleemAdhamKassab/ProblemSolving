using Bank.Shared;
using Lab.Bank.Controllers;
using Lab.Bank.Models;
using Lab.Bank.Shared;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bank.Views
{
    public partial class FrmCurrencyExchange : FrmLayout
    {
        CurrenciesController currenciesController = new CurrenciesController();
        FrontEndFunctions frontEndFunctions = new FrontEndFunctions();
        List<object> currencies = new List<object>();
        clsCurrency currencyToUpdate;

        public FrmCurrencyExchange() : base("Currency Exchange")
        {
            InitializeComponent();
            resetCurrencyExchangeForms();
        }
        ////////////////////////// Start Here /////////////////////////
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) => resetCurrencyExchangeForms();

        ////////////////////////// Shared /////////////////////////
        private void resetCurrencyExchangeForms()
        {
            resetCurrencyExhangeForm();
            resetUpdateRateForm();
            resetCurrencyCalculatorForm();
        }

        ////////////////////////// Show Currency Exhange /////////////////////////
        private void resetCurrencyExhangeForm()
        {
            lstViewShowCurrencies.Items.Clear();
            txtShowCurrenciesSearch.Clear();
            fillShowCurrenciesListView();
        }
        private void fillShowCurrenciesListView()
        {
            currencies = currenciesController.Get();
            frontEndFunctions.fillListView(currencies, lstViewShowCurrencies, lblShowCurrenciesCount, "currencyExchange");
        }
        private void txtShowCurrenciesSearch_KeyUp(object sender, KeyEventArgs e) => frontEndFunctions.txtSearch_KeyUp(sender, e, lstViewShowCurrencies, currencies, txtShowCurrenciesSearch, lblShowCurrenciesCount, "currencyExchange");
        private void rbShowCurrenciesAsc_CheckedChanged(object sender, EventArgs e) => frontEndFunctions.lstViewSort(sender, e, lstViewShowCurrencies);
        private void rbShowCurrenciesDesc_CheckedChanged(object sender, EventArgs e) => frontEndFunctions.lstViewSort(sender, e, lstViewShowCurrencies, SortOrder.Descending);


        ////////////////////////// Update Rate /////////////////////////
        private void resetUpdateRateForm()
        {
            cbUpdateRateCurrencyCode.ResetText();
            numUpdateRate.Value = 0;
            lblCurrenyInfo.ResetText();
            btnUpdateRate.Enabled = false;
            cbUpdateRateCurrencyCode.DataSource = currenciesController.currenciesCode();
        }
        private string getCurrencyDetails(clsCurrency currency) =>
            "Country: " + currency.Country + "\n" +
            "Code: " + currency.Code + "\n" +
            "Name: " + currency.Name + "\n" +
            "Rate(" + currency.ExchangeRateUSD + "$)";

        private void cbUpdateRateCurrencyCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            currencyToUpdate = currenciesController.Get(cbUpdateRateCurrencyCode.SelectedItem.ToString());
            numUpdateRate.Value = decimal.Parse(currencyToUpdate.ExchangeRateUSD.ToString());
            lblCurrenyInfo.Text = getCurrencyDetails(currencyToUpdate);
            btnUpdateRate.Enabled = true;
        }
        private void btnUpdateRate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                           "Are you sure to perfoem this transaction?",
                           "Confirm"
                           , MessageBoxButtons.OKCancel,
                           MessageBoxIcon.Question) == DialogResult.OK)
            {
                currenciesController.Update(currencyToUpdate.Code, double.Parse(numUpdateRate.Value.ToString()));

                MessageBox.Show("Currency (" + cbUpdateRateCurrencyCode.SelectedItem.ToString() + ") Updated Successfully",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                resetUpdateRateForm();
            }
        }


        ////////////////////////// Currency Calculator /////////////////////////
        private void resetCurrencyCalculatorForm()
        {
            cbCurrencyCalculaterCurrencyCodeFrom.ResetText();
            cbCurrencyCalculaterCurrencyCodeTo.ResetText();
            cbCurrencyCalculaterCurrencyCodeTo.Enabled = false;
            numCurrencyCalcAmountToExchange.Enabled = false;
            numCurrencyCalcAmountToExchange.Value = 0;
            cbCurrencyCalculaterCurrencyCodeFrom.DataSource = currenciesController.currenciesCode();
            cbCurrencyCalculaterCurrencyCodeTo.DataSource = currenciesController.currenciesCode();
            btnCurrencyCalcConvert.Enabled = false;

            if (tabControlCurrencyExchange.SelectedIndex != 2)
                lblAmountExchange.ResetText();
        }

        private void cbCurrencyCalculaterCurrencyCodeFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCurrenyCalculaterCurrencyCodeFromInfo.Text = getCurrencyDetails(currenciesController.Get(cbCurrencyCalculaterCurrencyCodeFrom.SelectedItem.ToString()));
            cbCurrencyCalculaterCurrencyCodeTo.Enabled = true;
        }
        private void cbCurrencyCalculaterCurrencyCodeTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCurrenyCalculaterCurrencyCodeToInfo.Text = getCurrencyDetails(currenciesController.Get(cbCurrencyCalculaterCurrencyCodeTo.SelectedItem.ToString()));
            numCurrencyCalcAmountToExchange.Enabled = true;
        }

        private void numCurrencyCalcAmountToExchange_ValueChanged(object sender, EventArgs e)
        {
            btnCurrencyCalcConvert.Enabled = true;
        }

        private void btnCurrencyCalcConvert_Click(object sender, EventArgs e)
        {
            lblAmountExchange.Text =
                numCurrencyCalcAmountToExchange.Value + " " +
                cbCurrencyCalculaterCurrencyCodeFrom.Text + " = " +
                currenciesController.currencyCalculater(cbCurrencyCalculaterCurrencyCodeFrom.Text, cbCurrencyCalculaterCurrencyCodeTo.Text, double.Parse(numCurrencyCalcAmountToExchange.Value.ToString())) + " " +
                cbCurrencyCalculaterCurrencyCodeTo.Text;

            resetCurrencyCalculatorForm();
        }
    }
}