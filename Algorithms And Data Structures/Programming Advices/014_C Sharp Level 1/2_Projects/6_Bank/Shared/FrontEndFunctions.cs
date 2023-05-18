using Bank.Views;
using Lab.Bank.Models;
using Lab.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lab.Bank.Shared
{
    public class FrontEndFunctions
    {
        static User _getEmptyUserObject() => new User("", "", "", "", "", "", 0);
        void _printMenueOptions(string[] menueOptions)
        {
            for (int i = 0; i < menueOptions.Length; i++)
                Console.WriteLine("[{0}] {1}", i + 1, menueOptions[i]);
        }
        enum enPermissions
        {
            ListClients = 1, AddNewClient = 2, DeleteClient = 4,
            UpdateClients = 8, FindClient = 16, Tranactions = 32, ManageUsers = 64,
            ShowLogInRegister = 128, ShowCurrencyExchange = 256
        }
        int _grantUserPermissions()
        {
            int permissions = 0,
                mainMuenueIndex = 0;

            Console.WriteLine();
            char userChoose = readYesOrNoChoose("Do you want to give full access? Y/N: ");

            if (userChoose == 'y')
                return -1;

            Console.WriteLine();

            string[] menueOptions = mainMenueOptions();

            foreach (int permission in Enum.GetValues(typeof(enPermissions)))
            {
                userChoose = readYesOrNoChoose("Do you want to give " + menueOptions[mainMuenueIndex] + " access? Y/N: ");
                Console.WriteLine();
                if (Char.ToLower(userChoose) == 'y')
                    permissions += permission;

                mainMuenueIndex++;
            }

            return permissions == 510 ? -1 : permissions;
        }
        bool isDigit(char c)
        {
            switch (c)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    return true;
            }
            return false;
        }
        bool isNumber(string s)
        {
            for (int i = 0; i < s.Length; i++)
                if (!isDigit(s[i]))
                    return false;
            return true;
        }
        protected char readYesOrNoChoose(string msg)
        {
            Console.WriteLine();
            Console.Write(msg);
            string userChoose = Console.ReadLine();

            while (userChoose.ToLower() != "y" && userChoose.ToLower() != "n")
                userChoose = readOneInfo("Invalid Choose, Please Choose Y or N :").ToString();

            return char.Parse(userChoose);
        }
        protected int readIntNumber(string msg)
        {
            string userChoose = readOneInfo(msg).ToString();

            while (!isNumber(userChoose))
                userChoose = readOneInfo("Invalid Number!! Please Enter the Correct one: ").ToString();
            return int.Parse(userChoose);
        }
        protected double readDoubleNumber(string msg)
        {
            string userChoose = readOneInfo(msg).ToString();

            while (!isNumber(userChoose))
                userChoose = readOneInfo("Invalid Number!! Please Enter the Correct one: ").ToString();
            return double.Parse(userChoose);
        }

        protected static User currentUser = _getEmptyUserObject();
        protected Client readClientInfo(string accountNumber = "") =>
         new Client(accountNumber == null ? readOneInfo("Enter Account Number: ").ToString() : accountNumber,
             readOneInfo("Enter Pin Code: ").ToString(),
             readOneInfo("Enter First Name: ").ToString(),
             readOneInfo("Enter Last Name: ").ToString(),
             readOneInfo("Enter Email: ").ToString(),
             readOneInfo("Enter Phone: ").ToString(),
             readIntNumber("Enter Account Balance: "));
        protected User readUserInfo(string userName = "") =>
          new User(userName == null ? readOneInfo("Enter User Name: ").ToString() : userName,
              readOneInfo("Enter First Name: ").ToString(),
              readOneInfo("Enter Last Name: ").ToString(),
              readOneInfo("Enter Email: ").ToString(),
              readOneInfo("Enter Phone: ").ToString(),
              readOneInfo("Enter Password: ").ToString(),
              _grantUserPermissions());
        protected void logOut() => currentUser = _getEmptyUserObject();
        protected string[] mainMenueOptions()
        {
            string[] mainMenueOptions = new string[10];
            mainMenueOptions[0] = "Show Clients List";
            mainMenueOptions[1] = "Add New Client";
            mainMenueOptions[2] = "Delete Client";
            mainMenueOptions[3] = "Update Client Info";
            mainMenueOptions[4] = "Find Client";
            mainMenueOptions[5] = "Transactions";
            mainMenueOptions[6] = "Manage Users";
            mainMenueOptions[7] = "Login Register";
            mainMenueOptions[8] = "Currency Exchange";
            mainMenueOptions[9] = "Logout";

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
            Console.Write("Press any key to go back Menue...");
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
        protected int readUserMenueCorrectChoose(int to)
        {
            string userChoose = readOneInfo("Press number in range [1 to " + to + "] :").ToString();

            while (!isNumber(userChoose) || int.Parse(userChoose) < 1 || int.Parse(userChoose) > to)
                userChoose = readOneInfo("Invalid Choose, Press number in range [1 to " + to + "] :").ToString();

            return int.Parse(userChoose);
        }
        protected void drawMenueOptions(string[] menuOptions)
        {
            _printMenueOptions(menuOptions);
            Console.WriteLine();
            Console.WriteLine(getBreakLine('='));
            Console.WriteLine();
        }
        protected void drawViewHeader(string Title, string SubTitle = "")
        {
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine();
            if (currentUser.FirstName != "")
                Console.WriteLine("\tWelcome: {0} {1}", currentUser.FirstName, currentUser.LastName);

            Console.WriteLine("\t" + DateTime.Now.ToString());
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
            Console.WriteLine();
            Console.Write(msg);
            return Console.ReadLine();
        }
        protected char confirmationMessage(string msg)
        {
            Console.WriteLine();
            Console.Write(msg);
            return char.Parse(Console.ReadLine().ToLower());
        }
        protected void accessDenied()
        {
            Console.WriteLine();
            Console.WriteLine("Access Denied! Contact Your Admin.");
            goBack();
        }
        protected void printCurreny(clsCurrency currency, string header = "Curreny Card")
        {
            Console.WriteLine();
            Console.WriteLine(header + ":");
            Console.WriteLine(getBreakLine('_', 25));
            Console.WriteLine();
            Console.WriteLine("Country: {0}", currency.Country);
            Console.WriteLine("Code: {0}", currency.Code);
            Console.WriteLine("Name: {0}", currency.Name);
            Console.WriteLine("Rate(1$) = {0}", currency.ExchangeRateUSD);
            Console.WriteLine(getBreakLine('_', 25));
        }
        protected void printUsersListTableHeader(bool fromUsersLoginLog = false)
        {
            Console.WriteLine();

            if (fromUsersLoginLog)
                Console.Write(padRight("Log Date", 25, ' '));

            Console.WriteLine(
                padRight("First Name", 15, ' ') +
                padRight("Last Name", 15, ' ') +
                padRight("Email", 30, ' ') +
                padRight("Phone", 15, ' ') +
                padRight("UserName", 15, ' ') +
                padRight("Password", 15, ' ') +
                padRight("Permissions", 15, ' '));

            Console.WriteLine(getBreakLine('_', 150));
        }
        protected void printUserRow(User user)
        {
            Console.Write(padRight(user.FirstName, 15, ' '));
            Console.Write(padRight(user.LastName, 15, ' '));
            Console.Write(padRight(user.Email, 30, ' '));
            Console.Write(padRight(user.Phone, 15, ' '));
            Console.Write(padRight(user.UserName, 15, ' '));
            Console.Write(padRight(user.Password, 15, ' '));
            Console.Write(padRight(user.Permissions.ToString(), 15, ' '));
            Console.WriteLine();
        }
        public void PrintClient(Client client)
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
        public void PrintUser(User user)
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




        /////////////////////// LIST VIEW SHARED ////////////////////////
        public void txtSearch_KeyUp(object sender, KeyEventArgs e,
                             ListView listView,
                             List<object> objects,
                             TextBox textBox,
                             Label lbl,
                             string searchType,
                             bool toToalBalancec = false)
        {
            List<object> searchedObjects = new List<object>();
            listView.Items.Clear();

            if (searchType == "clients")
            {

                foreach (Client client in objects)
                    if (client.AccountNumber.ToLower().Contains(textBox.Text.Trim().ToLower()))
                        searchedObjects.Add(client);
            }
            else if (searchType == "transferLog")
            {
                foreach (ClientsTransferLog clientsTransferLog in objects)
                    if (clientsTransferLog.AccountNumber.ToLower().Contains(textBox.Text.Trim().ToLower()))
                        searchedObjects.Add(clientsTransferLog);
            }
            else if (searchType == "users")
            {
                foreach (User user in objects)
                    if (user.UserName.ToLower().Contains(textBox.Text.Trim().ToLower()))
                        searchedObjects.Add(user);
            }
            else if (searchType == "loginRegister")
            {
                foreach (UsersLoginLog usersLoginLog in objects)
                    if (usersLoginLog.UserName.ToLower().Contains(textBox.Text.Trim().ToLower()))
                        searchedObjects.Add(usersLoginLog);
            }
            else if (searchType == "currencyExchange")
            {
                foreach (clsCurrency currency in objects)
                    if (currency.Code.ToLower().Contains(textBox.Text.Trim().ToLower()) || currency.Country.ToLower().Contains(textBox.Text.Trim().ToLower()))
                        searchedObjects.Add(currency);
            }

            fillListView(searchedObjects, listView, lbl, searchType, toToalBalancec);
        }
        public void fillListView(List<object> objects,
                                       ListView listView,
                                       Label lbl,
                                       string searchType,
                                       bool isLstTotalBalances = false)
        {
            listView.Items.Clear();

            if (searchType == "clients")
            {
                foreach (Client client in objects)
                {
                    ListViewItem clientItem = getClientViewItem(client, isLstTotalBalances);
                    listView.Items.Add(clientItem);
                }
            }
            else if (searchType == "transferLog")
            {
                foreach (ClientsTransferLog clientsTransferLog in objects)
                {
                    ListViewItem clientTransferItem = getTransferLogViewItem(clientsTransferLog);
                    listView.Items.Add(clientTransferItem);
                }
            }
            else if (searchType == "users")
            {
                foreach (User user in objects)
                {
                    ListViewItem userItem = getUserViewItem(user);
                    listView.Items.Add(userItem);
                }
            }
            else if (searchType == "loginRegister")
            {
                foreach (UsersLoginLog usersLoginLog in objects)
                {
                    ListViewItem userItem = getloginRegisterViewItem(usersLoginLog);
                    listView.Items.Add(userItem);
                }
            }
            else if (searchType == "currencyExchange")
            {
                foreach (clsCurrency currency in objects)
                {
                    ListViewItem userItem = getCurrencyExchangeViewItem(currency);
                    listView.Items.Add(userItem);
                }
            }

            if (searchType == "currencyExchange")
                lbl.Text = objects.Count().ToString() + " Currency (s)";
            else
                lbl.Text = objects.Count().ToString() + " Client (s)";

            lbl.Text += (" Found");

            listViewRowsBackcolor(listView);
        }
        public void lstViewSort(object sender, EventArgs e,
                                        ListView listView,
                                        SortOrder type = SortOrder.Ascending)
        {
            listView.Sorting = type;
            listViewRowsBackcolor(listView);
        }
        public void listViewRowsBackcolor(ListView listView)
        {
            int i = 0;
            foreach (ListViewItem lvw in listView.Items)
            {
                if (i % 2 == 0)
                    lvw.BackColor = Color.LightBlue;
                else
                    lvw.BackColor = Color.AliceBlue;
                i++;
            }
        }

        public ListViewItem getClientViewItem(Client client,
                                              bool toTotalBalancesList = false)
        {
            ListViewItem clientItem = new ListViewItem(client.AccountNumber);

            if (toTotalBalancesList)
            {
                clientItem.SubItems.Add(client.FirstName);
                clientItem.SubItems.Add(client.AccountBalance.ToString());
            }
            else
            {
                clientItem.SubItems.Add(client.PinCode);
                clientItem.SubItems.Add(client.FirstName);
                clientItem.SubItems.Add(client.LastName);
                clientItem.SubItems.Add(client.Email);
                clientItem.SubItems.Add(client.Phone);
                clientItem.SubItems.Add(client.AccountBalance.ToString());
            }

            return clientItem;
        }
        public ListViewItem getTransferLogViewItem(ClientsTransferLog clientsTransferLog)
        {
            ListViewItem clientTransferLogItem = new ListViewItem(clientsTransferLog.TransferDate);

            clientTransferLogItem.SubItems.Add(clientsTransferLog.AccountNumber);
            clientTransferLogItem.SubItems.Add(clientsTransferLog.ToAccountNumber);
            clientTransferLogItem.SubItems.Add(clientsTransferLog.TransferAmount.ToString());
            clientTransferLogItem.SubItems.Add(clientsTransferLog.AccountBalanceAfterTransfer.ToString());
            clientTransferLogItem.SubItems.Add(clientsTransferLog.DestinationBalanceAfterTransfer.ToString());
            clientTransferLogItem.SubItems.Add(clientsTransferLog.Name);

            return clientTransferLogItem;
        }
        public ListViewItem getUserViewItem(User user)
        {
            ListViewItem userItem = new ListViewItem(user.UserName);

            userItem.SubItems.Add(user.FirstName);
            userItem.SubItems.Add(user.LastName);
            userItem.SubItems.Add(user.Email);
            userItem.SubItems.Add(user.Phone);
            userItem.SubItems.Add(user.Password);
            userItem.SubItems.Add(user.Permissions.ToString());

            return userItem;
        }
        public ListViewItem getloginRegisterViewItem(UsersLoginLog usersLoginLog)
        {
            ListViewItem loginRegisterItem = new ListViewItem(usersLoginLog.UserName);

            loginRegisterItem.SubItems.Add(usersLoginLog.LogDate);
            loginRegisterItem.SubItems.Add(usersLoginLog.FirstName);
            loginRegisterItem.SubItems.Add(usersLoginLog.LastName);
            loginRegisterItem.SubItems.Add(usersLoginLog.Email);
            loginRegisterItem.SubItems.Add(usersLoginLog.Phone);
            loginRegisterItem.SubItems.Add(usersLoginLog.Password);
            loginRegisterItem.SubItems.Add(usersLoginLog.Permissions.ToString());


            return loginRegisterItem;
        }
        public ListViewItem getCurrencyExchangeViewItem(clsCurrency currency)
        {
            ListViewItem currencyItem = new ListViewItem(currency.Code);

            currencyItem.SubItems.Add(currency.Country);
            currencyItem.SubItems.Add(currency.Name);
            currencyItem.SubItems.Add(currency.ExchangeRateUSD.ToString());


            return currencyItem;
        }
    }
}
