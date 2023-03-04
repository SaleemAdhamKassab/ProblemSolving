using Lab.Class.Bank;
using Labs.Bank.Db;
using Labs.Bank.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Bank.Screens
{
    internal class DeleteClient : Screen
    {
        public static bool Delete(string accountNumber = "")
        {
            try
            {
                Console.Clear();
                drawScreenHeader("Delete Client");

                char c = 'y';

                if (accountNumber == "")
                {
                    accountNumber = readClientOneInfo("Enter Account Number: ").ToString();

                    while (!IsClientExist(accountNumber))
                        accountNumber = readClientOneInfo("Account Number (" + accountNumber + ") is not found, choose another one: ").ToString();
                }

                BankClient clientToDelete = FindClient(accountNumber);

                PrintClient(clientToDelete);

                c = confirmationMessage("delete", accountNumber);

                if (c == 'y')
                {
                    List<object> clientsList = FileDbContext.convertFileDataToList(FileDbContext.ClientsDbConnectionString, FileDbContext.FileRowSeparator);

                    List<object> clientsListAfterDeleteTheClient = new List<object>();

                    foreach (BankClient client in clientsList)
                        if (client.AccountNumber != accountNumber)
                            clientsListAfterDeleteTheClient.Add(client);

                    FileDbContext.saveListToFile(clientsListAfterDeleteTheClient, false);

                    Console.WriteLine("Client " + accountNumber + " deleted Successfully");
                }

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
    }
}