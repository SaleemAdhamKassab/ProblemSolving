using Lab.Class.Bank;

namespace lab
{
    class Program
    {
        static void Main()
        {
            //login();
            BankClient.Update();

        }

        //Shared Logic
        static string filePath = "ClientsDB.txt";
        static string usersFilePath = "UsersDB.txt";
        static int usersessionPrivelege = 0;
        struct strClientInfo
        {
            public int PinCode;
            public double AccountBalance;
            public string AccountNumber, Name, Phone;
        }
        struct strUser
        {
            public string UserName, Password;
            public int privilege;
        }
        static strClientInfo readClientInfo()
        {
            Console.WriteLine("Please Enter Client Data: ");
            Console.WriteLine();

            strClientInfo clientInfo = new strClientInfo();

            Console.Write("Enter Account Number:");
            clientInfo.AccountNumber = Console.ReadLine();

            Console.Write("Enter Pin Code:");
            clientInfo.PinCode = int.Parse(Console.ReadLine());

            Console.Write("Enter Name:");
            clientInfo.Name = Console.ReadLine();

            Console.Write("Enter Phone:");
            clientInfo.Phone = Console.ReadLine();

            Console.Write("Enter Account Balance:");
            clientInfo.AccountBalance = double.Parse(Console.ReadLine());

            return clientInfo;
        }
        static strUser readUser()
        {
            strUser user = new strUser();

            Console.Write("Enter User Name:");
            user.UserName = Console.ReadLine();

            Console.Write("Enter Password:");
            user.Password = Console.ReadLine();

            user.privilege = 0;

            return user;
        }
        static int readUserChoose(bool isMainMenue = true)
        {
            int to = 6;

            if (!isMainMenue)
                to = 4;

            Console.Write("Choose What do you want to Do? [1 to {0}] :", to);
            return int.Parse(Console.ReadLine());
        }
        static double readDepositAmount(string message)
        {
            Console.Write(message);
            return double.Parse(Console.ReadLine());
        }
        static string readClientAccountNumber()
        {
            Console.Write("Please Enter Account Number :");
            return Console.ReadLine();
        }
        static string readUserName()
        {
            Console.Write("Please Enter User Name:");
            return Console.ReadLine();
        }
        static void goBack()
        {
            Console.WriteLine("Press any key to go back Menue...");
            Console.ReadKey();
        }
        static string clientRecordForSaving(strClientInfo clientInfo)
        {
            return
                clientInfo.AccountNumber + "#//#" +
                clientInfo.PinCode + "#//#" +
                clientInfo.Name + "#//#" +
                clientInfo.Phone + "#//#" +
                clientInfo.AccountBalance;
        }
        static string userRecordForSaving(strUser user)
        {
            return
                user.UserName + "#//#" +
                user.Password + "#//#" +
                user.privilege;
        }
        static bool saveClientToFile(string clientRecordForSaving)
        {
            try
            {
                StreamWriter file = new StreamWriter(filePath, append: true);
                file.WriteLine(clientRecordForSaving);
                file.Close();
                return true;
            }
            catch
            {
                return false;
            }

        }
        static bool saveUserToFile(string userRecordForSaving)
        {
            try
            {
                StreamWriter file = new StreamWriter(usersFilePath, append: true);
                file.WriteLine(userRecordForSaving);
                file.Close();
                return true;
            }
            catch
            {
                return false;
            }

        }
        static bool saveListToFile(List<strClientInfo> clientsList)
        {
            try
            {
                StreamWriter file = new StreamWriter(filePath);

                if (clientsList.Count == 0)
                {
                    file.Write("");
                    return true;
                }

                foreach (strClientInfo client in clientsList)
                {

                    file.WriteLine(clientRecordForSaving(client));
                    file.Close();
                }
                return true;
            }
            catch
            {
                return false;
            }

        }
        static bool saveUsersListToFile(List<strUser> usersList)
        {
            try
            {
                StreamWriter file = new StreamWriter(usersFilePath);

                if (usersList.Count == 0)
                {
                    file.Write("");
                    return true;
                }

                foreach (strUser user in usersList)
                {

                    file.WriteLine(userRecordForSaving(user));
                    file.Close();
                }
                return true;
            }
            catch
            {
                return false;
            }

        }
        static List<strClientInfo> loadClientsFromFileToList(string filePath, string seperator)
        {
            List<strClientInfo> clientsList = new List<strClientInfo>();

            foreach (string lineData in File.ReadLines(filePath))
            {
                clientsList.Add(convertLineDataToRecord(lineData, seperator));
            }

            return clientsList;
        }
        static List<strUser> loadUsersFromFileToList(string filePath, string seperator)
        {
            List<strUser> usersList = new List<strUser>();

            foreach (string line in File.ReadLines(filePath))
            {
                usersList.Add(convertUserLineToStruct(line, seperator));
            }

            return usersList;
        }
        static strClientInfo convertLineDataToRecord(string lineData, string seperator)
        {
            string[] splitedLineData = splitString(lineData, seperator);

            strClientInfo clientInfo = new strClientInfo();

            clientInfo.AccountNumber = splitedLineData[0];
            clientInfo.PinCode = int.Parse(splitedLineData[1]);
            clientInfo.Name = splitedLineData[2];
            clientInfo.Phone = splitedLineData[3];
            clientInfo.AccountBalance = double.Parse(splitedLineData[4]);

            return clientInfo;

        }
        static strUser convertUserLineToStruct(string lineData, string seperator)
        {
            string[] splitedLineData = splitString(lineData, seperator);

            strUser strUsers = new strUser();

            strUsers.UserName = splitedLineData[0];
            strUsers.Password = splitedLineData[1];
            strUsers.privilege = int.Parse(splitedLineData[2]);

            return strUsers;

        }
        static string[] splitString(string s, string delimeter)
        {
            List<string> result = new List<string>();

            while (s.IndexOf(delimeter) > -1)
            {
                result.Add(s.Substring(0, s.IndexOf(delimeter)).Trim());
                s = s.Remove(0, s.IndexOf(delimeter) + delimeter.Length);
            }
            result.Add(s.Trim());
            return result.ToArray();
        }
        static bool isClientExsist(string clientAccountNumber)
        {
            List<strClientInfo> clientsList = loadClientsFromFileToList(filePath, "#//#");

            foreach (strClientInfo strClientInfo in clientsList)
                if (strClientInfo.AccountNumber == clientAccountNumber)
                    return true;

            return false;
        }
        static bool isUserExsist(string userName)
        {
            List<strUser> usersList = loadUsersFromFileToList(usersFilePath, "#//#");

            foreach (strUser user in usersList)
                if (user.UserName == userName)
                    return true;

            return false;
        }
        static void printTableHeader(int fileRwosCount)
        {
            string header = "Client List (" + fileRwosCount + ") Client(s).";
            Console.SetCursorPosition((Console.WindowWidth - header.Length) / 2, Console.CursorTop);
            Console.WriteLine(header);

            printBreakLine("_");
            Console.WriteLine();
            Console.WriteLine(
                padRight("Account Number", 20, ' ') +
                padRight("Pin Code", 20, ' ') +
                padRight("Client Name", 20, ' ') +
                padRight("Phone", 20, ' ') +
                padRight("Balance", 20, ' '));

            printBreakLine("_");
            Console.WriteLine();
        }
        static void printUserTableHeader()
        {
            string header = "User Details.";
            Console.SetCursorPosition((Console.WindowWidth - header.Length) / 2, Console.CursorTop);
            Console.WriteLine(header);

            printBreakLine("_");
            Console.WriteLine();
            Console.WriteLine(
                padRight("User Name", 20, ' ') +
                padRight("Password", 20, ' ') +
                padRight("Privilege", 20, ' '));

            printBreakLine("_");
            Console.WriteLine();
        }
        static void printUsersListHeader(int fileRwosCount)
        {
            string header = "Users List (" + fileRwosCount + ") Users(s).";
            Console.SetCursorPosition((Console.WindowWidth - header.Length) / 2, Console.CursorTop);
            Console.WriteLine(header);

            printBreakLine("_");
            Console.WriteLine();
            Console.WriteLine(
                padRight("User Name", 20, ' ') +
                padRight("Password", 20, ' ') +
                padRight("Privilege", 20, ' '));

            printBreakLine("_");
            Console.WriteLine();
        }
        static string padRight(string word, int numberOfFiilingCells, char fillChar)
        {
            if (word.Length >= numberOfFiilingCells)
                return word;

            for (int i = word.Length; i < numberOfFiilingCells; i++)
                word += fillChar;

            return word;
        }
        static void printBreakLine(string lineType) => Console.WriteLine(padRight(lineType, 99, char.Parse(lineType)));
        static void printClientData(strClientInfo client)
        {
            Console.Write(padRight(client.AccountNumber, 20, ' '));
            Console.Write(padRight(client.PinCode.ToString(), 20, ' '));
            Console.Write(padRight(client.Name, 20, ' '));
            Console.Write(padRight(client.Phone, 20, ' '));
            Console.Write(padRight(client.AccountBalance.ToString(), 20, ' '));
            Console.WriteLine();
        }
        static void printUserData(strUser user)
        {
            Console.Write(padRight(user.UserName, 20, ' '));
            Console.Write(padRight(user.Password.ToString(), 20, ' '));
            Console.Write(padRight(user.privilege.ToString(), 20, ' '));

            Console.WriteLine();
        }
        static void printUsersData(strUser user)
        {
            Console.Write(padRight(user.UserName, 20, ' '));
            Console.Write(padRight(user.Password.ToString(), 20, ' '));
            Console.Write(padRight(user.privilege.ToString(), 20, ' '));
            Console.WriteLine();
        }

