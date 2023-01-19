using Lab;

namespace lab
{
    class Program
    {
        static void Main()
        {
            Person person1 = new Person(10, "Saleem", "Kassab", "e.s.a.kassab@gmail.com",
                                        "00963-959-270-763");
            person1.printInfo();

            Console.WriteLine();

            Employee employee = new Employee(20, "Nassem", "Kassab", "nassem.kassab@gmail.com",
                                            "00963-565-364-643",
                                            2000, "FMU", "Electronic Engineer");
            employee.printInfo();
        }
    }
}