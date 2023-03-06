using Lab.Class.Bank;
using Lab.Classes;
using Labs.Bank.Db;
using Labs.Bank.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Bank.Screens.Transactions
{
    internal class TotalBalances : Screen
    {
        private static void _printBalanceTableHeader(int fileRwosCount, int lineLength)
        {
            printBreakLine("_", 50);
            Console.WriteLine();
            Console.WriteLine(
                padRight("Acc. Num", 20, ' ') +
                padRight("First Name", 20, ' ') +
                padRight("Balance", 20, ' '));

            printBreakLine("_", lineLength);
            Console.WriteLine();
        }
        private static void _printClienBalancetRow(BankClient client)
        {
            Console.Write(padRight(client.AccountNumber, 20, ' '));
            Console.Write(padRight(client.FirstName, 20, ' '));
            Console.Write(padRight(client.AccountBalance.ToString(), 20, ' '));
            Console.WriteLine();
        }
        public static void ShowTotalBalances()
        {
            List<object> clients = FileDbContext.convertFileDataToList(FileDbContext.ClientsDbConnectionString, FileDbContext.FileRowSeparator);

            if (clients.Count == 0)
                Console.WriteLine("No Clients found");
            else
            {
                drawScreenHeader("Total Balances Menu", "Client (s): " + clients.Count);
                _printBalanceTableHeader(clients.Count, 50);

                foreach (BankClient client in clients)
                    _printClienBalancetRow(client);

                Console.WriteLine();
                printBreakLine("_", 50);
            }

            int totalBalances = clientsTotalBalances();
            Console.WriteLine("Total Balances = " + totalBalances);
            Console.WriteLine("( " + SaleemUtil.NumberToText(totalBalances) + " )");
        }

    }
}
