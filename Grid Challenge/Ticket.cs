using System.Globalization;

namespace GridChallenge
{
    class Ticket
    {
        /// <summary>
        /// Price of the ticket
        /// </summary>
        public decimal TicketPrice { get; private set; }
        /// <summary>
        /// The ticket price rounded and represented as a string in US dollars
        /// </summary>
        public string TicketPriceString { get; private set; }

        public Ticket()
        {
            TicketPrice = (decimal)(StaticRandom.Instance.NextDouble() * 100);
            TicketPriceString = TicketPrice.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
        }
    }
}
