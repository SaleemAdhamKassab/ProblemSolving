using Lab.Bank.Controllers;
using Lab.Bank.Screens.ManageUsers;
using Lab.Bank.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Bank.Views.ManageUsers
{
    internal class Delete : FrontEndFunctions
    {
        public void DeleteUser()
        {
            try
            {
                ManageUsersController manageUsersController = new ManageUsersController();

                drawScreenHeader("Delete User");
                string userName = readOneInfo("Enter User Name: ").ToString();

                while (!manageUsersController.IsUserExsist(userName))
                    userName = readOneInfo("User Name (" + userName + ") is not found, choose another one: ").ToString();

                User UserToDelete = manageUsersController.Get(userName);
                PrintUser(UserToDelete);

                if (confirmationMessage("Are you sure to delete " + userName + " Y/N ?") == 'y')
                {
                    manageUsersController.Delete(userName);
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