        //CRUD Operations
        static strClientInfo getClient(string accountNumber)
        {
            strClientInfo client = new strClientInfo();
            List<strClientInfo> clientsList = loadClientsFromFileToList(filePath, "#//#");

            foreach (strClientInfo clientsLine in clientsList)
                if (clientsLine.AccountNumber == accountNumber)
                {
                    client = clientsLine;
                    break;
                }
            return client;
        }
        static strUser getUser(string userName)
        {
            strUser user = new strUser();
            List<strUser> usersList = loadUsersFromFileToList(usersFilePath, "#//#");

            foreach (strUser userLine in usersList)
                if (userLine.UserName == userName)
                {
                    user = userLine;
                    break;
                }
            return user;
        }
        static void printClient(string accountNumber)
        {
            printTableHeader(1);
            strClientInfo client = getClient(accountNumber);
            printClientData(client);
        }
        static void printClients()
        {
            List<strClientInfo> clientsList = loadClientsFromFileToList(filePath, "#//#");
            printTableHeader(clientsList.Count);

            foreach (strClientInfo client in clientsList)
                printClientData(client);

            Console.WriteLine();
            printBreakLine("_");
        }
        static bool addNewClient()
        {
            try
            {
                strClientInfo client = readClientInfo();


                if (isClientExsist(client.AccountNumber))
                {
                    Console.WriteLine("The Account Number ({0}) is used by another Client!", client.AccountNumber);
                    return false;
                }
                else
                {
                    saveClientToFile(clientRecordForSaving(client));
                    return true;
                }
            }
            catch
            {
                return false;
            }

        }

