using Lab.Bank.Controllers;
using Lab.Bank.Models;
using Lab.Bank.Shared;

namespace Lab.Bank.Views.Clients
{
    internal class Delete : FrontEndFunctions
    {
        public void DeleteClient()
        {
            try
            {
                ClientsController clientsController = new ClientsController();

                drawViewHeader("Delete Client");
                string accountNumber = readOneInfo("Enter Account Number: ").ToString();

                while (!clientsController.IsClientExsist(accountNumber))
                    accountNumber = readOneInfo("Account Number (" + accountNumber + ") is not found, choose another one: ").ToString();

                Client clientToDelete = clientsController.Get(accountNumber);
                PrintClient(clientToDelete);

                if (confirmationMessage("Are you sure to delete Acc. " + accountNumber + " Y /N ?") == 'y')
                {
                    clientsController.Delete(accountNumber);
                    Console.WriteLine();
                    Console.WriteLine("Client " + accountNumber + " deleted Successfully");
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
