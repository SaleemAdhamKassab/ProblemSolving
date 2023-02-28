using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Bank.Screens
{
    internal class MainScreen : Screen
    {
        private static int _usersessionPrivelege = 0;
        private static int _readUserChoose(bool isMainMenue = true)
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
        private static void _goBack()
        {
            Console.WriteLine("Press any key to go back Menue...");
            Console.ReadKey();
        }
        private static void _printBreakLine(string lineType) => Console.WriteLine(_padRight(lineType, 99, char.Parse(lineType)));
        private static string _padRight(string word, int numberOfFiilingCells, char fillChar)
        {
            if (word.Length >= numberOfFiilingCells)
                return word;

            for (int i = word.Length; i < numberOfFiilingCells; i++)
                word += fillChar;

            return word;
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

        private static void _printMainMenue()
        {
            _DrawScreenHeader("\t\tMain Screen");
            string mainMenue = "Main Menue Screen";
            string[] menueOptions = _mainMenueOptions();

            Console.SetCursorPosition((Console.WindowWidth - mainMenue.Length) / 2, Console.CursorTop);

            Console.WriteLine(mainMenue);
            _printBreakLine("=");

            for (int i = 0; i < menueOptions.Length; i++)
            {
                Console.WriteLine("[{0}] " + menueOptions[i], i + 1);
            }
            _printBreakLine("=");
        }
        public static void StartBank()
        {
            int userChoose = 0;
            do
            {
                Console.Clear();
                _printMainMenue();
                userChoose = _readUserChoose();
                switch (userChoose)
                {
                    case 1:
                        if (_checkUserAccessPrivelege(1, _usersessionPrivelege))
                        {
                            Console.WriteLine("printClients()");
                            _goBack();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("printAccessDeniedPage()");
                            _goBack();
                            break;
                        }

                    case 2:
                        if (_checkUserAccessPrivelege(2, _usersessionPrivelege))
                        {
                            Console.WriteLine("addNewClient()");
                            _goBack();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("printAccessDeniedPage()");
                            _goBack();
                            break;
                        }
                    case 3:
                        if (_checkUserAccessPrivelege(4, _usersessionPrivelege))
                        {
                            Console.WriteLine("deleteClient(readClientAccountNumber())");
                            _goBack();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("printAccessDeniedPage()");
                            _goBack();
                            break;
                        }
                    case 4:
                        if (_checkUserAccessPrivelege(8, _usersessionPrivelege))
                        {
                            Console.WriteLine("updateClient(readClientAccountNumber())");
                            _goBack();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("printAccessDeniedPage()");
                            _goBack();
                            break;
                        }
                    case 5:
                        if (_checkUserAccessPrivelege(16, _usersessionPrivelege))
                        {
                            Console.WriteLine("printClient(readClientAccountNumber())");
                            _goBack();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("printAccessDeniedPage()");
                            _goBack();
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
                            _goBack();
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
                            _goBack();
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
