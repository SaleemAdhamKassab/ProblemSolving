using Lab.Bank.Views.ManageUsers;
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
        LoginLog loginLog = new LoginLog();

        public void performPrintClientsView() => print.printClients();
        public void perfoemFindClientView() => find.FindClient();
        public void perfoemAddClientView() => add.AddNewClient();
        public void perfoemDeleteClientView() => delete.DeleteClient();
        public void perfoemUpdateClientView() => update.UpdateClient();
        public void startTransactionsHomeView() => transactions.start();
        public void perfoemUsersLoginLogView() => loginLog.print();
    }
}
