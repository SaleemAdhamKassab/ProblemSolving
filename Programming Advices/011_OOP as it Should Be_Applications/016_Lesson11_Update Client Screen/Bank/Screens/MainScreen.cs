using Lab.Bank.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Bank.Screens
{
    internal class MainScreen : Screen
    {
        private static int _usersessionPrivelege = -1;
        private static int _readUserMenuChoose(bool isMainMenue = true)
        {
            int to = 8;

            if (!isMainMenue)
                to = 4;

            Console.Write("Choose What do you want to Do? [1 to {0}] :", to);
            return int.Parse(Console.ReadLine());
        }
        private static bool _checkUserAccessPrivelege(int menueNumber, int userSessionPrivelege)
        {
            if (userSessionPrivelege == -1)
                return true;

            if ((menueNumber & userSessionPrivelege) == menueNumber)
                return true;

            return false;
        }
        private static string[] _mainMenueOptions()
        {
            string[] mainMenueOptions = new string[8];
            mainMenueOptions[0] = "Show Clients List";
            mainMenueOptions[1] = "Add New Client";
            mainMenueOptions[2] = "Delete Client";
            mainMenueOptions[3] = "Update Client Info";
            mainMenueOptions[4] = "Find Client";
            mainMenueOptions[5] = "Transactions";
            mainMenueOptions[6] = "Manage Users";
            mainMenueOptions[7] = "Logout";

            return mainMenueOptions;
        }
        private static void _printMainMenueOptions()
        {
            string[] menueOptions = _mainMenueOptions();

            for (int i = 0; i < menueOptions.Length; i++)
                Console.WriteLine("[{0}] " + menueOptions[i], i + 1);
        }
        private static void _printMainMenu()
        {
            Console.Clear();
            drawScreenHeader("Main Menue Screen");
            _printMainMenueOptions();
            printBreakLine("=", 100);
            Console.WriteLine();
        }
        public static void StartBank()
        {
            int userChoose = 0;
            do
            {
                _printMainMenu();
                userChoose = _readUserMenuChoose();

                switch (userChoose)
                {
                    case 1:
                        if (_checkUserAccessPrivelege(1, _usersessionPrivelege))
                        {
                            ClientsList.PrintClients();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("printAccessDeniedPage()");
                            goBack();
                            break;
                        }

                    case 2:
                        if (_checkUserAccessPrivelege(2, _usersessionPrivelege))
                        {
                            AddNewClient.Add();
                            goBack();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("printAccessDeniedPage()");
                            goBack();
                            break;
                        }
                    case 3:
                        if (_checkUserAccessPrivelege(4, _usersessionPrivelege))
                        {
                            DeleteClient.Delete();
                            goBack();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("printAccessDeniedPage()");
                            goBack();
                            break;
                        }
                    case 4:
                        if (_checkUserAccessPrivelege(8, _usersessionPrivelege))
                        {
                            UpdateClient.Update();
                            goBack();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("printAccessDeniedPage()");
                            goBack();
                            break;
                        }
                    case 5:
                        if (_checkUserAccessPrivelege(16, _usersessionPrivelege))
                        {
                            Console.WriteLine("printClient(readClientAccountNumber())");
                            goBack();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("printAccessDeniedPage()");
                            goBack();
                            break;
                        }

                    case 6:
                        if (_checkUserAccessPrivelege(32, _usersessionPrivelege))
                        {
                            Console.Clear();
                            Console.WriteLine("transactions()");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("printAccessDeniedPage()");
                            goBack();
                            break;
                        }
                    case 7:
                        if (_checkUserAccessPrivelege(64, _usersessionPrivelege))
                        {
                            Console.Clear();
                            Console.WriteLine("manageUsers()");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("printAccessDeniedPage()");
                            goBack();
                            break;
                        }

                    case 8:
                        Console.WriteLine("login()");
                        break;

                    default:
                        Console.WriteLine("Invalid Choose, Press any key to rechoose..");
                        Console.ReadKey();
                        StartBank();
                        break;
                }
            } while (userChoose <= 7);
        }
    }
}