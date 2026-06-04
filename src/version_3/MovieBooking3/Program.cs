using MovieBooking3.Models;

namespace MovieBooking3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cinema cinema = new Cinema("StarLight Cinema");
            cinema.OpenCinema();

            StandardTicket standardTicket = new StandardTicket("Inception", 120, "A-5");
            VIPTicket vipTicket = new VIPTicket(loungeAccess:true,serviceFees:50,movieName:"Avengers",price: 200);
            IMaxTicket imaxTicket = new IMaxTicket(true,"Dune", 180);
            cinema.AddTicket(standardTicket);
            cinema.AddTicket(vipTicket);
            cinema.AddTicket(imaxTicket);

            cinema.PrintAllTickets();

            Console.WriteLine("\n\n========== Statistics ========== ");
            Console.WriteLine($"Total Tickets Created: {cinema.TotalTickets()}");
            //PrintBookingReference(2);
            cinema.CloseCinema();
        }
    }
}
