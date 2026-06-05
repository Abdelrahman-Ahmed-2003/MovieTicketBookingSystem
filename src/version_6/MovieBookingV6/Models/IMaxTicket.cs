using MoviewBookingV6.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieBookingV6.Models
{
    internal class IMaxTicket: Ticket,IPrintable
    {
        public IMaxTicket(bool is3D, string movieName, decimal price):base(movieName, price)
        {
            Is3D = is3D;
        }
        private bool _is3D;
        public bool Is3D
        {
            get { return _is3D; }
            set
            {
                if (value && !_is3D)
                    Price += 30;
                else if (!value && _is3D)
                    Price -= 30;

                _is3D = value;

            }
        }

        //public override string ToString()
        //{
        //    return base.ToString() + " | IMAX 3D: " + ((Is3D) ? "Yes" : "No");
        //}

        public override void Print()
        {
            Console.Write($"[Ticket #{TicketId}] {MovieName} | IMAX | 3D: {(Is3D ? "Yes" : "No")} ");
            Console.WriteLine($"| Price: {Price} | Final: {PriceAfterTax:F2} | Booked: {(IsBooked ? "Yes" : "No")}");
        }

        public override void TypePrice()
        {
            Console.WriteLine($"IMAXTicket => Final Price: {PriceAfterTax}");
        }
    }
}
