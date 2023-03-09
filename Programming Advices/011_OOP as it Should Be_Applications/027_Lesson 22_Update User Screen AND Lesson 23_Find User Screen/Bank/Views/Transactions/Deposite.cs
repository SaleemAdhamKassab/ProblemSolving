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
                drawScreenHeader("Deposite Balance");

                string accountNumber = readOneInfo("Enter Account Number: ").ToString();

                while (!transactionsController.IsClientExsist(accountNumber))
                    accountNumber = readOneInfo("Invalid Account Number (" + accountNumber + "), choose another one: ").ToString();

                int depositAmount = int.Parse(readOneInfo("Please Enter Deposit Amount :").ToString());

                if (confirmationMessage("Are you sure to perfoem this transaction? Y/N :") == 'y')
                {
                    transactionsController.deposit(accountNumber, depositAmount);
                    Console.WriteLine("Amount has been deposited ({0})", depositAmount);
                    PrintClient(transactionsController.Get(accountNumber));
                }
                else
                    Console.WriteLine("Taransaction Canceled");

                goBack();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}

