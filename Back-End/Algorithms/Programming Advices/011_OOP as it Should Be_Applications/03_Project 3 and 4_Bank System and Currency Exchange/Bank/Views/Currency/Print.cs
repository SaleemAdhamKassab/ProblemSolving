using Lab.Bank.Controllers;
using Lab.Bank.Models;
using Lab.Bank.Shared;

namespace Lab.Bank.Views.Currency
{
    internal class Print : FrontEndFunctions
    {
        void _printCurrenciesListTableHeader()
        {
            Console.WriteLine();
            Console.WriteLine(
                padRight("Country", 50, ' ') +
                padRight("Code", 15, ' ') +
                padRight("Name", 50, ' ') +
                padRight("Rate/(1$)", 15, ' '));

            Console.WriteLine(getBreakLine('_', 150));
            Console.WriteLine();
        }
        void _printCurrencyRow(clsCurrency currency)
        {
            Console.Write(padRight(currency.Country, 50, ' '));
            Console.Write(padRight(currency.Code, 15, ' '));
            Console.Write(padRight(currency.Name, 50, ' '));
            Console.Write(padRight(currency.ExchangeRateUSD.ToString(), 15, ' '));
            Console.WriteLine();
        }
        public void printCurrencies()
        {
            try
            {
                CurrenciesController currenciesController = new CurrenciesController();

                List<object> currencies = currenciesController.Get();
                int currenciesCount = currencies.Count;

                if (currenciesCount == 0)
                    Console.WriteLine("No Currencies Available in the System!");
                else
                {
                    Console.WriteLine();
                    drawViewHeader("Currencies List", "(" + currenciesCount + ") Currency (s)");

                    _printCurrenciesListTableHeader();

                    foreach (clsCurrency currency in currencies)
                        _printCurrencyRow(currency);

                    Console.WriteLine(getBreakLine('_', 130));
                }

                goBack();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
