using Lab.Class.Bank;
using Labs.Bank.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Bank.Screens
{
    internal class ClientsList : Screen
    {
        private static void _printClientRow(BankClient client)
        {
            Console.Write(padRight(client.AccountNumber, 20, ' '));
            Console.Write(padRight(client.PinCode.ToString(), 20, ' '));
            Console.Write(padRight(client.FirstName, 20, ' '));
            Console.Write(padRight(client.LastName, 20, ' '));
            Console.Write(padRight(client.Email.ToString(), 30, ' '));
            Console.Write(padRight(client.Phone.ToString(), 25, ' '));
            Console.Write(padRight(client.AccountBalance.ToString(), 20, ' '));
            Console.WriteLine();
        }
        private static void _printClientsListTableHeader()
        {
            Console.WriteLine();
            Console.WriteLine(
                padRight("Acc. Num", 20, ' ') +
                padRight("Pin Code", 20, ' ') +
                padRight("First Name", 20, ' ') +
                padRight("Last Name", 20, ' ') +
                padRight("Email", 30, ' ') +
                padRight("Phone", 25, ' ') +
                padRight("Balance", 20, ' '));

            printBreakLine("_", 150);
            Console.WriteLine();
        }

        public static void PrintClient(BankClient client)
        {
            Console.WriteLine();
            Console.WriteLine("Client Card: ");
            Console.WriteLine("____________________________________");
            Console.WriteLine("Acc. Number : {0}", client.AccountNumber);
            Console.WriteLine("Pin Code : {0}", client.PinCode);
            Console.WriteLine("First Name : {0}", client.FirstName);
            Console.WriteLine("Last Name : {0}", client.LastName);
            Console.WriteLine("Email : {0}", client.Email);
            Console.WriteLine("Phone : {0}", client.Phone);
            Console.WriteLine("Balance : {0}", client.AccountBalance);
            Console.WriteLine("____________________________________");
        }
        public static void PrintClients()
        {
            List<object> clients = FileDbContext.convertFileDataToList(FileDbContext.ClientsDbConnectionString, FileDbContext.FileRowSeparator);
            int clientsCount = clients.Count;

            if (clientsCount == 0)
                Console.WriteLine("No Clients found");
            else
            {
                Console.Clear();
                Console.WriteLine();
                drawScreenHeader("Clients List Screen", "(" + clientsCount + ") Client (s)");
                _printClientsListTableHeader();
                foreach (BankClient client in clients)
                    _printClientRow(client);
                printBreakLine("_", 150);
            }

            goBack();
        }
    }
}
