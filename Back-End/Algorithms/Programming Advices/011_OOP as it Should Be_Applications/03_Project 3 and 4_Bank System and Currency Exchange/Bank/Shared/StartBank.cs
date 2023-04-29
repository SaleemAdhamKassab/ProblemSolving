using Lab.Bank.Shared;
using Lab.Bank.Views.Currency;
using Lab.Bank.Views.ManageUsers;

namespace Lab.Bank.Views.Clients
{
    public class StartBank : FrontEndFunctions
    {
        bool _checkUserAccessPrivelege(int menueNumber, int userSessionPrivelege)
        {
            if (userSessionPrivelege == -1)
                return true;

            if ((menueNumber & userSessionPrivelege) == menueNumber)
                return true;

            return false;
        }
        void _performMainViews(int userChoose)
        {
            Home clients = new Home();
            StartManageUsers startManageUsers = new StartManageUsers();
            StartCurrencies currencies = new StartCurrencies();

            int usersessionPrivelege = currentUser.Permissions;

            switch (userChoose)
            {
                case 1:
                    if (_checkUserAccessPrivelege(1, usersessionPrivelege))
                    {
                        clients.performPrintClientsView();
                        break;
                    }
                    else
                    {
                        accessDenied();
                        break;
                    }

                case 2:
                    if (_checkUserAccessPrivelege(2, usersessionPrivelege))
                    {
                        clients.perfoemAddClientView();
                        break;
                    }
                    else
                    {
                        accessDenied();
                        break;
                    }
                case 3:
                    if (_checkUserAccessPrivelege(4, usersessionPrivelege))
                    {
                        clients.perfoemDeleteClientView();
                        break;
                    }
                    else
                    {
                        accessDenied();
                        break;
                    }
                case 4:
                    if (_checkUserAccessPrivelege(8, usersessionPrivelege))
                    {
                        clients.perfoemUpdateClientView();
                        break;
                    }
                    else
                    {
                        accessDenied();
                        break;
                    }
                case 5:
                    if (_checkUserAccessPrivelege(16, usersessionPrivelege))
                    {
                        clients.perfoemFindClientView();
                        break;
                    }
                    else
                    {
                        accessDenied();
                        break;
                    }

                case 6:
                    if (_checkUserAccessPrivelege(32, usersessionPrivelege))
                    {
                        clients.startTransactionsHomeView();
                        break;
                    }
                    else
                    {
                        accessDenied();
                        break;
                    }
                case 7:
                    if (_checkUserAccessPrivelege(64, usersessionPrivelege))
                    {
                        startManageUsers.start();
                        break;
                    }
                    else
                    {
                        accessDenied();
                        break;
                    }
                case 8:
                    if (_checkUserAccessPrivelege(128, usersessionPrivelege))
                    {
                        clients.perfoemUsersLoginLogView();
                        break;
                    }
                    else
                    {
                        accessDenied();
                        break;
                    }
                case 9:
                    if (_checkUserAccessPrivelege(256, usersessionPrivelege))
                    {
                        currencies.start();
                        break;
                    }
                    else
                    {
                        accessDenied();
                        break;
                    }
                case 10:
                    Console.Clear();
                    logOut();
                    break;
            }
        }
        public void Start()
        {
            int userChoose = 0;
            do
            {
                drawViewHeader("Main Menue");
                drawMenueOptions(mainMenueOptions());
                userChoose = readUserMenueCorrectChoose(10);

                if (userChoose == 10)
                {
                    Login login = new Login();
                    login.login();
                }
                _performMainViews(userChoose);

            } while (userChoose < 10);
        }
    }
}