using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridChallenge
{
    class Program
    {
        public const int NumberOfEvents = 10;
        List<Coordinates> Events = new List<Coordinates>();


        static void Main(string[] args)
        {
            Grid grid = new Grid(new Coordinates { x = -10, y = -10 }, new Coordinates { x = 10, y = 10 });

            Random r = new Random(); //Static Random isn't used here as we don't want the same set of coordinates twice.

            for (var i = 0; i < NumberOfEvents; i++)
            {
                int randomXCoord = r.Next(grid.XMin, grid.XMax);
                int randomYCoord = r.Next(grid.YMin, grid.YMax);
                Event myEvent = new Event(new Coordinates { x = randomXCoord, y = randomYCoord }, i);

                var ticketPrice = myEvent.Tickets.FirstOrDefault().TicketPriceString;

                //Console.WriteLine(randomXCoord.ToString() +"," + randomYCoord.ToString() + " EventID: " + i);
                Console.WriteLine("Event " + myEvent.UniqueID + " - " + ticketPrice);
            }


            
            Console.ReadKey();
        }



    }
}
