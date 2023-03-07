using Lab.Bank.Db;
using Lab.Class.Bank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Bank.Screens.ManageUsers
{
    internal class AddNewUser : Screen
    {
        public static void Add()
        {
            try
            {
                drawScreenHeader("Add New User");

                string userName = readOneInfo("Enter User Name: ").ToString()!;

                while (IsUserExist(userName))
                    userName = readOneInfo("User Name (" + userName + ") is already used, choose another one: ").ToString();

                User user = readUserInfo(userName);
                user.UserName = userName;

                if (FileDbContext.saveRowToFile(FileDbContext.UsersDbConnectionString, FileDbContext.convertUserObjectToRowStringForSaving(user)))
                {
                    Console.WriteLine();
                    Console.WriteLine("User ({0}) Added Successfully", userName);
                    PrintUser(user);
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