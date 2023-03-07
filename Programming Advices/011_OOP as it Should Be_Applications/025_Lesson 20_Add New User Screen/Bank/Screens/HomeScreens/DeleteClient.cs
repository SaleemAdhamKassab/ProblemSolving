using Lab.Class.Bank;
using Lab.Bank.Db;
using Lab.Bank.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Bank.Screens
{
    internal class DeleteClient : Screen
    {
        public static void Delete()
        {
            try
            {
                char userChoose = 'n';
                string accountNumber = "";

                drawScreenHeader("Delete Client");
                accountNumber = readOneInfo("Enter Account Number: ").ToString();

                while (!IsClientExist(accountNumber))
                    accountNumber = readOneInfo("Account Number (" + accountNumber + ") is not found, choose another one: ").ToString();

                BankClient clientToDelete = findClient(accountNumber);
                PrintClient(clientToDelete);
                userChoose = confirmationMessage("Are you sure to delete Acc. " +accountNumber + " Y /N ?");

                if (userChoose == 'y')
                {
                    List<object> clientsList = FileDbContext.convertFileDataToList(FileDbContext.ClientsDbConnectionString, FileDbContext.FileRowSeparator, FileDbContext.enConvertLineToObjetTypes.Client);
                    List<object> clientsListAfterDeleteTheClient = new List<object>();

                    foreach (BankClient client in clientsList)
                        if (client.AccountNumber != accountNumber)
                            clientsListAfterDeleteTheClient.Add(client);

                    if (FileDbContext.saveListToFile(clientsListAfterDeleteTheClient, FileDbContext.ClientsDbConnectionString, false))
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