        static bool deleteClient(string accountNumber)
        {
            try
            {
                if (isClientExsist(accountNumber))
                {
                    List<strClientInfo> clientsList = loadClientsFromFileToList(filePath, "#//#");

                    List<strClientInfo> clientsListAfterDeleteTheClient = new List<strClientInfo>();

                    foreach (strClientInfo client in clientsList)
                    {
                        if (client.AccountNumber != accountNumber)
                        {
                            clientsListAfterDeleteTheClient.Add(client);
                        }
                    }

                    saveListToFile(clientsListAfterDeleteTheClient);
                    return true;
                }
                else
                {
                    Console.WriteLine("The Account Number ({0}) is Not Exsists!", accountNumber);
                    return false;
                }
            }
            catch
            {
                return false;
            }

        }
        static bool updateClient(string accountNumber)
        {
            try
            {
                if (isClientExsist(accountNumber))
                {
                    deleteClient(accountNumber);
                    addNewClient();
                    return true;
                }
                else
                {
                    Console.WriteLine("The Account Number ({0}) is Not Exsists!", accountNumber);
                    return false;
                }
            }
            catch
            {
                return false;
            }

        }

        // Bank Requirments
        static string[] mainMenueOptions()
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
        static string[] TransactionsMenueOptions()
        {
            string[] mainMenueOptions = new string[4];
            mainMenueOptions[0] = "Deposit.";
            mainMenueOptions[1] = "Withdraw.";
            mainMenueOptions[2] = "Total Balance.";
            mainMenueOptions[3] = "Main Menue.";

            return mainMenueOptions;
        }
        static void printMainMenue()
        {
            string mainMenue = "Main Menue Screen";
            string[] menueOptions = mainMenueOptions();

            Console.SetCursorPosition((Console.WindowWidth - mainMenue.Length) / 2, Console.CursorTop);

            Console.WriteLine(mainMenue);
            printBreakLine("=");

            for (int i = 0; i < menueOptions.Length; i++)
            {
                Console.WriteLine("[{0}] " + menueOptions[i], i + 1);
            }
            printBreakLine("=");
        }
        static void printTransactionsMenue()
        {
            string mainMenue = "Transactions Menue Screen";
            string[] menueOptions = TransactionsMenueOptions();

            Console.SetCursorPosition((Console.WindowWidth - mainMenue.Length) / 2, Console.CursorTop);

            Console.WriteLine(mainMenue);
            printBreakLine("=");

            for (int i = 0; i < menueOptions.Length; i++)
            {
                Console.WriteLine("[{0}] " + menueOptions[i], i + 1);
            }
            printBreakLine("=");
        }

