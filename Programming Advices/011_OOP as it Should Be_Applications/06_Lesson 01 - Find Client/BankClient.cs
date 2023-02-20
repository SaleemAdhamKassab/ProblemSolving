namespace Lab.Class.Bank
{
    public class BankClient : Person
    {
        private static readonly string filePath = "ClientsDB.txt";
        private string AccountNumber { get; set; }
        private string PinCode { get; set; }
        private double AccountBalance { get; set; }
        private enMode Mode;
        private static BankClient _getEmptyClientObject() => new BankClient("", "", "", "", enMode.EmptyMode, "", "", 0);
        private static BankClient _convertLineToClientObject(string lineData, string seperator)
        {
            string[] splitedLineData = lineData.Split(seperator);

            return new BankClient(splitedLineData[2], splitedLineData[3], splitedLineData[4], splitedLineData[5], enMode.UpdateMode, splitedLineData[0], splitedLineData[1], double.Parse(splitedLineData[6]));
        }
        private static List<BankClient> _loadClientsFromFileToList(string filePath, string seperator)
        {
            List<BankClient> clientsList = new List<BankClient>();

            foreach (string lineData in File.ReadLines(filePath))
                clientsList.Add(_convertLineToClientObject(lineData, seperator));

            return clientsList;
        }

        public BankClient(string firstName, string lastName, string email, string phone,
                         enMode mode, string accountNumber, string pinCode, double accountBalance) : base(firstName, lastName, email, phone)
        {
            Mode = mode;
            AccountNumber = accountNumber;
            PinCode = pinCode;
            AccountBalance = accountBalance;
        }

        public enum enMode { EmptyMode, UpdateMode }
        public void print()
        {
            Console.WriteLine("Client Card: ");
            Console.WriteLine("____________________________________");
            Console.WriteLine("First Name : {0}", FirstName);
            Console.WriteLine("Last Name : {0}", LastName);
            Console.WriteLine("Full Name : {0}", fullName());
            Console.WriteLine("Email : {0}", Email);
            Console.WriteLine("Phone : {0}", Phone);
            Console.WriteLine("Acc. Number : {0}", AccountNumber);
            Console.WriteLine("Pin Code : {0}", PinCode);
            Console.WriteLine("Balance : {0}", AccountBalance);
            Console.WriteLine("____________________________________");
        }
        public static BankClient Find(string accountNumber, string pinCode = "")
        {
            BankClient client = _getEmptyClientObject();

            List<BankClient> clientsList = _loadClientsFromFileToList(filePath, "#//#");

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
        public static bool isClientExist(string accountNumber) =>
             Find(accountNumber).Mode == enMode.EmptyMode ? false : true;
    }
}