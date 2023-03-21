using Lab.Bank.Controllers;
using Lab.Bank.Models;
using Lab.Bank.Shared;

namespace Lab.Bank.Views.Clients
{
    internal class Find : FrontEndFunctions
    {
        public void FindClient()
        {
            try
            {
                ClientsController clientsController = new ClientsController();

                drawViewHeader("Find Client");
                string accountNumber = readOneInfo("Enter Account Number: ").ToString();

                Client client = clientsController.Get(accountNumber);

                while (!clientsController.IsClientExsist(accountNumber))
                    accountNumber = readOneInfo("Account Number (" + accountNumber + ") is not found, choose another one: ").ToString();

                PrintClient(clientsController.Get(accountNumber));

                goBack();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
