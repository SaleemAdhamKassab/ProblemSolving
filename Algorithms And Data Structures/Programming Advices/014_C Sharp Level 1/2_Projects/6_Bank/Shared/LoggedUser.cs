using Lab.Bank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Shared
{
    public static class LoggedUser
    {
        public static User loggedUser = new User("", "", "", "", "", "", 0);
        public static int loginFailedAttempts = 0;
    }
}
