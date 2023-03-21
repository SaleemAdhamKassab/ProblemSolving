using Lab.Bank.Controllers;
using Lab.Bank.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Bank.Views.Transactions
{
    internal class Withdraw : FrontEndFunctions
    {
        public void WithDrawClientBalance()
        {
            try
            {
                TransactionsController transactionsController = new TransactionsController();
                char userChoose = 'n';

                drawViewHeader("Withdraw Balance");

                string accountNumber = readOneInfo("Enter Account Number: ").ToString();

                while (!transactionsController.IsClientExsist(accountNumber))
                    accountNumber = readOneInfo("Invalid Account Number (" + accountNumber + "), choose another one: ").ToString();

                Console.WriteLine();
                int withdrawAmount = readIntNumber("Please Enter Withdraw Amount :");

                double clientBalnce = transactionsController.clientBalance(accountNumber);

                if (withdrawAmount <= clientBalnce)
                {
                    if (confirmationMessage("Are you sure to perfoem this transaction? Y/N :") == 'y')
                    {
                        transactionsController.withdraw(accountNumber, withdrawAmount);
                        Console.WriteLine();
                        Console.WriteLine("Amount has been withdrawn ({0}) Successfully", withdrawAmount);
                        PrintClient(transactionsController.Get(accountNumber));
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Transaction Canceled");
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Cannot Withdraw, Insuffent Balance!");
                    Console.WriteLine("_____________________________________");
                    Console.WriteLine("Amount to Withdraw is: {0}", withdrawAmount);
                    Console.WriteLine("Your Balance is: {0}", clientBalnce);
                    Console.WriteLine();
                }
                goBack();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
