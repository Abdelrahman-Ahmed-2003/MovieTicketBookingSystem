using MoviewBookingV6.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace MovieBookingV6.Models
{
    internal class VIPTicket(bool loungeAccess,decimal serviceFees,string movieName,decimal price):Ticket(movieName,price),IPrintable
    {
        public bool LoungeAccess { get; set; } = loungeAccess;
        public decimal ServiceFees { get; set; } = serviceFees;
        public override string ToString()
        {
            return $"{base.ToString()}, Lounge Access: {LoungeAccess}, Service Fees: {ServiceFees:C}";
        }

        public override void Print()
        {
            Console.Write($"[Ticket #{TicketId}] {MovieName} | VIP | Lounge: {(LoungeAccess ? "Yes" : "No")} | Fee: {ServiceFees} ");
            Console.WriteLine($"| Price: {Price} | Final: {PriceAfterTax:F2} | Booked: {(IsBooked ? "Yes" : "No")}");

        }

        public override void TypePrice()
        {
            Console.WriteLine($"VIPTicket => Final Price: {PriceAfterTax}");
        }

    }
}
