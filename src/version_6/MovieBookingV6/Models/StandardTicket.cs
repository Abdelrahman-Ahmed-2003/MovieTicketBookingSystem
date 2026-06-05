using MoviewBookingV6.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieBookingV6.Models
{
    internal class StandardTicket(string movieName, decimal price, string seatNumber) : Ticket(movieName, price),IPrintable
    {
        public string SeatNumber { get; set; } = seatNumber;
        //public override string ToString()
        //{
        //    return $"{base.ToString()}, Seat: {SeatNumber}";
        //}

        public override void Print()
        {
            Console.Write($"[Ticket #{TicketId}] {MovieName} | Standard | Seat: {SeatNumber} ");
            Console.WriteLine($"| Price: {Price} | Final: {PriceAfterTax:F2} | Booked: {(IsBooked ? "Yes" : "No")}");
        }

        public override void TypePrice()
        {
            Console.WriteLine($"StandardTicket => Final Price: {PriceAfterTax}");
        }
    }
}
