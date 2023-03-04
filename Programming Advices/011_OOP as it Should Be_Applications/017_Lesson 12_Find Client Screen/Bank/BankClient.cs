using Lab.Classes;
using Labs.Bank.Db;
using Labs.Bank.Screens;

namespace Lab.Class.Bank
{
    public class BankClient : Person
    {
        public BankClient(string accountNumber,
                          string pinCode,
                          string firstName,
                          string lastName,
                          string email,
                          string phone,
                          double accountBalance,
                          enMode mode) : base(firstName, lastName, email, phone)
        {
            Mode = mode;
            AccountNumber = accountNumber;
            PinCode = pinCode;
            AccountBalance = accountBalance;
        }
        public readonly enMode Mode;
        public string AccountNumber { get; set; }
        public string PinCode { get; set; }
        public double AccountBalance { get; set; }
        public static BankClient convertLineToClientObject(string lineData, string seperator)
        {
            string[] splitedLineData = lineData.Split(seperator);

            return new BankClient(splitedLineData[0],
                                  splitedLineData[1],
                                  splitedLineData[2],
                                  splitedLineData[3],
                                  splitedLineData[4],
                                  splitedLineData[5],
                                  double.Parse(splitedLineData[6]),
                                  enMode.UpdateMode);
        }
        public enum enMode { EmptyMode, UpdateMode }
        private static void _printBalanceTableHeader(int fileRwosCount, int lineLength)
        {
            string header = "Balances List (" + fileRwosCount + ") Client(s).";
            Console.SetCursorPosition((Console.WindowWidth - header.Length) / 2, Console.CursorTop);
            Console.WriteLine(header);

            Screen.printBreakLine("_", lineLength);
            Console.WriteLine();
            Console.WriteLine(
                Screen.padRight("Acc. Num", 20, ' ') +
                Screen.padRight("First Name", 20, ' ') +
                Screen.padRight("Balance", 20, ' '));

            Screen.printBreakLine("_", lineLength);
            Console.WriteLine();
        }
        private static void _printClienBalancetRow(BankClient client)
        {
            Console.Write(Screen.padRight(client.AccountNumber, 20, ' '));
            Console.Write(Screen.padRight(client.FirstName, 20, ' '));
            Console.Write(Screen.padRight(client.AccountBalance.ToString(), 20, ' '));
            Console.WriteLine();
        }
        private static int _clientsTotalBalances()
        {
            int totalBalances = 0;

            List<object> clientsList = FileDbContext.convertFileDataToList(FileDbContext.ClientsDbConnectionString, "#//#");

            foreach (BankClient client in clientsList)
                totalBalances += int.Parse(client.AccountBalance.ToString());

            return totalBalances;
        }

        //CRUD
        /* 
         public static void ShowTotalBalances()
         {
             List<object> clients = FileDbContext.convertFileDataToList(FileDbContext.ConnectionString, "#//#");

             if (clients.Count == 0)
                 Console.WriteLine("No Clients found");
             else
             {
                 _printBalanceTableHeader(clients.Count, 50);

                 foreach (BankClient client in clients)
                     _printClienBalancetRow(client);

                 Console.WriteLine();
                 Screen.printBreakLine("_", 50);
             }

             int clientsTotalBalances = _clientsTotalBalances();

             Console.WriteLine(("Total Balances = " + clientsTotalBalances).ToString().PadLeft(45));
             Console.WriteLine(("( " + Util.NumberToText(clientsTotalBalances) + " )").PadLeft(33));
         }*/
    }
}