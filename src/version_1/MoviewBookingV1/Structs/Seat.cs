using System;
using System.Collections.Generic;
using System.Text;

namespace MovieBookingV1.Structs
{
    internal struct Seat
    {
        public char Row { get; set; }
        public int Number { get; set; }

        public Seat(char row, int number)
        {
            Row = row;
            Number = number;
        }

        public override string ToString()
        {
            return $"{Row}{Number}";
        }
    }
}
