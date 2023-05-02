using Lab.Bank.Controllers;
using Lab.Bank.Shared;

namespace Lab.Bank.Views.Transactions
{
    internal class Deposite : FrontEndFunctions
    {
        public void DepositClientBalance()
        {
            try
            {
                TransactionsController transactionsController = new TransactionsController();

                char userChoose = 'n';
                drawViewHeader("Deposite Balance");

                string accountNumber = readOneInfo("Enter Account Number: ").ToString();

                while (!transactionsController.IsClientExsist(accountNumber))
                    accountNumber = readOneInfo("Invalid Account Number (" + accountNumber + "), choose another one: ").ToString();

                Console.WriteLine();
                int depositAmount = readIntNumber("Please Enter Deposit Amount :");

                if (confirmationMessage("Are you sure to perfoem this transaction? Y/N :") == 'y')
                {
                    transactionsController.deposit(accountNumber, depositAmount);

                    Console.WriteLine();
                    Console.WriteLine("Amount has been deposited ({0}) Successfully", depositAmount);

                    PrintClient(transactionsController.Get(accountNumber));
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Transaction Canceled");
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

