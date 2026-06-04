using MovieBookingV1.Enums;
using MovieBookingV1.Models;
using MovieBookingV1.Structs;

namespace MovieBookingV1
{
    internal class Program
    {

        public static void ReadInputs(out string? movieName, out TicketType type, out Seat seat, out double price, out double discountAmount)
        {
            Console.Write("Enter Movie Name: ");
            movieName = Console.ReadLine();

            bool isParsed;

            do
            {
                Console.Write("Enter Ticket Type (0 = Standard , 1 = VIP , 2 = IMAX ): ");
                isParsed = Enum.TryParse<TicketType>(Console.ReadLine(), out type);
            }
            while (!isParsed || !Enum.IsDefined(type));
            char row;
            do
            {
                Console.Write("Enter Seat Row (A, B, C...): ");
                isParsed = char.TryParse(Console.ReadLine(), out row);
            } while (!isParsed);

            int number;
            do
            {
                Console.Write("Enter Seat Number: ");
                isParsed = Int32.TryParse(Console.ReadLine(), out number);
            } while (!isParsed);

            seat = new Seat(row, number);

            do
            {
                Console.Write("Enter Price: ");
                isParsed = double.TryParse(Console.ReadLine(), out price);
            } while (!isParsed);

            do
            {
                Console.Write("Enter Discount Amount: ");
                isParsed = double.TryParse(Console.ReadLine(), out discountAmount);
            } while (!isParsed);
        }



            static void Main(string[] args)
            {
                ReadInputs(out string? movieName, out TicketType type, out Seat seat, out double price, out double discountAmount);
                Ticket ticket01 = new Ticket(movieName, type, seat, price);
                double total = ticket01.CalcTotal(14);

                ticket01.PrintTicket();

                ticket01.ApplyDiscount(ref discountAmount);
            }

        }
    
}
