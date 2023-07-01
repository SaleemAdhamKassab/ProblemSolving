using Lab.Bank.Controllers;
using Lab.Bank.Models;
using Lab.Bank.Shared;

namespace Lab.Bank.Views.ManageUsers
{
    internal class Print : FrontEndFunctions
    {
        public void printUsers()
        {
            try
            {
                ManageUsersController manageUsersController = new ManageUsersController();

                List<object> users = manageUsersController.Get();
                int usersCount = users.Count;

                if (usersCount == 0)
                    Console.WriteLine("No Users found");
                else
                {
                    Console.WriteLine();
                    drawViewHeader("Users List", "(" + usersCount + ") User (s)");

                    printUsersListTableHeader();

                    foreach (User user in users)
                        printUserRow(user);

                    Console.WriteLine(getBreakLine('_', 150));
                    Console.WriteLine();
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
