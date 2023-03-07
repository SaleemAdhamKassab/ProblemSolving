using Lab.Class.Bank;
using Lab.Bank.Db;
using Lab.Bank.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Bank.Screens.Transactions
{
    internal class Withdraw : Screen
    {
        private static double _readDepositAmount(string message)
        {
            Console.Write(message);
            return double.Parse(Console.ReadLine());
        }
        public static void withDraw()
        {
            char userChoose = 'n';
            drawScreenHeader("Withdraw Balance");

            string accountNumber = readOneInfo("Enter Account Number: ").ToString();

            while (!IsClientExist(accountNumber))
                accountNumber = readOneInfo("Account Number (" + accountNumber + ") is already used, choose another one: ").ToString();

            BankClient clientToUpdate = findClient(accountNumber);

            double withdrawAmount = _readDepositAmount("Please Enter Withdraw Amount :");

            if (clientToUpdate.AccountBalance >= withdrawAmount)
            {
                Console.Write("Are you sure to perfoem this transaction? Y/N :");

                if (Console.ReadLine().ToLower() == "y")
                {
                    List<object> clientsList = FileDbContext.convertFileDataToList(FileDbContext.ClientsDbConnectionString, FileDbContext.FileRowSeparator, FileDbContext.enConvertLineToObjetTypes.Client);


                    foreach (BankClient bankClient in clientsList)
                    {
                        if (bankClient.AccountNumber == clientToUpdate.AccountNumber)
                        {
                            if (bankClient.AccountBalance >= -withdrawAmount)
                            {
                                bankClient.AccountBalance -= withdrawAmount;
                                clientToUpdate = bankClient;
                                break;
                            }
                        }
                    }

                    if (FileDbContext.saveListToFile(clientsList, FileDbContext.ClientsDbConnectionString, false))
                    {
                        Console.WriteLine();
                        Console.WriteLine("Amount has been withdrawn: {0}", withdrawAmount);
                        PrintClient(clientToUpdate);
                    }
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Cannot Withdraw, Insuffecint Balance!");
                Console.WriteLine("Amount to Withdraw is: {0}", withdrawAmount);
                Console.WriteLine("Your Balance is: {0}", clientToUpdate.AccountBalance);
                Console.WriteLine("Taransaction Canceled");
            }
        }

    }
}
