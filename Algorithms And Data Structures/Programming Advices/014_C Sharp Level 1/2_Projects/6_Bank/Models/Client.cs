using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Bank.Models
{
    public class Client : Person
    {
        public Client(string accountNumber,
                          string pinCode,
                          string firstName,
                          string lastName,
                          string email,
                          string phone,
                          int accountBalance) : base(firstName, lastName, email, phone)
        {
            AccountNumber = accountNumber;
            PinCode = pinCode;
            AccountBalance = accountBalance;
        }
        public string AccountNumber { get; set; }
        public string PinCode { get; set; }
        public int AccountBalance { get; set; }
    }
}
