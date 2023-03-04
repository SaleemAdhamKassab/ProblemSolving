using Lab.Class.Bank;
using Labs.Bank.Screens;
using Labs.Bank.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Bank.Screens
{
    internal class FindClient : Screen
    {
        public static void Find()
        {
            string accountNumber = "";

            Console.Clear();
            drawScreenHeader("Find Client");
            accountNumber = readClientOneInfo("Enter Account Number: ").ToString();

            while (!IsClientExist(accountNumber))
                accountNumber = readClientOneInfo("Account Number (" + accountNumber + ") is not found, choose another one: ").ToString();

            PrintClient(findClient(accountNumber));
        }

    }
}
