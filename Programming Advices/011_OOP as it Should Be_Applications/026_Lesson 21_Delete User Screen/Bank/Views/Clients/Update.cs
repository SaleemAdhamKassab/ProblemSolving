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
    internal class Update : FrontEndFunctions
    {
        public void UpdateClient()
        {
            try
            {
                ClientsController clientsController = new ClientsController();

                drawScreenHeader("Update Client");
                string accountNumber = readOneInfo("Enter Account Number: ").ToString();

                while (!clientsController.IsClientExsist(accountNumber))
                    accountNumber = readOneInfo("Account Number (" + accountNumber + ") is not found, choose another one: ").ToString();

                Client clientToUpdate = clientsController.Get(accountNumber);
                PrintClient(clientToUpdate);


                if (confirmationMessage("Are you sure to Update Acc. " + accountNumber + " Y /N ?") == 'y')
                {
                    Client updatedClient = readClientInfo(accountNumber);
                    clientsController.Update(updatedClient);
                    
                    Console.WriteLine();
                    Console.WriteLine("Client ({0}) Updated Successfully", accountNumber);
                    PrintClient(updatedClient);
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