        // Bank Extecnsion Requirments
        static double calcTotalBalances()
        {
            double totalBalances = 0;
            List<strClientInfo> clientsList = loadClientsFromFileToList(filePath, "#//#");

            for (int i = 0; i < clientsList.Count; i++)
                totalBalances += clientsList[i].AccountBalance;

            return totalBalances;

        }
        static void deposit(string accountNumber)
        {
            strClientInfo client = getClient(accountNumber);

            if (client.AccountNumber != null)
            {
                printClient(accountNumber);

                double depositAmount = readDepositAmount("Please Enter Deposit Amount :");

                Console.Write("Are you sure to perfoem this transaction? Y/N :");

                if (Console.ReadLine().ToLower() == "y")
                {
                    client.AccountBalance += depositAmount;
                    deleteClient(accountNumber);
                    saveClientToFile(clientRecordForSaving(client));
                    Console.WriteLine("Done Successfully, The New Balance Amount is: {0}", client.AccountBalance);
                }
                else
                {
                    Console.WriteLine("canceled");
                }

            }
            else
            {
                Console.WriteLine("Invalid Account Number!");
            }
        }
        static void withDraw(string accountNumber)
        {
            strClientInfo client = getClient(accountNumber);

            if (client.AccountNumber != null)
            {
                printClient(accountNumber);

                double WithDrawAmount = readDepositAmount("Please Enter WithDraw Amount :");

                if (WithDrawAmount <= client.AccountBalance)
                {
                    Console.Write("Are you sure to perfoem this transaction? Y/N :");

                    if (Console.ReadLine().ToLower() == "y")
                    {
                        client.AccountBalance -= WithDrawAmount;
                        deleteClient(accountNumber);
                        saveClientToFile(clientRecordForSaving(client));
                        Console.WriteLine("Done Successfully, The New Balance Amount is: {0}", client.AccountBalance);
                    }
                    else
                    {
                        Console.WriteLine("canceled");
                    }

                }
                else
                {
                    Console.WriteLine("Amount Exceeds the balance, you can withdraw up to {0}.", client.AccountBalance);
                }

            }
            else
            {
                Console.WriteLine("Invalid Account Number!");
            }
        }

        static void balancesList()
        {
            double totalBalances = calcTotalBalances();
            printClients();
            Console.WriteLine("Total Balances = {0}", totalBalances);
            Console.WriteLine();
        }
        static void transactions()
        {
            int userChoose = 0;

            do
            {
                Console.Clear();
                printTransactionsMenue();
                userChoose = readUserChoose(false);

                switch (userChoose)
                {
                    case 1:
                        //Console.WriteLine("Deposit");
                        deposit(readClientAccountNumber());

                        goBack();
                        break;
                    case 2:
                        //Console.WriteLine("Withdraw");
                        withDraw(readClientAccountNumber());
                        goBack();
                        break;
                    case 3:
                        //Console.WriteLine("Total Balances.");
                        balancesList();
                        goBack();
                        break;
                    case 4:
                        Console.Clear();
                        startBank();
                        break;
                    default:
                        break;

                }
            } while (userChoose != 4);
        }

