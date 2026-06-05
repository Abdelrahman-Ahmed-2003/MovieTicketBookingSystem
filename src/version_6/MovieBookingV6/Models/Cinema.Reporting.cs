using MoviewBookingV6.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieBookingV6.Models
{
    internal partial class Cinema
    {
        private Projector _projector = new Projector();
    

    public void Print()
        {
            Console.WriteLine("\n\n========== All Tickets ==========");

            foreach (IPrintable item in _tickets)
            {
                if (item == null) break;

                item.Print();
            }
        }

        public void PrintAllTickets()
        {
            Console.WriteLine("\n\n========== All Tickets ==========");
            for (int i = 0; i < _tickets.Length; i++)
            {
                if (_tickets[i] == null) break;
                _tickets[i].Print();
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
    }
}
