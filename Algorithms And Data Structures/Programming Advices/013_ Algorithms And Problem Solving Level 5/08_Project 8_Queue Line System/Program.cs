using Lab;
using Lab.DS;

namespace lab
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueueLine payBillsQueueLine = new MyQueueLine("A0", 10);

            payBillsQueueLine.issueTicket();
            payBillsQueueLine.issueTicket();
            payBillsQueueLine.issueTicket();
            payBillsQueueLine.issueTicket();
            payBillsQueueLine.issueTicket();

            Console.WriteLine("Pay Bills Queue Info: ");
            payBillsQueueLine.printInfo();
            Console.WriteLine();

            Console.WriteLine("Tickets Breif: ");
            payBillsQueueLine.printTicketsLineRTL();
            payBillsQueueLine.printTicketsLineLTR();
            Console.WriteLine();

            Console.WriteLine("Tickets Details: ");
            payBillsQueueLine.printAllTickets();
            Console.WriteLine();


            Console.WriteLine("Pay Bills Queue After Serving one client: ");
            payBillsQueueLine.servNextClient();
            payBillsQueueLine.printInfo();
        }
    }
}