        //Bank Extenssion2 (Manage Users)
        static void printManageUsersMenue()
        {
            string manageUsersMenue = "Manage Users Screen";
            string[] usersOptions = manageUsersOptions();

            Console.SetCursorPosition((Console.WindowWidth - manageUsersMenue.Length) / 2, Console.CursorTop);

            Console.WriteLine(manageUsersMenue);
            printBreakLine("=");

            for (int i = 0; i < usersOptions.Length; i++)
            {
                Console.WriteLine("[{0}] " + usersOptions[i], i + 1);
            }
            printBreakLine("=");
        }
        static void printAccessDeniedPage()
        {

            printBreakLine("=");
            Console.WriteLine("Access Denied,");
            Console.WriteLine("You dont Have Permission to do this,");
            Console.WriteLine("Pleae Contact your Admin.");
            printBreakLine("=");
        }
        static string[] manageUsersOptions()
        {
            string[] options = new string[6];
            options[0] = "List Users";
            options[1] = "Add New User";
            options[2] = "Delete User";
            options[3] = "Update User";
            options[4] = "Find User";
            options[5] = "Main Menue";

            return options;

        }
        static void goToManageUsers()
        {
            Console.WriteLine("Press any key to go back to Manage Users...");
            Console.ReadKey();
            manageUsers();
        }
        static int getUserPrivilege(string userName) => getUser(userName).privilege;

        //1)List Users
        static void printUsers()
        {

            List<strUser> usersList = loadUsersFromFileToList(usersFilePath, "#//#");
            printUsersListHeader(usersList.Count);

            foreach (strUser user in usersList)
                printUsersData(user);

            Console.WriteLine();
            printBreakLine("_");
        }
        //2) Add New User
        static int grantUserPrivilege()
        {
            int privilegeNumber = 0;

            Console.Write("Do you want to give full access? y/n: ");
            char userChoose = char.Parse(Console.ReadLine());

            if (userChoose == 'y')
            {
                return -1;
            }

            Console.WriteLine("Do you want to give access to: ");
            string[] menueOptionss = mainMenueOptions();

            for (int i = 0; i < menueOptionss.Length - 1; i++)
            {
                Console.Write(menueOptionss[i] + "  y/n: ");
                userChoose = char.Parse(Console.ReadLine());

                if (userChoose == 'y')
                    privilegeNumber += privilegeMethod(i + 1);
            }
            return privilegeNumber == 127 ? -1 : privilegeNumber;

        }
        static int privilegeMethod(int number)
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
        static bool addNewUser()
        {
            try
            {
                strUser user = readUser();

                if (isUserExsist(user.UserName))
                {
                    Console.WriteLine("The user Already Exsist!");
                    return false;
                }
                else
                {

                    user.privilege = grantUserPrivilege();

                    saveUserToFile(userRecordForSaving(user));
                    return true;
                }
            }
            catch
            {
                return false;
            }

        }
        //3) Delete User
        static bool deleteUser(string userName)
        {
            if (userName == "Admin")
            {
                Console.WriteLine("You Cannot delete This User!");
                return false;
            }
            try
            {
                if (isUserExsist(userName))
                {
                    List<strUser> usersList = loadUsersFromFileToList(usersFilePath, "#//#");

                    List<strUser> usersListAfterDeleteTheUser = new List<strUser>();

                    foreach (strUser user in usersList)
                    {
                        if (user.UserName != userName)
                        {
                            usersListAfterDeleteTheUser.Add(user);
                        }
                    }

                    saveUsersListToFile(usersListAfterDeleteTheUser);
                    return true;
                }
                else
                {
                    Console.WriteLine("The User Name ({0}) is Not Exsists!", userName);
                    return false;
                }
            }
            catch
            {
                return false;
            }

        }

        //4) Update User
        static bool updateUser(string userName)
        {
            try
            {
                if (isUserExsist(userName))
                {
                    deleteUser(userName);
                    addNewUser();
                    return true;
                }
                else
                {
                    Console.WriteLine("The User Name ({0}) is Not Exsists!", userName);
                    return false;
                }
            }
            catch
            {
                return false;
            }

        }
        //5) Find User
        static void printUser(string userName)
        {
            if (isUserExsist(userName))
            {
                printUserTableHeader();
                strUser user = getUser(userName);
                printUserData(user);
            }
            else
            {
                Console.WriteLine("The user {0} doesnot exsists.", userName);
            }
        }

