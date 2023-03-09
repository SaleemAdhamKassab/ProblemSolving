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
    internal class Update:FrontEndFunctions
    {
        public void UpdateUser()
        {
            try
            {
                ManageUsersController manageUsersController = new ManageUsersController();

                drawScreenHeader("Update User");
                string userName = readOneInfo("Enter User Name: ").ToString();

                while (!manageUsersController.IsUserExsist(userName))
                    userName = readOneInfo("User Name (" + userName + ") is not found, choose another one: ").ToString();

                User userToUpdate = manageUsersController.Get(userName);
                PrintUser(userToUpdate);


                if (confirmationMessage("Are you sure to Update User " + userName + " Y/N ?") == 'y')
                {
                    User updatedUser = readUserInfo(userName);
                    manageUsersController.Update(updatedUser);

                    Console.WriteLine();
                    Console.WriteLine("User ({0}) Updated Successfully", userName);
                    PrintUser(updatedUser);
                    
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
