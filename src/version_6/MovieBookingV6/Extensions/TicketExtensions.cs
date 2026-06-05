using MovieBookingV6.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieBookingV6.Extensions
{
    internal static class TicketExtensions
    {
        public static void Reciept(this Ticket ticket)
        {
            Console.WriteLine("\n\n--- Extension Method: Receipt --- ");
            Console.WriteLine($"========== RECEIPT ========== ");
            Console.WriteLine($"  Movie    : {ticket.MovieName} ");
            Console.WriteLine($"  Type     : {ticket.GetType().Name} ");
            Console.WriteLine($"  Price    : {ticket.Price} ");
            Console.WriteLine($"  Final    : {ticket.PriceAfterTax} ");
            Console.WriteLine($"  Status   : {(ticket.IsBooked ? "Booked" : "Canceled")} ");
            Console.WriteLine($"============================= ");
        }

        public static void TotalRevenue(this Ticket[] tickets)
        {
            decimal totalRevenue = 0;
            foreach (Ticket ticket in tickets)
            {
                if (ticket == null) break;
                totalRevenue += ticket.PriceAfterTax;
            }
            Console.WriteLine("\n\n--- Extension Method: Total Revenue ---");
            Console.WriteLine($"Total Revenue: {totalRevenue}");
        }
    }
}
