using MovieBookingV4.Models;

namespace MovieBookingV4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cinema cinema = new Cinema("Cinema name");
            cinema.OpenCinema();

            StandardTicket standardTicket = new StandardTicket("Inception", 120, "A-5");
            VIPTicket vipTicket = new VIPTicket(true, 50, "Avengers", 200);
            IMaxTicket imaxTicket = new IMaxTicket(false,"Dune", 180);

            Console.WriteLine("\n\n========== SetPrice Test ========== ");
            standardTicket.SetPrice(150m);
            standardTicket.SetPrice(100m, 1.5m);

            cinema.AddTicket(standardTicket);
            cinema.AddTicket(vipTicket);
            cinema.AddTicket(imaxTicket);

            cinema.PrintAllTickets();

            ProcessTicket(vipTicket);
            Console.WriteLine("\n\n========== Statistics ========== ");
            Console.WriteLine($"Total Tickets Created: {cinema.TotalTickets()}");
            //PrintBookingReference(2);
            cinema.CloseCinema();
        }

        public static void ProcessTicket(Ticket t)
        {
            Console.WriteLine("\n\n========== Process Single Ticket ==========");
            t.PrintTicket();
        }
    }
}
