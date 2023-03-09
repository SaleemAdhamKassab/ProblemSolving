using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Bank.Views.Transactions
{
    internal class Home
    {
        Deposite deposite = new Deposite();
        Withdraw withdraw = new Withdraw();
        TotalBalances totalBalances = new TotalBalances();
        public void performDepositeView() => deposite.DepositClientBalance();
        public void performWithdrawView() => withdraw.WithDrawClientBalance();
        public void performTotalBalancesView() => totalBalances.ClientsTotalBalances();
    }
}
