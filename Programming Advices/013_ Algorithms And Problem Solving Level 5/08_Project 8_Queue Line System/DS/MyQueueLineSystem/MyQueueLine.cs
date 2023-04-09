using Lab.DS.MyQueueLineSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.DS
{
    internal class MyQueueLine
    {
        string _prefix;
        int _totalTickets = 0;
        int _avgServeTime = 0;
        int _servedClients = 0;

        Queue<Ticket> queueLine = new Queue<Ticket>();

        public MyQueueLine(string prefix, int avgServTime)
        {
            _prefix = prefix;
            _avgServeTime = avgServTime;
        }
        public void issueTicket()
        {
            Ticket ticket = new Ticket(_prefix + (queueLine.Count + 1),
                                      queueLine.Count,
                                      _avgServeTime);
            queueLine.Enqueue(ticket);
            _totalTickets++;
        }
        public void servNextClient()
        {
            queueLine.Dequeue();
            _servedClients++;
        }
        public void printTicketsLineRTL()
        {
            Console.Write("Tickets (RTL): ");
            for (int i = 0; i < queueLine.Count; i++)
                Console.Write("{0} <-- ", queueLine.ElementAt(i).getName());

            Console.WriteLine();
        }
        public void printTicketsLineLTR()
        {
            Console.Write("Tickets (LTR): ");
            for (int i = queueLine.Count - 1; i >= 0; i--)
                Console.Write("{0} --> ", queueLine.ElementAt(i).getName());

            Console.WriteLine();
        }
        public void printInfo()
        {
            Console.WriteLine("_____________");
            Console.WriteLine("Queue Info");
            Console.WriteLine("_____________");

            Console.WriteLine("Prefix = {0}", _prefix);
            Console.WriteLine("Total Tickets: {0}", _totalTickets);
            Console.WriteLine("Served Clients = {0}", _servedClients);
            Console.WriteLine("Waiting Clients = {0}", _totalTickets - _servedClients);
            Console.WriteLine("_____________");
        }
        public void printAllTickets()
        {
            for (int i = 0; i < queueLine.Count; i++)
                Ticket.printTicket(queueLine.ElementAt(i));
        }
    }
}
