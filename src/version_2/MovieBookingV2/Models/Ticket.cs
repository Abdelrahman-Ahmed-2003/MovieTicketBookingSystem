using MovieBookingV1.Enums;
using MovieBookingV1.Structs;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieBookingV2.Models
{
    internal class Ticket
    {
        private string? _movieName;
        public TicketType Type { get; set; }

        public Seat Seat { get; set; }

        private double _price;

        private static int _ticketCounter = 0;
        public int TicketId {  get; private set; }


        public static int TicketCounter
        {
            get { return _ticketCounter; }
            private set { _ticketCounter = value; }
        }

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

        public double Price
        {
            get { return _price; }
            set
            {
                if (value >= 0)
                {
                    _price = value;
                }
            }
        }


        public Ticket(string movieName)
        {
            MovieName = movieName;
            Type = TicketType.Standard;
            
            Seat = new Seat('A',1);
            _price = 50.0;
            ++_ticketCounter;
            TicketId = _ticketCounter;
        }

        public Ticket(string movieName, TicketType type, Seat seat, double price)
        {
            this.MovieName = movieName;
            this.Type = type;
            this.Seat = seat;
            this._price = price;
            ++_ticketCounter;
            TicketId = _ticketCounter;

        }

        public double PriceAfterTax(double taxPercent)
        {
            return _price + (_price * taxPercent / 100);
        }

        public double CalcTotal(double taxPercent)
        {
            return _price + (_price*taxPercent/100);
        }

        public void ApplyDiscount(ref double discountAmount)
        {
            
            if(discountAmount >=0 && discountAmount < _price)
            {
                discountAmount = 0.0;
                _price -= discountAmount;
            }
            
            Console.WriteLine("\n===== After Discount =====");
            Console.WriteLine($"Discount Before : {discountAmount:F2}");
            Console.WriteLine($"Discount After  : {discountAmount:F2}");
            Console.WriteLine($"Movie    : {MovieName}");
            Console.WriteLine($"Type     : {Type}");
        }

        public override string ToString()
        {
            return $"Movie: {MovieName}, Type: {Type}, Seat: {Seat}, Price: {_price:C}";
        }

        public void PrintTicket()
        {
            Console.WriteLine("\n===== Ticket Info ===== ");
            Console.WriteLine($"Movie    : {MovieName}");
            Console.WriteLine($"Type     : {Type.ToString()}");
            Console.WriteLine($"Seat     : {this.Seat.ToString()}");
            Console.WriteLine($"Price    : {_price:F2}");
            Console.WriteLine($"Total ({14}% Tax) : {CalcTotal(14):F2}");
        }
    }
}
