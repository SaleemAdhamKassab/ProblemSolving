using Lab.Bank.Controllers;
using Lab.Bank.Models;
using Lab.Bank.Shared;
using Lab.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Bank.Views.Currency
{
    internal class CurrencyCalculator : FrontEndFunctions
    {
        clsCurrency _readValidCurrency(int currencyNumber)
        {
            CurrenciesController currenciesController = new CurrenciesController();
            clsCurrency currency = currenciesController.Get(readOneInfo("Please Enter Currency " + currencyNumber + " Code: ").ToString());

            while (currency.Code == "")
                currency = currenciesController.Get(readOneInfo("Invalid Currency Code, Please Enter Currency " + currencyNumber + " Code: ").ToString());

            Console.WriteLine();
            return currency;
        }
        void _printCurrencyCalculator(double amountToExchange, clsCurrency currency1, clsCurrency currency2, CurrenciesController currenciesController)
        {
            Console.WriteLine();
            Console.WriteLine("{0} {1} = {2} {3}", amountToExchange, currency1.Code, currenciesController.currencyCalculater(currency1.Code, currency2.Code, amountToExchange), currency2.Code);
        }
        public void calculateCurriencies()
        {
            try
            {
                do
                {
                    CurrenciesController currenciesController = new CurrenciesController();
                    drawViewHeader("Currency Calculator");

                    clsCurrency currency1 = _readValidCurrency(1), currency2 = _readValidCurrency(2);
                    double amountToExchange = double.Parse(readOneInfo("Enter Amount to Exchange: ").ToString());

                    printCurreny(currency1, "Convert From");
                    _printCurrencyCalculator(amountToExchange, currency1, currency2, currenciesController);

                } while (readYesOrNoChoose("Do you want to perforrm another calculation? Y/N :") == 'y');

                goBack();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
