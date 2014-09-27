namespace TicketPurchaseApp1
{
    public class Ticket
    {
        public double NoOfTickets { get; set; }
        public string CustomerName { get; set; }
        public const double PER_TICKET_PRICE = 10;

        public double GetTotalPrice()
        {
            return NoOfTickets*PER_TICKET_PRICE ;
        }
    }
}