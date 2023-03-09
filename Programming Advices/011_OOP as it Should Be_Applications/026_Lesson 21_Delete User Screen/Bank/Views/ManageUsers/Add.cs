using Lab.Bank.Controllers;
using Lab.Bank.Screens.ManageUsers;
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

                drawScreenHeader("Add New Client");

                string userName = readOneInfo("Enter User Name Number: ").ToString();

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


        //public static void AddNewUser()
        //{
        //    try
        //    {
        //        drawScreenHeader("Add New User");

        //        string userName = readOneInfo("Enter User Name: ").ToString()!;

        //        while (IsUserExist(userName))
        //            userName = readOneInfo("User Name (" + userName + ") is already used, choose another one: ").ToString();

        //        User user = readUserInfo(userName);
        //        user.UserName = userName;

        //        if (FileDbContext.saveRowToFile(FileDbContext.UsersDbConnectionString, FileDbContext.convertUserObjectToRowStringForSaving(user)))
        //        {
        //            Console.WriteLine();
        //            Console.WriteLine("User ({0}) Added Successfully", userName);
        //            PrintUser(user);
        //        }

        //        goBack();
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //    }
        //}
    }
}
