using System.Collections.Generic;
using System.Linq;

namespace GridChallenge
{
    class Event
    {
        public Coordinate Coords { get; set; }
        public int ID { get; private set; }
        public List<Ticket> Tickets { get; private set; } = new List<Ticket>();
        public int DistanceFromUser { get; set; }
        
        public Event(Coordinate coords, int uniqueID)
        {
            Coords = coords;
            ID = uniqueID;

            var numberOfTickets = StaticRandom.Instance.Next(0, 30);

            if (numberOfTickets != 0)
            {
                for (int i = 0; i < numberOfTickets; i++)
                {
                    Ticket ticket = new Ticket();
                    Tickets.Add(ticket);
                }

                Tickets = AcsendingByPrice(Tickets);
            }
        }

        private List<Ticket> AcsendingByPrice(List<Ticket> tickets)
        {
            return tickets.OrderBy(x => x.TicketPrice).ToList();
        }
    }
}
