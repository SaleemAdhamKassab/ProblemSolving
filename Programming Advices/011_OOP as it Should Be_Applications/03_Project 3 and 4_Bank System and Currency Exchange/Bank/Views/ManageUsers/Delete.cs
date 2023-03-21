using Lab.Bank.Controllers;
using Lab.Bank.Models;
using Lab.Bank.Shared;

namespace Lab.Bank.Views.ManageUsers
{
    internal class Delete : FrontEndFunctions
    {
        public void DeleteUser()
        {
            try
            {
                ManageUsersController manageUsersController = new ManageUsersController();

                drawViewHeader("Delete User");
                string userName = readOneInfo("Enter User Name: ").ToString();

                while (!manageUsersController.IsUserExsist(userName))
                    userName = readOneInfo("User Name (" + userName + ") is not found, choose another one: ").ToString();

                User UserToDelete = manageUsersController.Get(userName);
                PrintUser(UserToDelete);

                if (confirmationMessage("Are you sure to delete " + userName + " Y/N ?") == 'y')
                {
                    manageUsersController.Delete(userName);
                    Console.WriteLine();
                    Console.WriteLine("User " + userName + " deleted Successfully");
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
