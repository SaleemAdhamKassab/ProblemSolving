using Lab.Class.Bank;
using Lab.Bank.Screens;
using Lab.Bank.Shared;
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

            drawScreenHeader("Find Client");
            accountNumber = readOneInfo("Enter Account Number: ").ToString();

            while (!IsClientExist(accountNumber))
                accountNumber = readOneInfo("Account Number (" + accountNumber + ") is not found, choose another one: ").ToString();

            PrintClient(findClient(accountNumber));
        }

    }
}
