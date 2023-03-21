using Lab.Bank.Controllers;
using Lab.Bank.Models;
using Lab.Bank.Shared;

namespace Lab.Bank.Views.Transactions
{
    internal class TransferBalanceLog : FrontEndFunctions
    {
        void _printTransferBalancesListTableHeader()
        {
            Console.WriteLine();
            Console.WriteLine(
                padRight("Date/Time", 20, ' ') +
                padRight("s.Acct", 15, ' ') +
                padRight("d.Acct", 25, ' ') +
                padRight("Amount", 15, ' ') +
                padRight("s.Balance", 15, ' ') +
                padRight("d.Balance", 15, ' ') +
                padRight("User", 15, ' '));

            Console.WriteLine(getBreakLine('_', 135));
        }
        void _printTransferBalanceRow(ClientsTransferLog clientsTransferLog)
        {
            Console.Write(padRight(clientsTransferLog.TransferDate, 20, ' '));
            Console.Write(padRight(clientsTransferLog.AccountNumber, 15, ' '));
            Console.Write(padRight(clientsTransferLog.ToAccountNumber, 25, ' '));
            Console.Write(padRight(clientsTransferLog.TransferAmount.ToString(), 15, ' '));
            Console.Write(padRight(clientsTransferLog.AccountBalanceAfterTransfer.ToString(), 15, ' '));
            Console.Write(padRight(clientsTransferLog.DestinationBalanceAfterTransfer.ToString(), 15, ' '));
            Console.Write(padRight(clientsTransferLog.Name.ToString(), 15, ' '));
            Console.WriteLine();
        }
        public void print()
        {

            try
            {
                ClientsController cLientsController = new ClientsController();

                List<object> transferBalancesLog = cLientsController.getTransferBalancesLog();
                int transferBalancesCount = transferBalancesLog.Count;

                if (transferBalancesCount == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("No Transfer Balances found!!");
                }
                    
                else
                {
                    Console.WriteLine();
                    drawViewHeader("TransferBalances List", "(" + transferBalancesCount + ")");

                    _printTransferBalancesListTableHeader();

                    foreach (ClientsTransferLog transferBalance in transferBalancesLog)
                        _printTransferBalanceRow(transferBalance);

                    Console.WriteLine(getBreakLine('_', 135));
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
