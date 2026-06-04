using MovieBookingV1.Enums;
using MovieBookingV1.Structs;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieBookingV1.Models
{
    internal class Ticket
    {
        public string MovieName { get; set; }
        public TicketType Type { get; set; }

        public Seat Seat { get; set; }

        private double _price;

        public double GetPrice()
        {
            return _price;
        }

        public void SetPrice(double price)
        {
            _price = price;
        }

        public Ticket(string movieName)
        {
            MovieName = movieName;
            Type = TicketType.Standard;
            
            Seat = new Seat('A',1);
            _price = 50.0;
        }

        public Ticket(string movieName, TicketType type, Seat seat, double price)
        {
            this.MovieName = movieName;
            this.Type = type;
            this.Seat = seat;
            this._price = price;
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
            Console.WriteLine($"Price    : {GetPrice():F2}");
            Console.WriteLine($"Total ({14}% Tax) : {CalcTotal(14):F2}");
        }
    }
}
