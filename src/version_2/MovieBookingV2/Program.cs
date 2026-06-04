using MovieBookingV2.Helper;
using MovieBookingV2.Models;
using MovieBookingV1.Enums;
using MovieBookingV1.Structs;

namespace MovieBookingV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadTickets(3, out Cinema cinema);

            PrintAllTickets(cinema);
            SearchByMovieName(cinema);

            Console.WriteLine($"\n\nTotal tickets sold: {TotalTicketsSold(cinema)}"); ;
            PrintBookingReference(2);

            Console.WriteLine($"\n\nTotal discount for a group of 5 tickets at 80 EGP each of them: {TotalDiscount(5, 80)} EGP");
        }

        public static void ReadTicket(out string? movieName, out TicketType type, out Seat seat, out double price)
        {
            Console.Write("Movie Name: ");
            movieName = Console.ReadLine();



            bool isParsed;

            do
            {
                Console.Write("Ticket Type (0 = Standard , 1 = VIP , 2 = IMAX ): ");
                isParsed = Enum.TryParse<TicketType>(Console.ReadLine(), out type);
            }
            while (!isParsed || !Enum.IsDefined(type));
            char row;
            bool isUpper = false;
            do
            {
                Console.Write("Seat Row (A-Z): ");
                isParsed = char.TryParse(Console.ReadLine(), out row);
                isUpper = isParsed && row >= 'A' && row <= 'Z';
            } while (!isUpper);

            int number;
            do
            {
                Console.Write("Seat Number: ");
                isParsed = Int32.TryParse(Console.ReadLine(), out number);
            } while (!isParsed);

            seat = new Seat(row, number);

            do
            {
                Console.Write("Price: ");
                isParsed = double.TryParse(Console.ReadLine(), out price);
            } while (!isParsed);

        }

        public static void ReadTickets(int numberofTicket, out Cinema cinema)
        {
            cinema = new Cinema();
            string? movieName;
            TicketType type;
            Seat seat;
            double price;

            Console.WriteLine("========== Ticket Booking ==========");
            for (int i = 1; i <= numberofTicket; i++)
            {
                Console.WriteLine($"\n\nEnter data for Ticket {i}:");
                ReadTicket(out movieName, out type, out seat, out price);
                cinema.AddTicket(new Ticket(movieName, type, seat, price));
            }

        }
        public static void PrintAllTickets(Cinema cinema)
        {
            Console.WriteLine("\n\n========== All Tickets ==========\n\n");
            foreach (var ticket in cinema)
            {
                Console.WriteLine($"Ticket #{ticket.TicketId} | {ticket.MovieName} | {ticket.Type} | Seat: {ticket.Seat} | Price: {ticket.Price} EGP | After Tax: {ticket.PriceAfterTax} EGP");
            }
        }

        public static void SearchByMovieName(Cinema cinema)
        {
            string? movieName;
            Console.WriteLine("\n\n========== Search by Movie ========== ");
            Console.Write("Enter movie name to search: ");
            movieName = Console.ReadLine();

            int count = 0;
            foreach (var ticket in cinema)
            {
                count++;
                if (ticket.MovieName?.ToLower() == movieName?.ToLower())
                {
                    Console.WriteLine($"Found: Ticket #{count} | {ticket.MovieName} | {ticket.Type} | Seat: {ticket.Seat} | Price: {ticket.Price} EGP");
                    return;
                }
            }
            Console.WriteLine("Not Found :-(");
        }

        public static void PrintBookingReference(int numberOfReferences)
        {
            Console.WriteLine("\n\n========== Booking References ========== ");
            for (int i = 0; i < numberOfReferences; i++)
            {
                Console.WriteLine($"Reference #{i + 1}: {BookingHelper.GenerateBookingId()}");
            }
        }

        public static double TotalDiscount(int numberOfTickets, double pricePerTicket)
        {
            double totalPrice = numberOfTickets * pricePerTicket;
            double priceAfterDiscount = BookingHelper.CalcGroupDiscount(numberOfTickets, pricePerTicket);
            return totalPrice -= priceAfterDiscount;
        }
        public static int TotalTicketsSold(Cinema cinema)
        {
            return cinema.Count();
        }
    }
}
