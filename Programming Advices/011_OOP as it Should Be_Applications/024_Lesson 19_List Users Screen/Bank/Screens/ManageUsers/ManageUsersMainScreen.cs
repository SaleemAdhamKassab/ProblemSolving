using Lab.Bank.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Bank.Screens.ManageUsers
{
    internal class ManageUsersMainScreen : Screen
    {
        private static string[] _ManageUsersMenueOptions()
        {
            string[] ManageUsersMenuOptions = new string[6];
            ManageUsersMenuOptions[0] = "List Users";
            ManageUsersMenuOptions[1] = "Add New User";
            ManageUsersMenuOptions[2] = "Delete User";
            ManageUsersMenuOptions[3] = "Update User";
            ManageUsersMenuOptions[4] = "Find User";
            ManageUsersMenuOptions[5] = "Main Menue";

            return ManageUsersMenuOptions;
        }
        private static void _printManageUsersMainMenu()
        {
            drawScreenHeader("Manage Users");
            printMenueOptions(_ManageUsersMenueOptions());
            printBreakLine("=", 30);
            Console.WriteLine();
        }
        public static void StartManageUsersScreen()
        {
            int userChoose = 0;
            do
            {
                _printManageUsersMainMenu();
                userChoose = userMenuChoose(6);

                switch (userChoose)
                {
                    case 1:
                        UsersList.printUsers();
                        goBack();
                        break;
                    case 2:
                        Console.WriteLine("addUsers()");
                        goBack();
                        break;
                    case 3:
                        Console.WriteLine("deleteUsers()");
                        goBack();
                        break;
                    case 4:
                        Console.WriteLine("updateUsers()");
                        goBack();
                        break;
                    case 5:
                        Console.WriteLine("printUsers()");
                        goBack();
                        break;

                    case 6:
                        MainScreen.StartBank();
                        break;

                    default:
                        Console.WriteLine("Invalid Menue Option!");
                        Console.WriteLine("Press any key to Rechoose...");
                        Console.ReadKey();
                        StartManageUsersScreen();
                        break;
                }


            } while (userChoose <= 6);
        }
    }
}
