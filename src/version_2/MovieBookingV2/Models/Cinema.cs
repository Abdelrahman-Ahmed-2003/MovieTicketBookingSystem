using MovieBookingV2.Models;
using System;
using System.Collections.Generic;
using System.Text;

using System.Collections;
using System.Linq;
using System.Threading.Tasks;
namespace MovieBookingV2.Models
{
    internal class Cinema : IEnumerable<Ticket>
    {
        private Ticket?[] _tickets = new Ticket[20];
        public Ticket? this[int index]
        {
            get
            {
                if (index < 0 || index > 20)
                {
                    return _tickets[index];
                }
                else return null;
            }

            set
            {
                if(index < 20)
                {
                    _tickets[index] = value;
                }
            }

        }

        public Ticket? this[string name]
        {
            get
            {
                foreach (var ticket in _tickets)
                {
                    if (ticket != null && ticket.MovieName == name)
                    {
                        return ticket;
                    }
                }
                return null;
            }
        }

        public bool AddTicket(Ticket ticket)
        {
            for (int i = 0; i < _tickets.Length; i++)
            {
                if (_tickets[i] == null)
                {
                    _tickets[i] = ticket;
                    return true;
                }
            }
            return false;
        }
        //i do this with search
        public IEnumerator<Ticket> GetEnumerator()
        {
            return _tickets.Where(t => t != null)
                           .Cast<Ticket>()
                           .GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
