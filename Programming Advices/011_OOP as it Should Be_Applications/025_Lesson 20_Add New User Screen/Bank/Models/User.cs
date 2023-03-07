using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Bank.Screens.ManageUsers
{
    public class User : Person
    {
        public User(string firstName, string lastName, string email, string phone,
                    string userName, string password, int persmissions) :
            base(firstName, lastName, email, phone)
        {
            UserName = userName;
            Password = password;
            Permissions = persmissions;
        }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Permissions { get; set; }
    }
}
