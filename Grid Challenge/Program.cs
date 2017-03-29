using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace GridChallenge
{
    class Program
    {
        private const int NumberOfEvents = 10;
        private const int EventDisplayCount = 5;

        static void Main(string[] args)
        {

            Grid grid = new Grid(new Coordinates {  X = 10, Y = -10 }, new Coordinates { X = 10, Y = 10 });
            List<Event> events = new List<Event>();
            Random random = new Random(); //Static Random isn't used here as we don't want the same set of coordinates twice.

            for (var i = 1; i < NumberOfEvents; i++)
            {
                int randomXCoord = random.Next(grid.XMin, grid.XMax);
                int randomYCoord = random.Next(grid.YMin, grid.YMax);
                Event myEvent = new Event(new Coordinates { X = randomXCoord, Y = randomYCoord }, i);
                events.Add(myEvent);
            }

            Console.WriteLine("Please input Coordinates inbetween (-10,-10) & (10,10). Please use a character between each coordinate: ");
            var userString = Console.ReadLine();

            Coordinates userCoords = StringToCoords(userString);
            var distances = GetManhattanDistance(userCoords, events);
            distances = SortEvents(distances);

            Console.WriteLine("Closest Events to " + "(" + userCoords.X + "," + userCoords.Y + "):");

            for (int i = 0; i < EventDisplayCount; i++)
            {
                var eventID = "Event " + distances[i].ID + " - ";
                var cheapestTicketPrice = distances[i].Tickets.Count != 0 ? distances[i].Tickets.FirstOrDefault().TicketPriceString + ", " : "There are no tickets available for this show! ";
                var distanceFromUser = "Distance " + distances[i].DistanceFromUser;
                Console.WriteLine(eventID + cheapestTicketPrice + distanceFromUser);
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Calulates the Manhattan Distance between the User Coords and the list of Events
        /// </summary>
        /// <param name="userCoords"></param>
        /// <param name="events"></param>
        /// <returns></returns>
        private static List<Event> GetManhattanDistance(Coordinates userCoords, List<Event> events)
        {
            foreach (var currentEvent in events)
            {
                var manhattanDistance = Math.Abs(userCoords.X - currentEvent.Coords.X) + Math.Abs(userCoords.Y - currentEvent.Coords.Y);
                currentEvent.DistanceFromUser = manhattanDistance;
            }

            return events;
        }

        private static Coordinates StringToCoords(string userInput)
        {
            var matches = Regex.Matches(userInput, @"-?\d+"); //Any digit ,negative or positive
            int[] coords = new int[2];

            for(int i = 0; i < 2; i++) //only iterate twice as a coordinate can only have an X and Y value
            {
                try
                {
                    coords[i] = int.Parse(matches[i].ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid coordinate input: " +  ex.Message);
                }
            }

            return new Coordinates { X = coords[0], Y = coords[1] };
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
