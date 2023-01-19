using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class Person
    {
        private int _Id = 10;
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _phone;

        public Person(int id, string firstName, string lastName, string email, string phone)
        {
            _Id = id;
            _firstName = firstName;
            _lastName = lastName;
            _email = email;
            _phone = phone;
        }

        //Setters and getters
        public int getId() => _Id;
        public void setId(int id) => _Id = id;

        public void setFirstName(string firstName) => _firstName = firstName;
        public string getFirstName() => _firstName;

        public void setLastName(string lastName) => _lastName = lastName;
        public string getLastName() => _lastName;

        public void setEmail(string email) => _email = email;
        public string getEmail() => _email;

        public void setPhone(string phone) => _phone = phone;
        public string getPhone() => _phone;
        //***********************************************************************

        public void printInfo()
        {
            Console.WriteLine("User Info: ");
            Console.WriteLine("______________________________________");
            Console.WriteLine("ID : {0}", getId());
            Console.WriteLine("First Name: {0}", getFirstName());
            Console.WriteLine("Last Name: {0}", getLastName());
            Console.WriteLine("Email: {0}", getEmail());
            Console.WriteLine("Phone: {0}", getPhone());
        }

        public void sendEmail(string subject, string body)
        {
            Console.WriteLine("The following message sent successfully to email: " + getEmail());
            Console.WriteLine();
            Console.WriteLine("Subject : {0}", subject);
            Console.WriteLine("Body : {0}", body);
        }

        public void sendSMS(string message)
        {
            Console.WriteLine("The following message sent successfully to Phone: " + getPhone());
            Console.WriteLine(message);
        }
    }
}
