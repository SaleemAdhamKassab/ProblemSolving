using Lab.Class.Bank;
using Labs.Bank.Db;
using Labs.Bank.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Bank.Screens
{
    internal class UpdateClient : Screen
    {
        public static void Update()
        {
            string accountNumber = "";

            Console.Clear();
            drawScreenHeader("Update Client");
            accountNumber = readClientOneInfo("Enter Client Account Number to Update: ").ToString();

            while (!IsClientExist(accountNumber))
                accountNumber = readClientOneInfo("Account Number " + accountNumber + " is Not found, Choose another one: ").ToString();

            BankClient client = findClient(accountNumber);
            PrintClient(client);


            if (confirmationMessage("update", accountNumber) == 'y')
            {
                List<object> clientsList = FileDbContext.convertFileDataToList(FileDbContext.ClientsDbConnectionString, FileDbContext.FileRowSeparator);

                foreach (BankClient bankClient in clientsList)
                {
                    if (bankClient.AccountNumber == client.AccountNumber)
                    {
                        client = readClientInfo(client.AccountNumber);

                        bankClient.FirstName = client.FirstName;
                        bankClient.LastName = client.LastName;
                        bankClient.Email = client.Email;
                        bankClient.Phone = client.Phone;
                        bankClient.AccountBalance = client.AccountBalance;

                        break;
                    }
                }

                if (FileDbContext.saveListToFile(clientsList, false))
                {
                    Console.WriteLine();
                    Console.WriteLine("Client ({0}) Updated Successfully", accountNumber);
                    PrintClient(client);
                }
            }
        }
    }
}
