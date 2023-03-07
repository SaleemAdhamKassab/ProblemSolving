using Lab.Class.Bank;
using Lab.Bank.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Bank.Screens
{
    internal class AddNewClient : Screen
    {
        public static void Add()
        {
            try
            {
                drawScreenHeader("Add New Client");

                string accountNumber = readOneInfo("Enter Account Number: ").ToString();

                while (IsClientExist(accountNumber))
                    accountNumber = readOneInfo("Account Number (" + accountNumber + ") is already used, choose another one: ").ToString();

                BankClient client = readClientInfo(accountNumber);
                client.AccountNumber = accountNumber;

                if (FileDbContext.saveRowToFile(FileDbContext.ClientsDbConnectionString, FileDbContext.convertClientObjectToRowStringForSaving(client)))
                {
                    PrintClient(client);
                    Console.WriteLine("Client ({0}) Added Successfully", accountNumber);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}