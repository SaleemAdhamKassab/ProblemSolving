using Lab.Bank.Controllers;
using Lab.Bank.Shared;
using Lab.Class.Bank;
using Lab.Classes;

namespace Lab.Bank.Views.Transactions
{
    internal class TotalBalances : FrontEndFunctions
    {
        private void _printBalanceTableHeader(int fileRwosCount, int lineLength)
        {
            Console.WriteLine(getBreakLine('_', 50));
            Console.WriteLine();
            Console.WriteLine(
                padRight("Acc. Num", 20, ' ') +
                padRight("First Name", 20, ' ') +
                padRight("Balance", 20, ' '));

            Console.WriteLine(getBreakLine('_', 50));
            Console.WriteLine();
        }
        private void _printClienBalancetRow(Client client)
        {
            Console.Write(padRight(client.AccountNumber, 20, ' '));
            Console.Write(padRight(client.FirstName, 20, ' '));
            Console.Write(padRight(client.AccountBalance.ToString(), 20, ' '));
            Console.WriteLine();
        }
        public void ClientsTotalBalances()
        {
            try
            {
                TransactionsController transactionsController = new TransactionsController();
                List<object> clients = transactionsController.Get();
                int totalBalances = transactionsController.clientsTotalBalances();

                if (clients.Count == 0)
                    Console.WriteLine("No Clients found");
                else
                {
                    drawScreenHeader("Total Clients Balances", "Client (s): " + clients.Count);
                    _printBalanceTableHeader(clients.Count, 50);

                    foreach (Client client in clients)
                        _printClienBalancetRow(client);

                    Console.WriteLine();
                    Console.WriteLine(getBreakLine('_', 50));

                    Console.WriteLine("Total Balances = " + totalBalances);
                    Console.WriteLine("(" + SaleemUtil.NumberToText(totalBalances) + ")");

                    goBack();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
