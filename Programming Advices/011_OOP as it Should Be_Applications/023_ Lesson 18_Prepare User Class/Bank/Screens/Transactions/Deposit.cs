using Lab.Class.Bank;
using Labs.Bank.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Bank.Screens.Transactions
{
    internal class Deposit : Screen
    {
        private static double _readDepositAmount(string message)
        {
            Console.Write(message);
            return double.Parse(Console.ReadLine());
        }
        public static void deposit()
        {
            char userChoose = 'n';
            drawScreenHeader("Deposite Menu");

            string accountNumber = readClientOneInfo("Enter Account Number: ").ToString();

            while (!IsClientExist(accountNumber))
                accountNumber = readClientOneInfo("Account Number (" + accountNumber + ") is already used, choose another one: ").ToString();

            double depositAmount = _readDepositAmount("Please Enter Deposit Amount :");

            Console.Write("Are you sure to perfoem this transaction? Y/N :");

            if (Console.ReadLine().ToLower() == "y")
            {
                List<object> clientsList = FileDbContext.convertFileDataToList(FileDbContext.ClientsDbConnectionString, FileDbContext.FileRowSeparator);
                BankClient clientToUpdate = findClient(accountNumber);

                foreach (BankClient bankClient in clientsList)
                {
                    if (bankClient.AccountNumber == clientToUpdate.AccountNumber)
                    {
                        bankClient.AccountBalance += depositAmount;
                        clientToUpdate = bankClient;
                        break;
                    }
                }

                if (FileDbContext.saveListToFile(clientsList, false))
                {
                    Console.WriteLine();
                    Console.WriteLine("Amount has been deposited ({0})", depositAmount);
                    PrintClient(clientToUpdate);
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Taransaction Canceled");
            }
        }
    }
}