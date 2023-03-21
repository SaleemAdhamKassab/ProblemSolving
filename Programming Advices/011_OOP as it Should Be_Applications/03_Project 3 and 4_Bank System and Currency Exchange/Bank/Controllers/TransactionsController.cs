using Lab.Bank.Models;

namespace Lab.Bank.Controllers
{
    internal class TransactionsController : ClientsController
    {
        ClientsController clientsController = new ClientsController();
        public void deposit(string accountNumber, int depositeAmount)
        {
            Client client = clientsController.Get(accountNumber);
            client.AccountBalance += depositeAmount;
            clientsController.Update(client);
        }
        public void withdraw(string accountNumber, int depositeAmount) => deposit(accountNumber, -depositeAmount);
        public int clientBalance(string accountNumber) => clientsController.Get(accountNumber).AccountBalance;
        public int clientsTotalBalances()
        {
            int totalBalances = 0;
            List<object> clientsList = clientsController.Get();

            foreach (Client client in clientsList)
                totalBalances += client.AccountBalance;

            return totalBalances;
        }
        public void transfer(int transferAmount, string fromAccountNumber, string toAccountNumber)
        {
            withdraw(fromAccountNumber, transferAmount);
            deposit(toAccountNumber, transferAmount);
        }
    }
}