using MovieBookingV2.Helper;
using MovieBookingV5.Models;
using MoviewBookingV5.Interfaces;

namespace MoviewBookingV5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cinema cinema = new Cinema("Cinema");
            cinema.OpenCinema();

            StandardTicket standardTicket = new StandardTicket("Inception", 80, "A5");
            VIPTicket vipTicket = new VIPTicket(true,50,"Avengers", 200);
            IMaxTicket imaxTicket = new IMaxTicket(true,"Dune", 130);
            standardTicket.Book();
            vipTicket.Book();
            imaxTicket.Book();

            cinema.AddTicket(standardTicket);
            cinema.AddTicket(vipTicket);
            cinema.AddTicket(imaxTicket);

            cinema.Print();

            Console.WriteLine("\n\n--- Clone Test --- ");
            VIPTicket vipTicket2 = (VIPTicket)vipTicket.Clone();
            vipTicket2.MovieName = "Interstellar";
            Console.Write("Original: ");
            vipTicket.PrintTicket();
            Console.Write("Clone: ");
            vipTicket2.PrintTicket();


            standardTicket.Cancel();
            Console.WriteLine("\n\n--- After Cancellation ---");
            standardTicket.PrintTicket();


            Console.WriteLine("\n\n--- BookingHelper.PrintAll ---");
            BookingHelper.PrintObjects(new IPrintable[] { standardTicket, vipTicket, imaxTicket });

            cinema.CloseCinema();
        }
    }
}
