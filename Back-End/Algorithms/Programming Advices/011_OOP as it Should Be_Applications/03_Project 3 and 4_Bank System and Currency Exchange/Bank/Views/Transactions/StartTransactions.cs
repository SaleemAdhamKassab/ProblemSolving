using Lab.Bank.Shared;
using Lab.Bank.Views.Clients;

namespace Lab.Bank.Views.Transactions
{
    internal class StartTransactions : FrontEndFunctions
    {
        static string[] _transactionsMenueOptions()
        {
            string[] mainMenueOptions = new string[6];
            mainMenueOptions[0] = "Deposit";
            mainMenueOptions[1] = "Withdraw";
            mainMenueOptions[2] = "Total Balance";
            mainMenueOptions[3] = "Transfer";
            mainMenueOptions[4] = "Transfer Log";
            mainMenueOptions[5] = "Main Menue";

            return mainMenueOptions;
        }
        void _performTransactionsViews(int userChoose)
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
                    clientTransaction.performTransferView();
                    break;
                case 5:
                    clientTransaction.performTransferLogView();
                    break;
                case 6:
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
                drawViewHeader("Transactions Menue");
                drawMenueOptions(_transactionsMenueOptions());
                userChoose = readUserMenueCorrectChoose(6);
                _performTransactionsViews(userChoose);

            } while (userChoose < 6);

        }
    }
}