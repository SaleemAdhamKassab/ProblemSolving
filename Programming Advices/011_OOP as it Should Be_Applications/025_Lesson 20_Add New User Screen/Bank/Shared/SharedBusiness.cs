

using Lab.Class.Bank;
using Lab.Bank.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.Bank.Screens.ManageUsers;

namespace Lab.Bank.Shared
{
    public class SharedBusiness
    {
        protected static int clientsTotalBalances()
        {
            int totalBalances = 0;

            List<object> clientsList = FileDbContext.convertFileDataToList(FileDbContext.ClientsDbConnectionString,
                                                                           FileDbContext.FileRowSeparator,
                                                                           FileDbContext.enConvertLineToObjetTypes.Client);

            foreach (BankClient client in clientsList)
                totalBalances += int.Parse(client.AccountBalance.ToString());

            return totalBalances;
        }
        protected static void printMenueOptions(string[] menuOptions)
        {
            for (int i = 0; i < menuOptions.Length; i++)
                Console.WriteLine("[{0}] " + menuOptions[i], i + 1);
        }
        protected static int readUserMenuChoose(int to)
        {
            Console.Write("Choose What do you want to Do? [1 to {0}] :", to);
            return int.Parse(Console.ReadLine());
        }
        private static BankClient _getEmptyClientObject() => new BankClient("", "", "", "", "", "", 0);
        private static User _getEmptyUserObject() => new User("", "", "", "", "", "", 0);
        private static int _privilegeMethod(int number)
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
        private static int _grantUserPrivilege()
        {
            int privilegeNumber = 0;

            char userChoose = confirmationMessage("Do you want to give full access? Y/N: ");

            if (userChoose == 'y')
                return -1;

            string[] menueOptionss = mainMenueOptions();

            for (int i = 0; i < menueOptionss.Length - 1; i++)
            {
                userChoose = confirmationMessage("Do you want to give " + menueOptionss[i] + " access? Y/N: ");
                if (userChoose == 'y')
                    privilegeNumber += _privilegeMethod(i + 1);
            }

            return privilegeNumber == 127 ? -1 : privilegeNumber;
        }
        protected static string[] mainMenueOptions()
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
        public static object readOneInfo(string msg)
        {
            Console.Write(msg);
            return Console.ReadLine();
        }
        public static BankClient readClientInfo(string accountNumber = "") =>
           new BankClient(accountNumber == null ? readOneInfo("Enter Account Number: ").ToString() : accountNumber,
               readOneInfo("Enter Pin Code: ").ToString(),
               readOneInfo("Enter First Name: ").ToString(),
               readOneInfo("Enter Last Name: ").ToString(),
               readOneInfo("Enter Email: ").ToString(),
               readOneInfo("Enter Phone: ").ToString(),
               double.Parse(readOneInfo("Enter Account Balance: ").ToString()));
        public static User readUserInfo(string userName = "") =>
          new User(userName == null ? readOneInfo("Enter User Name: ").ToString() : userName,
              readOneInfo("Enter First Name: ").ToString(),
              readOneInfo("Enter Last Name: ").ToString(),
              readOneInfo("Enter Email: ").ToString(),
              readOneInfo("Enter Phone: ").ToString(),
              readOneInfo("Enter Password: ").ToString(),
              _grantUserPrivilege());
        public static BankClient findClient(string accountNumber, string pinCode = "")
        {
            BankClient client = _getEmptyClientObject();

            List<object> clientsList = FileDbContext.convertFileDataToList(FileDbContext.ClientsDbConnectionString,
                                                                           FileDbContext.FileRowSeparator,
                                                                           FileDbContext.enConvertLineToObjetTypes.Client);

            foreach (BankClient clientsLine in clientsList)
            {
                if (pinCode == "")
                {
                    if (clientsLine.AccountNumber == accountNumber)
                    {
                        client = clientsLine;
                        break;
                    }
                }
                else
                {
                    if (clientsLine.AccountNumber == accountNumber && clientsLine.PinCode == pinCode)
                    {
                        client = clientsLine;
                        break;
                    }
                }
            }

            return client;
        }
        public static User findUser(string userName)
        {
            User user = _getEmptyUserObject();

            List<object> usersList = FileDbContext.convertFileDataToList(FileDbContext.UsersDbConnectionString,
                                                                           FileDbContext.FileRowSeparator,
                                                                           FileDbContext.enConvertLineToObjetTypes.User);
            foreach (User userLine in usersList)
                if (userLine.UserName == userName)
                {
                    user = userLine;
                    return user;
                }

            return user;
        }
        public static bool IsClientExist(string accountNumber) => findClient(accountNumber).AccountNumber != "" ? false : true;
        public static bool IsUserExist(string userName) => findUser(userName).UserName == userName ? true : false;
        public static void goBack()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to go back Menue...");
            Console.ReadKey();
        }
        protected static string getBreakLine(string lineType, int rowLength = 30) => padRight(lineType, rowLength, char.Parse(lineType));
        public static void printBreakLine(string lineType, int rowLength = 30) => Console.WriteLine(getBreakLine(lineType, rowLength));
        public static string padRight(string word, int numberOfFiilingCells, char fillChar)
        {
            if (word.Length >= numberOfFiilingCells)
                return word;

            for (int i = word.Length; i < numberOfFiilingCells; i++)
                word += fillChar;

            return word;
        }
        public static char confirmationMessage(string msg)
        {
            Console.Write(msg);
            return char.Parse(Console.ReadLine().ToLower());
        }
        public static void PrintClient(BankClient client)
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
        public static int userMenuChoose(int to)
        {
            Console.Write("Choose What do you want to do [1 - {0}]: ", to);
            int userChoose = int.Parse(Console.ReadLine());

            while (userChoose < 1 || userChoose > to)
            {
                Console.Write("Invalid Menu Number, Please choose between 1 and {0}: ", to);
                userChoose = int.Parse(Console.ReadLine());
            }

            return userChoose;
        }
    }
}