using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Bank.Views.Currency
{
    internal class Home
    {
        Print print = new Print();
        Find find = new Find();
        Update Update = new Update();
        CurrencyCalculator currencyCalculator = new CurrencyCalculator();

        public void performPrintCurrenciesView() => print.printCurrencies();
        public void performFindCurrencyView() => find.FindCurrency();
        public void performUpdateCurrencyView() => Update.UpdateCurrency();
        public void performCurrencyCalculaterView() => currencyCalculator.calculateCurriencies();
    }
}