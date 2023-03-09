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
                drawScreenHeader("Withdraw Balance");

                string accountNumber = readOneInfo("Enter Account Number: ").ToString();

                while (!transactionsController.IsClientExsist(accountNumber))
                    accountNumber = readOneInfo("Invalid Account Number (" + accountNumber + "), choose another one: ").ToString();

                int withdrawAmount = int.Parse(readOneInfo("Please Enter Deposit Amount :").ToString());

                if (withdrawAmount <= transactionsController.clientBalance(accountNumber))
                {
                    if (confirmationMessage("Are you sure to perfoem this transaction? Y/N :") == 'y')
                    {
                        transactionsController.withdraw(accountNumber, withdrawAmount);
                        Console.WriteLine("Amount has been withdrawn ({0})", withdrawAmount);
                        PrintClient(transactionsController.Get(accountNumber));
                    }
                    else
                        Console.WriteLine("Taransaction Canceled");
                }
                else
                {
                    Console.WriteLine("ssssss");
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
