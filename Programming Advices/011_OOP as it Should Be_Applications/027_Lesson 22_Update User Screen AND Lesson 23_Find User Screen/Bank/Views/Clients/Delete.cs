using Lab.Bank.Controllers;
using Lab.Bank.Shared;
using Lab.Class.Bank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Bank.Views.Clients
{
    internal class Delete : FrontEndFunctions
    {
        public void DeleteClient()
        {
            try
            {
                ClientsController clientsController = new ClientsController();

                drawScreenHeader("Delete Client");
                string accountNumber = readOneInfo("Enter Account Number: ").ToString();

                while (!clientsController.IsClientExsist(accountNumber))
                    accountNumber = readOneInfo("Account Number (" + accountNumber + ") is not found, choose another one: ").ToString();

                Client clientToDelete = clientsController.Get(accountNumber);
                PrintClient(clientToDelete);

                if (confirmationMessage("Are you sure to delete Acc. " + accountNumber + " Y /N ?") == 'y')
                {
                    clientsController.Delete(accountNumber);
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
