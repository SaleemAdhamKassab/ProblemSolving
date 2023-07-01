using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class Employee : Person
    {
        private double _salary;
        private string _department;
        private string _title;

        public Employee(int id, string firstName, string lastName,
                        string email, string phone,
                        double salary, string department, string title) : base(id, firstName, lastName, email, phone)
        {
            _salary = salary;
            _department = department;
            _title = title;
        }

        public void setSalary(double salary) => _salary = salary;
        public double getSalary() => _salary;

        public void setDepartment(string department) => _department = department;
        public string getDepartment() => _department;

        public void setTitle(string title) => _title = title;
        public string getTitle() => _title;

        public void printInfo()
        {
            Console.WriteLine("User Info: ");
            Console.WriteLine("______________________________________");
            Console.WriteLine("ID : {0}", getId());
            Console.WriteLine("First Name: {0}", getFirstName());
            Console.WriteLine("Last Name: {0}", getLastName());
            Console.WriteLine("Email: {0}", getEmail());
            Console.WriteLine("Phone: {0}", getPhone());

            Console.WriteLine("Department: {0}", getDepartment());
            Console.WriteLine("Title: {0}", getTitle());
            Console.WriteLine("Salary: {0}", getSalary());
        }
    }
}
