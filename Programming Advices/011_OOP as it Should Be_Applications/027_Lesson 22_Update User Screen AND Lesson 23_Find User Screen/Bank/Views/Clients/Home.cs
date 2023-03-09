using Lab.Bank.Views.Transactions;

namespace Lab.Bank.Views.Clients
{
    internal class Home
    {
        Print print = new Print();
        Find find = new Find();
        Add add = new Add();
        Delete delete = new Delete();
        Update update = new Update();
        StartTransactions transactions = new StartTransactions();

        public void performPrintClientsView() => print.PrintClients();
        public void perfoemFindClientView() => find.FindClient();
        public void perfoemAddClientView() => add.AddNewClient();
        public void perfoemDeleteClientView() => delete.DeleteClient();
        public void perfoemUpdateClientView() => update.UpdateClient();
        public void startTransactionsHomeView() => transactions.start();
    }
}
