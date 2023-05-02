using Lab.Bank.Controllers;
using Lab.Bank.Models;
using Lab.Bank.Shared;

namespace Lab.Bank.Views.Clients
{
    public class Print : FrontEndFunctions
    {
        void _printClientsListTableHeader()
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

            Console.WriteLine(getBreakLine('_', 150));
            Console.WriteLine();
        }
        void _printClientRow(Client client)
        {
            Console.Write(padRight(client.AccountNumber, 20, ' '));
            Console.Write(padRight(client.PinCode, 20, ' '));
            Console.Write(padRight(client.FirstName, 20, ' '));
            Console.Write(padRight(client.LastName, 20, ' '));
            Console.Write(padRight(client.Email, 30, ' '));
            Console.Write(padRight(client.Phone, 25, ' '));
            Console.Write(padRight(client.AccountBalance.ToString(), 20, ' '));
            Console.WriteLine();
        }
        public void printClients()
        {
            try
            {
                ClientsController clientsController = new ClientsController();
                List<object> clients = clientsController.Get();
                int clientsConunt = clients.Count;

                if (clientsConunt == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("No Clients Found!!");
                }
                    
                else
                {
                    drawViewHeader("Clients List", clientsConunt + " Client (s)");
                    _printClientsListTableHeader();

                    foreach (Client client in clients)
                        _printClientRow(client);

                    Console.WriteLine(getBreakLine('_', 150));
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