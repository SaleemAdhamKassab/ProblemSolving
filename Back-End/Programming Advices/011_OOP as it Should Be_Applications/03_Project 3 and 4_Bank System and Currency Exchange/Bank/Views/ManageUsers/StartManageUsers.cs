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
        static string[] _manageUsersMenueOptions()
        {
            string[] ManageUsersMenueOptions = new string[6];
            ManageUsersMenueOptions[0] = "List Users";
            ManageUsersMenueOptions[1] = "Add New User";
            ManageUsersMenueOptions[2] = "Delete User";
            ManageUsersMenueOptions[3] = "Update User";
            ManageUsersMenueOptions[4] = "Find User";
            ManageUsersMenueOptions[5] = "Main Menu";

            return ManageUsersMenueOptions;
        }
        void _performManageUsersViews(int userChoose)
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
                drawViewHeader("Transactions Menue");
                drawMenueOptions(_manageUsersMenueOptions());
                userChoose = readUserMenueCorrectChoose(6);
                _performManageUsersViews(userChoose);
            } while (userChoose < 6);
        }
    }
}
