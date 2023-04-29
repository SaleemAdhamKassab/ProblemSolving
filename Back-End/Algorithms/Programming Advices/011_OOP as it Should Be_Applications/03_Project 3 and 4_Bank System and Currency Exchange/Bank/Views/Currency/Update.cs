using Lab.Bank.Controllers;
using Lab.Bank.Models;
using Lab.Bank.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Bank.Views.Currency
{
    internal class Update : FrontEndFunctions
    {
        public void UpdateCurrency()
        {
            try
            {
                CurrenciesController currenciesController = new CurrenciesController();

                drawViewHeader("Update Currency");
                string currencyCode = readOneInfo("Enter Currency Code: ").ToString();

                while (!currenciesController.IsCurrencyExsist(currencyCode))
                    currencyCode = readOneInfo("currency Code (" + currencyCode + ") is not found, choose another one: ").ToString();

                clsCurrency currencyToUpdate = currenciesController.Get(currencyCode);
                printCurreny(currencyToUpdate);


                if (confirmationMessage("Are you sure to Update Curreny (" + currencyCode + ") Y/N ?") == 'y')
                {
                    currencyToUpdate.ExchangeRateUSD = double.Parse(readOneInfo("Enter New Rate: ").ToString());
                    currenciesController.Update(currencyToUpdate.Code, currencyToUpdate.ExchangeRateUSD);

                    Console.WriteLine();
                    Console.WriteLine("Currency ({0}) Updated Successfully", currencyToUpdate.Code);

                    printCurreny(currencyToUpdate);
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
