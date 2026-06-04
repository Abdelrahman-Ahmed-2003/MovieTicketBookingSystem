using System;
using System.Collections.Generic;
using System.Text;

namespace MovieBooking3.Models
{
    internal class StandardTicket(string movieName, decimal price, string seatNumber) : Ticket(movieName, price)
    {
        public string SeatNumber { get; set; } = seatNumber;
        public override string ToString()
        {
            return $"{base.ToString()}, Seat: {SeatNumber}";
        }
    }
}
