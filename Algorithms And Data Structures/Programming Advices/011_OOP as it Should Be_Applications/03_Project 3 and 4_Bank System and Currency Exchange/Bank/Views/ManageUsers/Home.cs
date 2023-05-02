using Lab.Bank.Views.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Bank.Views.ManageUsers
{
    internal class Home
    {
        Print print = new Print();
        Find find = new Find();
        Add add = new Add();
        Delete delete = new Delete();
        Update update = new Update();
        Login login = new Login();

        public void performPrintClientsView() => print.printUsers();
        public void perfoemFindUserView() => find.FindUser();
        public void perfoemAddClientView() => add.AddNewUser();
        public void perfoemDeleteUserView() => delete.DeleteUser();
        public void perfoemUpdateUserView() => update.UpdateUser();
        public void perfoemUserLoginView() => login.login();

    }
}