        //manage users start here
        static void manageUsers()
        {
            int userChoose = 0;
            do
            {
                Console.Clear();
                printManageUsersMenue();
                userChoose = readUserChoose();

                switch (userChoose)
                {
                    case 1:
                        printUsers();
                        goToManageUsers();
                        break;
                    case 2:
                        addNewUser();
                        goToManageUsers();
                        break;
                    case 3:
                        deleteUser(readUserName());
                        goToManageUsers();
                        break;
                    case 4:
                        updateUser(readUserName());
                        goToManageUsers();
                        break;
                    case 5:
                        printUser(readUserName());
                        goToManageUsers();
                        break;

                    case 6:
                        startBank();
                        break;

                    default:
                        Console.WriteLine("Invalid Menue Option!");
                        Console.WriteLine("Press any key to Rechoose...");
                        Console.ReadKey();
                        manageUsers();
                        break;
                }


            } while (userChoose <= 6);
        }

        //Start Here
        static void loginMenue()
        {
            string loginScreen = "Login Screen";

            Console.SetCursorPosition((Console.WindowWidth - loginScreen.Length) / 2, Console.CursorTop);

            Console.WriteLine(loginScreen);
        }
        static bool isValidUser(strUser user)
        {
            strUser tempUser = getUser(user.UserName);

            return tempUser.UserName == user.UserName && tempUser.Password == user.Password;
        }
        static void login()
        {
            bool validUser = false;
            strUser user = new strUser();

            do
            {
                Console.Clear();
                loginMenue();
                user = readUser();
                validUser = isValidUser(user);
                if (!validUser)
                {
                    Console.WriteLine("Inavlid User Name Or Password!!");
                    Console.WriteLine("Press any Key To try Again...");
                    Console.ReadKey();
                }

            }
            while (!validUser);

            user = getUser(user.UserName);

            usersessionPrivelege = user.privilege;
            startBank();

        }
        static bool checkUserAccessPrivelege(int menueNumber, int userSessionPrivelege)
        {
            if (userSessionPrivelege == -1)
                return true;

            if ((menueNumber & userSessionPrivelege) == menueNumber)
                return true;

            return false;
        }
        static void startBank()
        {
            int userChoose = 0;
            do
            {
                Console.Clear();
                printMainMenue();
                userChoose = readUserChoose();

                switch (userChoose)
                {
                    case 1:
                        if (checkUserAccessPrivelege(1, usersessionPrivelege))
                        {
                            printClients();
                            goBack();
                            break;
                        }
                        else
                        {
                            printAccessDeniedPage();
                            goBack();
                            break;
                        }

                    case 2:
                        if (checkUserAccessPrivelege(2, usersessionPrivelege))
                        {
                            addNewClient();
                            goBack();
                            break;
                        }
                        else
                        {
                            printAccessDeniedPage();
                            goBack();
                            break;
                        }
                    case 3:
                        if (checkUserAccessPrivelege(4, usersessionPrivelege))
                        {
                            deleteClient(readClientAccountNumber());
                            goBack();
                            break;
                        }
                        else
                        {
                            printAccessDeniedPage();
                            goBack();
                            break;
                        }
                    case 4:
                        if (checkUserAccessPrivelege(8, usersessionPrivelege))
                        {
                            updateClient(readClientAccountNumber());
                            goBack();
                            break;
                        }
                        else
                        {
                            printAccessDeniedPage();
                            goBack();
                            break;
                        }
                    case 5:
                        if (checkUserAccessPrivelege(16, usersessionPrivelege))
                        {
                            printClient(readClientAccountNumber());
                            goBack();
                            break;
                        }
                        else
                        {
                            printAccessDeniedPage();
                            goBack();
                            break;
                        }

                    case 6:
                        if (checkUserAccessPrivelege(32, usersessionPrivelege))
                        {
                            Console.Clear();
                            transactions();
                            break;
                        }
                        else
                        {
                            printAccessDeniedPage();
                            goBack();
                            break;
                        }
                    case 7:
                        if (checkUserAccessPrivelege(64, usersessionPrivelege))
                        {
                            Console.Clear();
                            manageUsers();
                            break;
                        }
                        else
                        {
                            printAccessDeniedPage();
                            goBack();
                            break;
                        }

                    case 8:
                        login();
                        break;

                    default:
                        Console.WriteLine("Invalid Choose!!");
                        Console.WriteLine("Press any key to rechoose..");
                        Console.ReadKey();
                        startBank();
                        break;
                }


            } while (userChoose <= 7);
        }
    }
}
