using Lab.Bank.Screens.ManageUsers;
using Lab.Class.Bank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Bank.Shared
{
    public class FrontEndFunctions
    {
        private void _printMenuOptions(string[] menueOptions)
        {
            for (int i = 0; i < menueOptions.Length; i++)
                Console.WriteLine("[{0}] {1}", i + 1, menueOptions[i]);
        }
        private int _privilegeMethod(int number)
        {
            switch (number)
            {
                case 1:
                    return 1;
                case 2:
                    return 2;
                case 3:
                    return 4;
                case 4:
                    return 8;
                case 5:
                    return 16;
                case 6:
                    return 32;
                case 7:
                    return 64;
                default:
                    return 0;
            }
        }
        private int _grantUserPrivilege()
        {
            int privilegeNumber = 0;

            char userChoose = confirmationMessage("Do you want to give full access? Y/N: ");

            if (userChoose == 'y')
                return -1;

            string[] menueOptions = mainMenueOptions();

            for (int i = 0; i < menueOptions.Length - 1; i++)
            {
                userChoose = confirmationMessage("Do you want to give " + menueOptions[i] + " access? Y/N: ");
                if (userChoose == 'y')
                    privilegeNumber += _privilegeMethod(i + 1);
            }

            return privilegeNumber == 127 ? -1 : privilegeNumber;
        }
        protected string[] mainMenueOptions()
        {
            string[] mainMenueOptions = new string[8];
            mainMenueOptions[0] = "Show Clients List";
            mainMenueOptions[1] = "Add New Client";
            mainMenueOptions[2] = "Delete Client";
            mainMenueOptions[3] = "Update Client Info";
            mainMenueOptions[4] = "Find Client";
            mainMenueOptions[5] = "Transactions";
            mainMenueOptions[6] = "Manage Users";
            mainMenueOptions[7] = "Logout";

            return mainMenueOptions;
        }
        protected string getBreakLine(char lineType, int rowLength = 50)
        {
            string breakLine = "";

            for (int i = 0; i < rowLength; i++)
                breakLine += lineType;
            return breakLine;
        }
        protected void goBack()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to go back Menue...");
            Console.ReadKey();
        }
        protected string padRight(string word, int numberOfFiilingCells, char fillChar)
        {
            if (word.Length >= numberOfFiilingCells)
                return word;

            for (int i = word.Length; i < numberOfFiilingCells; i++)
                word += fillChar;

            return word;
        }
        protected int readUserMenuCorrectChoose(int to)
        {
            int userChoose = 0;
            userChoose = int.Parse(readOneInfo("Choose What do you want to Do [1 to " + to + "] :").ToString());

            while (userChoose < 1 || userChoose > to)
                userChoose = int.Parse(readOneInfo("Invalid Choose, Press number in range [1 to " + to + "] :").ToString());


            return userChoose;
        }
        protected void drawMenuOptions(string[] menuOptions)
        {
            _printMenuOptions(menuOptions);
            Console.WriteLine();
            getBreakLine('=');
            Console.WriteLine();
        }
        protected void drawScreenHeader(string Title, string SubTitle = "")
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(getBreakLine('*'));
            Console.WriteLine("\t" + Title);
            if (SubTitle != "")
                Console.WriteLine("\t" + SubTitle);
            Console.WriteLine(getBreakLine('*'));
            Console.WriteLine();
        }
        protected object readOneInfo(string msg)
        {
            Console.Write(msg);
            return Console.ReadLine();
        }
        protected Client readClientInfo(string accountNumber = "") =>
           new Client(accountNumber == null ? readOneInfo("Enter Account Number: ").ToString() : accountNumber,
               readOneInfo("Enter Pin Code: ").ToString(),
               readOneInfo("Enter First Name: ").ToString(),
               readOneInfo("Enter Last Name: ").ToString(),
               readOneInfo("Enter Email: ").ToString(),
               readOneInfo("Enter Phone: ").ToString(),
               int.Parse(readOneInfo("Enter Account Balance: ").ToString()));
        protected User readUserInfo(string userName = "") =>
          new User(userName == null ? readOneInfo("Enter User Name: ").ToString() : userName,
              readOneInfo("Enter First Name: ").ToString(),
              readOneInfo("Enter Last Name: ").ToString(),
              readOneInfo("Enter Email: ").ToString(),
              readOneInfo("Enter Phone: ").ToString(),
              readOneInfo("Enter Password: ").ToString(),
              _grantUserPrivilege());
        protected char confirmationMessage(string msg)
        {
            Console.WriteLine();
            Console.Write(msg);
            return char.Parse(Console.ReadLine().ToLower());
        }
        protected void accessDenied()
        {
            Console.WriteLine("printAccessDeniedPage()");
            goBack();
        }
        public static void PrintClient(Client client)
        {
            Console.WriteLine();
            Console.WriteLine("Client Card: ");
            Console.WriteLine("____________________________________");
            Console.WriteLine("Acc. Number : {0}", client.AccountNumber);
            Console.WriteLine("Pin Code : {0}", client.PinCode);
            Console.WriteLine("First Name : {0}", client.FirstName);
            Console.WriteLine("Last Name : {0}", client.LastName);
            Console.WriteLine("Email : {0}", client.Email);
            Console.WriteLine("Phone : {0}", client.Phone);
            Console.WriteLine("Balance : {0}", client.AccountBalance);
            Console.WriteLine("____________________________________");
            Console.WriteLine();
        }
        public static void PrintUser(User user)
        {
            Console.WriteLine();
            Console.WriteLine("User Card: ");
            Console.WriteLine("____________________________________");
            Console.WriteLine("First Name : {0}", user.FirstName);
            Console.WriteLine("Last Name : {0}", user.LastName);
            Console.WriteLine("Email : {0}", user.Email);
            Console.WriteLine("Phone : {0}", user.Phone);
            Console.WriteLine("User Name : {0}", user.UserName);
            Console.WriteLine("Password : {0}", user.Password);
            Console.WriteLine("Permissions : {0}", user.Permissions);
            Console.WriteLine("____________________________________");
        }
    }
}
