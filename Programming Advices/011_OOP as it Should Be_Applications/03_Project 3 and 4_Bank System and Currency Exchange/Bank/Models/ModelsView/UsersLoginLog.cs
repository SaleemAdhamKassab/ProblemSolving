namespace Lab.Bank.Models
{
    public class UsersLoginLog : User
    {
        public UsersLoginLog(string logDate, string firstName, string lastName, string email, string phone, string userName, string password, int persmissions)
            : base(firstName, lastName, email, phone, userName, password, persmissions) => LogDate = logDate;
        public string LogDate { get; set; }
    }
}