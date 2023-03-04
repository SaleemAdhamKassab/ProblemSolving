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
        public static void Delete()
        {
            try
            {
                char userChoose = 'n';
                string accountNumber = "";

                Console.Clear();
                drawScreenHeader("Delete Client");
                accountNumber = readClientOneInfo("Enter Account Number: ").ToString();

                while (!IsClientExist(accountNumber))
                    accountNumber = readClientOneInfo("Account Number (" + accountNumber + ") is not found, choose another one: ").ToString();

                BankClient clientToDelete = FindClient(accountNumber);
                PrintClient(clientToDelete);
                userChoose = confirmationMessage("delete", accountNumber);

                if (userChoose == 'y')
                {
                    List<object> clientsList = FileDbContext.convertFileDataToList(FileDbContext.ClientsDbConnectionString, FileDbContext.FileRowSeparator);
                    List<object> clientsListAfterDeleteTheClient = new List<object>();

                    foreach (BankClient client in clientsList)
                        if (client.AccountNumber != accountNumber)
                            clientsListAfterDeleteTheClient.Add(client);

                    if (FileDbContext.saveListToFile(clientsListAfterDeleteTheClient, false))
                        Console.WriteLine("Client " + accountNumber + " deleted Successfully");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}