using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace MovieBookingV5.Models
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
            Console.WriteLine($"  Lounge: {(LoungeAccess ? "Yes" : "No")} | Service Fee: {ServiceFees} EGP | Booked: {(IsBooked ? "Yes" : "No")}");

        }

        public override Ticket Clone()
        {
            return new VIPTicket(this.LoungeAccess, this.ServiceFees, this.MovieName ?? "Unknown", this.Price);
        }

    }
}
