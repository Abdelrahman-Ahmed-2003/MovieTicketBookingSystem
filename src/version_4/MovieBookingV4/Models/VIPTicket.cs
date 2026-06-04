using System;
using System.Collections.Generic;
using System.Text;

namespace MovieBookingV4.Models
{
    internal class VIPTicket(bool loungeAccess,decimal serviceFees,string movieName,decimal price):Ticket(movieName,price)
    {
        public bool LoungeAccess { get; set; } = loungeAccess;
        public decimal ServiceFees { get; set; } = serviceFees;
        public override string ToString()
        {
            return $"{base.ToString()}, Lounge Access: {LoungeAccess}, Service Fees: {ServiceFees:C}";
        }

        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine($"Lounge Access: {(LoungeAccess ? "Yes" : "No")}");
            Console.WriteLine($"Service Fees: {ServiceFees:C}");
        }

    }
}
