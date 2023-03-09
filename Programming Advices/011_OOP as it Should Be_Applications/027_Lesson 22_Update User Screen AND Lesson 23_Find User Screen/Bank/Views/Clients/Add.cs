using Lab.Bank.Controllers;
using Lab.Bank.Shared;
using Lab.Class.Bank;

namespace Lab.Bank.Views.Clients
{
    internal class Add : FrontEndFunctions
    {
        public void AddNewClient()
        {
            try
            {
                ClientsController clientsController = new ClientsController();

                drawScreenHeader("Add New Client");

                string accountNumber = readOneInfo("Enter Account Number: ").ToString();

                while (clientsController.IsClientExsist(accountNumber))
                    accountNumber = readOneInfo("Account Number (" + accountNumber + ") is already used, choose another one: ").ToString();

                Client client = readClientInfo(accountNumber);
                client.AccountNumber = accountNumber;

                clientsController.Post(client);

                Console.WriteLine();
                Console.WriteLine("Client ({0}) Added Successfully", accountNumber);
                PrintClient(client);
               

                goBack();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
