using MoviewBookingV5.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieBookingV2.Helper
{
    internal static class BookingHelper
    {
        private static int _counter = 0;
        public static double CalcGroupDiscount(int numOfTickets, double pricePerTicket)
        {
            if (numOfTickets >= 5)
            {
                return pricePerTicket * 0.1; // 10% discount for groups of 5 or more
            }
            return pricePerTicket;
        }

        public static string GenerateBookingId()
        {
            _counter++;
            return $"BK-{_counter}";
        }

        public static void PrintObjects(IPrintable[] printables)
        {
            foreach (var printable in printables)
            {
                printable.PrintTicket();
            }
        }
    }
}
