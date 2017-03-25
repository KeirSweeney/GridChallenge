using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridChallenge
{
    class Program
    {
        public static int NumberOfEvents = 10;
        List<Coordinates> Events = new List<Coordinates>();


        static void Main(string[] args)
        {
            Grid grid = new Grid(new Coordinates { x = -10, y = -10 }, new Coordinates { x = 10, y = 10 });

            Random r = new Random();

            for (var i = 0; i < NumberOfEvents; i++)
            {
                int randomXCoord = r.Next(grid.XMin, grid.XMax);
                int randomYCoord = r.Next(grid.YMin, grid.YMax);
                Event myEvent = new Event(new Coordinates { x = randomXCoord, y = randomYCoord }, i);

                

                Console.WriteLine(randomXCoord.ToString() +"," + randomYCoord.ToString());
            }


            
            Console.ReadKey();
        }



    }
}
