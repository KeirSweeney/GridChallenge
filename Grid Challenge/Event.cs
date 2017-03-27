using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridChallenge
{
    class Event
    {
        public Coordinates Coord { get; set; }
        public int ID { get; set; }
        public List<Ticket> Tickets { get; set; } = new List<Ticket>();
        public int DistanceFromUser { get; set; }
        
        public Event(Coordinates coord, int uniqueID)
        {
            Coord = coord;
            ID = uniqueID;

            var numberOfTickets = StaticRandom.Instance.Next(0, 30);


            for (int i = 0; i < numberOfTickets; i++)
            {
                Ticket ticket = new Ticket();
                Tickets.Add(ticket);
            }
            Tickets = AcsendingByPrice(Tickets);
            
        }

        private List<Ticket> AcsendingByPrice(List<Ticket> tickets)
        {
            return tickets.OrderBy(x => x.TicketPrice).ToList();
        }
    }
}
