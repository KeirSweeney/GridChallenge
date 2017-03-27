using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridChallenge
{
    class Ticket
    {
        public decimal TicketPrice;
        public string TicketPriceString;
        public Ticket()
        {
            TicketPrice = (decimal)(StaticRandom.Instance.NextDouble() * 100);
            TicketPriceString = TicketPrice.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
        }
    }
}
