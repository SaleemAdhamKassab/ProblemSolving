using Lab.Bank.Controllers;
using Lab.Bank.Models;
using Lab.Bank.Shared;
using Lab.Bank.Views.Clients;

namespace Lab.Bank.Views
{
    internal class Login : FrontEndFunctions
    {
        User _readUserCredentials(User user)
        {
            user.UserName = readOneInfo("User Name: ").ToString();
            user.Password = readOneInfo("Password: ").ToString();
            return user;
        }
        public void login()
        {
            bool isValidUser = false;
            int loginAttempts = 1;
            ManageUsersController manageUsersController = new ManageUsersController();
            StartBank startBank = new StartBank();
            User emptyUser = manageUsersController.getEmptyUserObject();

            drawViewHeader("Welcome to our bank", "  Please Login");

            User userCredentials = _readUserCredentials(emptyUser);

            isValidUser = manageUsersController.isValidUserNameAndPassword(userCredentials.UserName, userCredentials.Password);

            while (loginAttempts < 3 && !isValidUser)
            {
                loginAttempts++;
                Console.WriteLine();
                Console.WriteLine("Inavlid User Name Or Password!!");
                Console.WriteLine("You have only {0} Attempt(s) Before Lock Your Account", 4 - loginAttempts);
                Console.WriteLine();
                userCredentials = _readUserCredentials(emptyUser);
                isValidUser = manageUsersController.isValidUserNameAndPassword(userCredentials.UserName, userCredentials.Password);
            }

            if (loginAttempts == 3)
            {
                Console.WriteLine();
                Console.WriteLine("You Are Locked after 3 Faild Trails!!");
                Console.WriteLine("Contact to Admins!!");
            }
            else
            {
                User user = manageUsersController.Get(userCredentials.UserName);
                manageUsersController.addLoginLog(user);
                currentUser = user;
                startBank.Start();
            }
        }
    }
}