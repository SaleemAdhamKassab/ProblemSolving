using Lab.Bank.Controllers;
using Lab.Bank.Models;
using Lab.Bank.Shared;

namespace Lab.Bank.Views.Transactions
{
    internal class Transfer : FrontEndFunctions
    {
        string _readAccountNumber(string destination, TransactionsController transactionsController)
        {
            string accountNumber = readOneInfo("Enter Account Number to Transfer " + destination + " : ").ToString();

            while (!transactionsController.IsClientExsist(accountNumber))
                accountNumber = readOneInfo("Invalid Account Number (" + accountNumber + "), choose another one: ").ToString();

            return accountNumber;
        }
        bool _isValidClientBalanceToTransfer(int clientAmountBalance, int transferBalance) => clientAmountBalance >= transferBalance ? true : false;
        public void transfer()
        {
            try
            {
                TransactionsController transactionsController = new TransactionsController();
                ClientsController clientsController = new ClientsController();

                int transferAmount = 0;
                string fromClientAccountNumber = " ", toClientAccountNumber = "";

                drawViewHeader("Transfer Balances");

                fromClientAccountNumber = _readAccountNumber("From", transactionsController);
                Client fromClient = clientsController.Get(fromClientAccountNumber);
                PrintClient(fromClient);

                toClientAccountNumber = _readAccountNumber("To", transactionsController);
                Client toClient = clientsController.Get(toClientAccountNumber);

                while (fromClient.AccountNumber == toClient.AccountNumber)
                {
                    Console.WriteLine();
                    Console.WriteLine("Cannot Transfer Balance Amount to the Same Account!!");
                    Console.WriteLine();
                    toClientAccountNumber = _readAccountNumber("To", transactionsController);
                    toClient = clientsController.Get(toClientAccountNumber);
                }

                PrintClient(toClient);

                transferAmount = readIntNumber("Enter Transfer Amount: ");

                while (!_isValidClientBalanceToTransfer(fromClient.AccountBalance, transferAmount))
                    transferAmount = int.Parse(readOneInfo("Amount Exceeds the Available Balance, Enter another Amount: ").ToString());

                if (confirmationMessage("Are You Sure you want to perform this operation? Y/N :") == 'y')
                {
                    transactionsController.transfer(transferAmount, fromClient.AccountNumber, toClient.AccountNumber);

                    fromClient = clientsController.Get(fromClientAccountNumber);
                    toClient = clientsController.Get(toClientAccountNumber);

                    ClientsTransferLog clientsTransferLog = new ClientsTransferLog(

                        DateTime.Now.ToString("MM/dd/yyyy HH:mm"),
                        fromClient.AccountNumber,
                        toClient.AccountNumber,
                        transferAmount,
                        fromClient.AccountBalance,
                         toClient.AccountBalance,
                        fromClient.FirstName);

                    clientsController.addTransferBalanceLog(clientsTransferLog);

                    Console.WriteLine();
                    Console.WriteLine("Transfer Done Successfully");

                    Console.WriteLine();
                    PrintClient(fromClient);
                    PrintClient(toClient);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Transfer Cancelled");
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