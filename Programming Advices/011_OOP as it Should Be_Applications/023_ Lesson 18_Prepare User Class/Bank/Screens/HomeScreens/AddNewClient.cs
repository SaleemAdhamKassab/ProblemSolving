using Lab.Class.Bank;
using Labs.Bank.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Bank.Screens
{
    internal class AddNewClient : Screen
    {
        public static void Add()
        {
            try
            {
                drawScreenHeader("Add New Client");

                string accountNumber = readClientOneInfo("Enter Account Number: ").ToString();

                while (IsClientExist(accountNumber))
                    accountNumber = readClientOneInfo("Account Number (" + accountNumber + ") is already used, choose another one: ").ToString();

                BankClient client = readClientInfo(accountNumber);
                client.AccountNumber = accountNumber;

                if (FileDbContext.saveRowToFile(FileDbContext.convertClientObjectToRowStringForSaving(client)))
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