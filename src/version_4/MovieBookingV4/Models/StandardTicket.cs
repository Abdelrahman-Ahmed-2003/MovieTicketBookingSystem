using System;
using System.Collections.Generic;
using System.Text;

namespace MovieBookingV4.Models
{
    internal class StandardTicket(string movieName, decimal price, string seatNumber) : Ticket(movieName, price)
    {
        public string SeatNumber { get; set; } = seatNumber;
        //public override string ToString()
        //{
        //    return $"{base.ToString()}, Seat: {SeatNumber}";
        //}

        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine($"Seat Number: {SeatNumber}");
        }
    }
}
