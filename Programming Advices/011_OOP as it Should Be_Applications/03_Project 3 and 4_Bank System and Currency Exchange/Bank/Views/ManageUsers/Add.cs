using Lab.Bank.Controllers;
using Lab.Bank.Models;
using Lab.Bank.Shared;

namespace Lab.Bank.Views.ManageUsers
{
    internal class Add : FrontEndFunctions
    {
        public void AddNewUser()
        {
            try
            {
                ManageUsersController manageUsersController = new ManageUsersController();

                drawViewHeader("Add New User");

                string userName = readOneInfo("Enter User Name: ").ToString();

                while (manageUsersController.IsUserExsist(userName))
                    userName = readOneInfo("User Name (" + userName + ") is already used, choose another one: ").ToString();

                User user = readUserInfo(userName);
                user.UserName = userName;

                manageUsersController.Post(user);

                Console.WriteLine();
                Console.WriteLine("User ({0}) Added Successfully", userName);

                PrintUser(user);

                goBack();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
