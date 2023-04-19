using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.DS.MyQueueLineSystem
{
    internal class Ticket
    {
        public string _name { get; set; }
        int _waitingClients { get; set; }
        int _serveTimeInMinutes { get; set; }
        string _date { get; set; }

        public Ticket(string name, int waitingClients, int avgServTime)
        {
            _name = name;
            _waitingClients = waitingClients;
            _serveTimeInMinutes = avgServTime * waitingClients;
            _date = DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss");
        }
        public string getName() => _name;
        public static void printTicket(Ticket ticket)
        {
            Console.WriteLine("_______________________");
            Console.WriteLine(ticket._name);
            Console.WriteLine(ticket._date);
            Console.WriteLine("Waiting Clients = {0}", ticket._waitingClients);
            Console.WriteLine("Serve Time In {0} Minutes", ticket._serveTimeInMinutes);
            Console.WriteLine("_______________________");
        }
    }
}
