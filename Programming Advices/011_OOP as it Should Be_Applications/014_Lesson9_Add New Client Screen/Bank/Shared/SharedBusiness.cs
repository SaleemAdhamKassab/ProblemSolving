using Lab.Class.Bank;
using Labs.Bank.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Bank.Shared
{
    public class SharedBusiness
    {
        public static BankClient getEmptyClientObject() => new BankClient("", "", "", "", "", "", 0, BankClient.enMode.EmptyMode);
        public static object readClientOneInfo(string msg)
        {
            Console.Write(msg);
            return Console.ReadLine();
        }
        public static BankClient readClientInfo(string accountNumber = "") =>
           new BankClient(accountNumber == null ? readClientOneInfo("Enter Account Number: ").ToString() : accountNumber,
               readClientOneInfo("Enter Pin Code: ").ToString(),
               readClientOneInfo("Enter First Name: ").ToString(),
               readClientOneInfo("Enter Last Name: ").ToString(),
               readClientOneInfo("Enter Email: ").ToString(),
               readClientOneInfo("Enter Phone: ").ToString(),
               double.Parse(readClientOneInfo("Enter Account Balance: ").ToString()),
               BankClient.enMode.UpdateMode);
        public static BankClient FindClient(string accountNumber, string pinCode = "")
        {
            BankClient client = getEmptyClientObject();

            List<object> clientsList = FileDbContext.convertFileDataToList(FileDbContext.ClientsDbConnectionString, FileDbContext.FileRowSeparator);

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
        public static bool IsClientExist(string accountNumber) => FindClient(accountNumber).Mode == BankClient.enMode.EmptyMode ? false : true;
        public static void goBack()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to go back Menue...");
            Console.ReadKey();
        }
        public static void printBreakLine(string lineType, int rowLength) => Console.WriteLine(padRight(lineType, rowLength, char.Parse(lineType)));
        public static string padRight(string word, int numberOfFiilingCells, char fillChar)
        {
            if (word.Length >= numberOfFiilingCells)
                return word;

            for (int i = word.Length; i < numberOfFiilingCells; i++)
                word += fillChar;

            return word;
        }
        public static char confirmationMessage(string msg, string accountNumber)
        {
            Console.WriteLine("Are you sure to " + msg + " Acc. ({0}) Y/N ?", accountNumber);
            return char.Parse(Console.ReadLine().ToLower());
        }
    }
}
