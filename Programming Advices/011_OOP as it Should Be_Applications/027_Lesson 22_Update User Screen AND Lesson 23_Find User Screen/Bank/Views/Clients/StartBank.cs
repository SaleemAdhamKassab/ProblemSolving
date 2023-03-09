using Lab.Bank.Shared;
using Lab.Bank.Views.ManageUsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Bank.Views.Clients
{
    public class StartBank : FrontEndFunctions
    {
        private static int _usersessionPrivelege = -1;
        private static bool _checkUserAccessPrivelege(int menueNumber, int userSessionPrivelege)
        {
            if (userSessionPrivelege == -1)
                return true;

            if ((menueNumber & userSessionPrivelege) == menueNumber)
                return true;

            return false;
        }
        private void _performClientsScreens(int userChoose)
        {
            Home clients = new Home();
            StartManageUsers startManageUsers = new StartManageUsers();

            switch (userChoose)
            {
                case 1:
                    if (_checkUserAccessPrivelege(1, _usersessionPrivelege))
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
                    if (_checkUserAccessPrivelege(2, _usersessionPrivelege))
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
                    if (_checkUserAccessPrivelege(4, _usersessionPrivelege))
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
                    if (_checkUserAccessPrivelege(8, _usersessionPrivelege))
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
                    if (_checkUserAccessPrivelege(16, _usersessionPrivelege))
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
                    if (_checkUserAccessPrivelege(32, _usersessionPrivelege))
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
                    if (_checkUserAccessPrivelege(64, _usersessionPrivelege))
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
                    Console.WriteLine("login()");
                    break;
            }
        }
        public void Start()
        {
            int userChoose = 0;
            do
            {
                drawScreenHeader("Main Menu");
                drawMenuOptions(mainMenueOptions());
                userChoose = readUserMenuCorrectChoose(8);
                _performClientsScreens(userChoose);
            } while (userChoose <= 7);
        }
    }
}
