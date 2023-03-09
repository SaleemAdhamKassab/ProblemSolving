using Lab.Bank.Shared;
using Lab.Bank.Views.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Bank.Views.ManageUsers
{
    internal class StartManageUsers : FrontEndFunctions
    {
        private static string[] _manageUsersMenuOptions()
        {
            string[] ManageUsersMenuOptions = new string[6];
            ManageUsersMenuOptions[0] = "List Users";
            ManageUsersMenuOptions[1] = "Add New User";
            ManageUsersMenuOptions[2] = "Delete User";
            ManageUsersMenuOptions[3] = "Update User";
            ManageUsersMenuOptions[4] = "Find User";
            ManageUsersMenuOptions[5] = "Main Menu";

            return ManageUsersMenuOptions;
        }
        private void _performManageUsersScreens(int userChoose)
        {
            Home manageUsers = new Home();

            switch (userChoose)
            {
                case 1:
                    manageUsers.performPrintClientsView();
                    break;
                case 2:
                    manageUsers.perfoemAddClientView();
                    break;
                case 3:
                    manageUsers.perfoemDeleteUserView();
                    break;
                case 4:
                    manageUsers.perfoemUpdateUserView();
                    break;
                case 5:
                    manageUsers.perfoemFindUserView();
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
                drawScreenHeader("Transactions Menu");
                drawMenuOptions(_manageUsersMenuOptions());
                userChoose = readUserMenuCorrectChoose(6);
                _performManageUsersScreens(userChoose);
            } while (userChoose <= 7);
        }
    }
}
