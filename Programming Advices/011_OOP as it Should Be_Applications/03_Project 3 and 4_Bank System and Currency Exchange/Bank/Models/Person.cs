using Lab.Bank.Shared;

namespace Lab
{
    public class Person: ICommunication
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Person(string firstName, string lastName, string email, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
        }
        public string fullName() => FirstName + " " + LastName;

        public void sendEmail(string title, string body)
        {
            throw new NotImplementedException();
        }

        public void sendFax(string title, string body)
        {
            throw new NotImplementedException();
        }

        public void sendSms(string title, string body)
        {
            throw new NotImplementedException();
        }
    }
}