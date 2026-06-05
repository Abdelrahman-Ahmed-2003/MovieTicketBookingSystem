using MovieBookingV6.Extensions;
using MovieBookingV6.Models;

namespace MovieBookingV6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cinema cinema = new Cinema("Cinema");
            cinema.OpenCinema();
            //Ticket t = new Ticket("Test", 100);
            Console.WriteLine("\n\n// Ticket t = new Ticket(\"Test\", 100);  // ERROR: Cannot create instance of abstract type 'Ticket'");

            StandardTicket standardTicket = new StandardTicket("Inception", 80, "A5");
            VIPTicket vipTicket = new VIPTicket(true,50,"Avengers", 200);
            IMaxTicket imaxTicket = new IMaxTicket(true,"Dune", 100);
            standardTicket.Book();
            vipTicket.Book();
            imaxTicket.Book();

            cinema.AddTicket(standardTicket);
            cinema.AddTicket(vipTicket);
            cinema.AddTicket(imaxTicket);

            cinema.Print();

            vipTicket.Reciept();
            Ticket[] tickets = { standardTicket, vipTicket, imaxTicket };
            tickets.TotalRevenue();

            cinema.CloseCinema();
        }
    }
}
