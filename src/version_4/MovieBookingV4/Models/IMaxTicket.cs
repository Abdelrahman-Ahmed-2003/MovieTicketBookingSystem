using System;
using System.Collections.Generic;
using System.Text;

namespace MovieBookingV4.Models
{
    internal class IMaxTicket: Ticket
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

        public override string ToString()
        {
            return base.ToString() + " | IMAX 3D: " + ((Is3D) ? "Yes" : "No");
        }

        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine($"IMAX 3D: {(Is3D ? "Yes" : "No")}");
        }
    }
}
