using Lab.Bank.Shared;
using Lab.Bank.Views.Clients;

namespace Lab.Bank.Views.Transactions
{
    internal class StartTransactions : FrontEndFunctions
    {
        private static string[] _transactionsMenueOptions()
        {
            string[] mainMenueOptions = new string[4];
            mainMenueOptions[0] = "Deposit";
            mainMenueOptions[1] = "Withdraw";
            mainMenueOptions[2] = "Total Balance";
            mainMenueOptions[3] = "Main Menue";

            return mainMenueOptions;
        }
        private void _performTransactionsScreens(int userChoose)
        {
            Home clientTransaction = new Home();

            switch (userChoose)
            {
                case 1:
                    clientTransaction.performDepositeView();
                    break;
                case 2:
                    clientTransaction.performWithdrawView();
                    break;
                case 3:
                    clientTransaction.performTotalBalancesView();
                    break;
                case 4:
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
                drawScreenHeader("Transactions Menu");
                drawMenuOptions(_transactionsMenueOptions());
                userChoose = readUserMenuCorrectChoose(6);
                _performTransactionsScreens(userChoose);
            } while (userChoose <= 7);

        }
    }
}