using MoviewBookingV6.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieBookingV6.Models
{
    internal partial class Cinema : IPrintable
    {
        public string CinemaName { get; set; }
        private Ticket[] _tickets = new Ticket[20];

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
