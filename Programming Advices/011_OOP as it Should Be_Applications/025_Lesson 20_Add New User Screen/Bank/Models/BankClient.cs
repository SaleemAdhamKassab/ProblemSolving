using Lab.Classes;
using Lab.Bank.Db;
using Lab.Bank.Screens;

namespace Lab.Class.Bank
{
    public class BankClient : Person
    {
        public BankClient(string accountNumber,
                          string pinCode,
                          string firstName,
                          string lastName,
                          string email,
                          string phone,
                          double accountBalance) : base(firstName, lastName, email, phone)
        {
            AccountNumber = accountNumber;
            PinCode = pinCode;
            AccountBalance = accountBalance;
        }
        public string AccountNumber { get; set; }
        public string PinCode { get; set; }
        public double AccountBalance { get; set; }        
    }
}