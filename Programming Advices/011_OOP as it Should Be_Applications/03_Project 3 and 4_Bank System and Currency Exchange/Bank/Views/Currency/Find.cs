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
    internal class Find : FrontEndFunctions
    {
        private string _userChoose()
        {
            int userChoose = 0;
            string result = "";

            userChoose = readUserMenueCorrectChoose(2);
            Console.WriteLine();


            if (userChoose == 1)
                result = readOneInfo("Please Enter Currency Code :").ToString();
            else
                result = readOneInfo("Please Enter Country Name:").ToString();

            return result;
        }
        public void FindCurrency()
        {
            try
            {
                CurrenciesController currenciesController = new CurrenciesController();
                string userChoose = "";

                drawViewHeader("Find Currency", "Find by [1] Code or[2] Country");
                userChoose = _userChoose();
                clsCurrency currency = currenciesController.Get(userChoose);

                while (!currenciesController.IsCurrencyExsist(currency.Code))
                {
                    Console.WriteLine();
                    Console.WriteLine("Currency was Not Found!");
                    Console.WriteLine();
                    userChoose = _userChoose();
                    currency = currenciesController.Get(userChoose);
                }

                printCurreny(currenciesController.Get(userChoose));

                goBack();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
