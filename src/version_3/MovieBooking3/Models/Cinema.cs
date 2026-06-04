using System;
using System.Collections.Generic;
using System.Text;

namespace MovieBooking3.Models
{
    internal class Cinema
    {
        public string CinemaName { get; set; }
        private Ticket[] _tickets = new Ticket[20];
        private Projector _projector = new Projector();

        public Cinema(string cinemaName)
        {
            CinemaName = cinemaName;
        }

        public Ticket? this[int index]
        {
            get
            {
                if (index >= 0 && index < _tickets.Length)
                    return _tickets[index];
                return null;
            }
            set
            {
                if (index >= 0 && index < _tickets.Length)
                    _tickets[index] = value;
            }
        }

        public Ticket? this[string name]
        {
            get
            {
                foreach (var ticket in _tickets)
                {
                    if (ticket?.MovieName == name) return ticket;
                }
                return null;
            }

        }

        public bool AddTicket(Ticket t)
        {
            for (int i = 0; i < _tickets.Length; i++)
            {
                if (_tickets[i] == null)
                {
                    _tickets[i] = t;
                    return true;
                }
            }
            return false;
        }

        public void PrintAllTickets()
        {
            Console.WriteLine("\n\n========== All Tickets ==========");
            for (int i = 0; i < _tickets.Length; i++)
            {
                if (_tickets[i] == null) break;
                Console.WriteLine(_tickets[i]);
            }
        }

        public void OpenCinema()
        {
            Console.WriteLine("========== Cinema Opened ========== ");
            _projector.Start();
        }

        public void CloseCinema()
        {
            Console.WriteLine("\n\n========== Cinema Closed ========== ");
            _projector.Stop();
        }

        public int TotalTickets()
        {
            int total = 0;
            for (int i = 0; i < _tickets.Length; i++)
            {
                if (_tickets[i] == null)
                    break;
                total++;
            }
            return total;
        }
    }
}
