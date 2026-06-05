using System;
using System.Collections.Generic;
using System.Text;

namespace MovieBookingV6.Models
{
    internal class Projector
    {
        public void Start()
        {
            Console.WriteLine("📽️ Projector is turning ON... Streaming movie to the big screen.");
        }

        public void Stop()
        {
            Console.WriteLine("🔌 Projector is turning OFF... Going into standby mode.");
        }
    }
}
