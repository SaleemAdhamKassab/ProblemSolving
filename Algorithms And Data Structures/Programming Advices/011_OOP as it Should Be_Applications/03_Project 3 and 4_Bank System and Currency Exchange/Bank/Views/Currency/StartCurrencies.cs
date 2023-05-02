using Lab.Bank.Shared;
using Lab.Bank.Views.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Bank.Views.Currency
{
    internal class StartCurrencies : FrontEndFunctions
    {
        static string[] _currenciesMenueOptions()
        {
            string[] mainMenueOptions = new string[5];
            mainMenueOptions[0] = "List Currencies";
            mainMenueOptions[1] = "Find Currency";
            mainMenueOptions[2] = "Update Rate";
            mainMenueOptions[3] = "Currency Calculater";
            mainMenueOptions[4] = "Main Menue";

            return mainMenueOptions;
        }
        void _performCurrenciesViews(int userChoose)
        {
            Home currency = new Home();

            switch (userChoose)
            {
                case 1:
                    currency.performPrintCurrenciesView();
                    break;
                case 2:
                    currency.performFindCurrencyView();
                    break;
                case 3:
                    currency.performUpdateCurrencyView();
                    break;
                case 4:
                    currency.performCurrencyCalculaterView();
                    break;
                case 5:
                    StartBank startBank = new StartBank();
                    startBank.Start();
                    break;
            }
        }
        public void start()
        {
            int userChoose = 0;

            do
            {
                drawViewHeader("Currency Exchange Menue");
                drawMenueOptions(_currenciesMenueOptions());
                userChoose = readUserMenueCorrectChoose(5);
                _performCurrenciesViews(userChoose);

            } while (userChoose < 5);

        }
    }
}
