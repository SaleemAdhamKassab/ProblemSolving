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
        public static bool Add()
        {
            try
            {
                Console.Clear();
                drawScreenHeader("Add New Client");

                string accountNumber = readClientOneInfo("Enter Account Number: ").ToString();

                while (IsClientExist(accountNumber))
                    accountNumber = readClientOneInfo("Account Number (" + accountNumber + ") is already used, choose another one: ").ToString();

                BankClient client = readClientInfo(accountNumber);
                client.AccountNumber = accountNumber;
                FileDbContext.saveRowToFile(FileDbContext.convertClientObjectToRowStringForSaving(client));
                ClientsList.PrintClient(client);

                Console.WriteLine("Client {0} Added Successfully", accountNumber);

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