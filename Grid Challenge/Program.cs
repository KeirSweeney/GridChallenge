using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GridChallenge
{
    class Program
    {
        private const int NumberOfEvents = 10;

        static void Main(string[] args)
        {
            Grid grid = new Grid(new Coordinates { x = -10, y = -10 }, new Coordinates { x = 10, y = 10 });
            List<Event> events = new List<Event>();
            Random r = new Random(); //Static Random isn't used here as we don't want the same set of coordinates twice.

            for (var i = 1; i < NumberOfEvents; i++)
            {
                int randomXCoord = r.Next(grid.XMin, grid.XMax);
                int randomYCoord = r.Next(grid.YMin, grid.YMax);
                Event myEvent = new Event(new Coordinates { x = randomXCoord, y = randomYCoord }, i);
                events.Add(myEvent);
            }

            Console.WriteLine("Please input Coordinates inbetween (-10,-10) & (10,10). Please use a character between each coordinate: ");
            var userCoords = Console.ReadLine();
            var distances = CalculateDistance(StringToCoords(userCoords), events);
            distances = SortEvents(distances);

            //for (int x = 0; x < 20; x++)
            //{
            //    for (int y = 0; y < 20; y++)
            //    {
            //        if (events[x].Coord.x == x && events[x].Coord.y == y)
            //        {
            //            Console.Write("X");
            //        }
            //        else
            //        {
            //            Console.Write("-");
            //        }
            //        //Console.Write("\n");
            //    }
            //}
            for(int i = 0; i < 5; i++)
            {

                Console.WriteLine("Event " + distances[i].ID + " - " + distances[i].Tickets.OrderBy(x => x.TicketPrice).FirstOrDefault().TicketPriceString + ", " + "Distance " + distances[i].DistanceFromUser);
            }


            Console.ReadKey();
        }

        /// <summary>
        /// Calulates the Manhattan Distance between the User Coords and the list of Events
        /// </summary>
        /// <param name="userCoords"></param>
        /// <param name="events"></param>
        /// <returns></returns>
        private static List<Event> CalculateDistance(Coordinates userCoords, List<Event> events)
        {
            foreach (var currentEvent in events)
            {
                var manhattanDistance = Math.Abs(userCoords.x - currentEvent.Coord.x) + Math.Abs(userCoords.y - currentEvent.Coord.y);
                currentEvent.DistanceFromUser = manhattanDistance;
            }

            return events;
        }

        private static Coordinates StringToCoords(string userInput)
        {
            var matches = Regex.Matches(userInput, @"-?\d+");
            int[] coords = new int[2];

            for(int i = 0; i < 2; i++) //only iterate twice as a coordinate can only have an X and Y value
            {
                try
                {
                    coords[i] = int.Parse(matches[i].ToString());
                    Console.WriteLine(coords[i]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("You broke the string parser - " +  ex.Message);
                }
            }

            return new Coordinates { x = coords[0], y = coords[1] };
        }

        /// <summary>
        /// Sorts the events in ascending order of their Manhattan Distance
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        private static List<Event> SortEvents(List<Event> events)
        {
            return events.OrderBy(x => x.DistanceFromUser).ToList();
        }
    }
}
