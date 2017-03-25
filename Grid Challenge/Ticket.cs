using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridChallenge
{
    class Ticket
    {
        public decimal TicketPrice;
        public Ticket()
        {
            Random r = new Random();
            TicketPrice = (decimal)(r.NextDouble() * 10);
        }
    }
}
