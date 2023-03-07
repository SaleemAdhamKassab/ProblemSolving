using Lab.Bank.Db;
using Lab.Bank.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Bank.Screens.ManageUsers
{
    internal class UsersList : Screen
    {
        private static void _printUsersListTableHeader()
        {
            Console.WriteLine();
            Console.WriteLine(
                padRight("First Name", 20, ' ') +
                padRight("Last Name", 20, ' ') +
                padRight("Email", 30, ' ') +
                padRight("Phone", 25, ' ') +
                padRight("UserName", 25, ' ') +
                padRight("Password", 25, ' ') +
                padRight("Permissions", 25, ' '));

            printBreakLine("_", 160);
            Console.WriteLine();
        }
        private static void _printUserRow(User user)
        {
            Console.Write(padRight(user.FirstName, 20, ' '));
            Console.Write(padRight(user.LastName, 20, ' '));
            Console.Write(padRight(user.Email, 30, ' '));
            Console.Write(padRight(user.Phone, 25, ' '));
            Console.Write(padRight(user.UserName, 25, ' '));
            Console.Write(padRight(user.Password, 25, ' '));
            Console.Write(padRight(user.Permissions.ToString(), 25, ' '));
            Console.WriteLine();
        }
        public static void printUsers()
        {
            List<object> users = FileDbContext.convertFileDataToList(FileDbContext.UsersDbConnectionString,
                                                                     FileDbContext.FileRowSeparator,
                                                                     FileDbContext.enConvertLineToObjetTypes.User);
            int usersCount = users.Count;

            if (usersCount == 0)
                Console.WriteLine("No Users found");
            else
            {
                Console.WriteLine();
                drawScreenHeader("Users List", "(" + usersCount + ") User (s)");
                _printUsersListTableHeader();
                foreach (User user in users)
                    _printUserRow(user);
                printBreakLine("_", 160);
            }

            goBack();
        }
    }
}
