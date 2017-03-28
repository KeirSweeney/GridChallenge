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
            TicketPrice = (decimal)((StaticRandom.Instance.NextDouble() + 0.1) * 100); //I add 0.1 so that a ticket cannot be 0 in price
            TicketPriceString = TicketPrice.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
        }
    }
}
