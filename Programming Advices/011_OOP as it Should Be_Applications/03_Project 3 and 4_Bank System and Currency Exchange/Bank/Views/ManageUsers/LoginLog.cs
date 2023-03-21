using Lab.Bank.Controllers;
using Lab.Bank.Models;
using Lab.Bank.Shared;

namespace Lab.Bank.Views.ManageUsers
{
    internal class LoginLog : FrontEndFunctions
    {
        void _printUserLoginLogRow(UsersLoginLog usersLoginLog)
        {
            Console.Write(padRight(usersLoginLog.LogDate, 25, ' '));
            printUserRow(usersLoginLog);
        }
        public void print()
        {
            try
            {
                ManageUsersController manageUsersController = new ManageUsersController();

                List<object> loginUsers = manageUsersController.getLoginLog();
                int usersCount = loginUsers.Count;

                if (usersCount == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("No Users found!");
                }   
                else
                {
                    Console.WriteLine();
                    drawViewHeader("Login Register List", "(" + usersCount + ") User (s)");

                    printUsersListTableHeader(true);

                    foreach (UsersLoginLog user in loginUsers)
                        _printUserLoginLogRow(user);

                    Console.WriteLine(getBreakLine('_', 150));
                }

                goBack();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
