using Lab.Bank.Controllers;
using Lab.Bank.Models;
using Lab.Bank.Shared;

namespace Lab.Bank.Views.ManageUsers
{
    internal class Find:FrontEndFunctions
    {
        public void FindUser()
        {
            try
            {
                ManageUsersController manageUsersController = new ManageUsersController();

                drawViewHeader("Find User");
                string userName = readOneInfo("Enter User Name: ").ToString();

                User user = manageUsersController.Get(userName);

                while (!manageUsersController.IsUserExsist(userName))
                    userName = readOneInfo("User Name (" + userName + ") is not found, choose another one: ").ToString();

                PrintUser(manageUsersController.Get(userName));

                goBack();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
