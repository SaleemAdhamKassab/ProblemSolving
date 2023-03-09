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
    internal class Find : FrontEndFunctions
    {

        public void FindClient()
        {
            try
            {
                ClientsController clientsController = new ClientsController();

                drawScreenHeader("Find Client");
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
