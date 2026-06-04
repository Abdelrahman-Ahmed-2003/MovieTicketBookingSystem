using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace MovieBookingV4.Models
{
    internal class Ticket
    {
        private string? _movieName;

        private decimal _price;

        private static int _ticketCounter = 0;
        public int TicketId { get; private set; }



        public static int GetTotalTicketsSold()
        {
            return _ticketCounter;
        }
        public string? MovieName
        {
            get { return _movieName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _movieName = value;
                }
            }
        }

        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
            }
        }


        public Ticket(string movieName,decimal price)
        {
            MovieName = movieName;

            _price = price;
            ++_ticketCounter;
            TicketId = _ticketCounter;
        }

        public decimal PriceAfterTax
        {
            get
            {
                return _price + (_price * 0.14m);
            }
            
        }


        //public override string ToString()
        //{
        //    return $"Movie: {MovieName}, TicketID: {TicketId}, Price: {_price:C}, Price after tax: {PriceAfterTax}";
        //}

        public virtual void PrintTicket()
        {
            Console.WriteLine($"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP");
        }

        public void SetPrice(decimal price)
        {
            Price = price;
            Console.WriteLine($"Setting price directly: {Price}");
        }

        public void SetPrice(decimal basePrice, decimal multiplier)
        {
            Price = basePrice * multiplier;
            Console.WriteLine($"Setting price with multiplier: {basePrice} x {multiplier} = {Price} ");
        }
    }
}
