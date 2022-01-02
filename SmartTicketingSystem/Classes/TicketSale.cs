using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTicketingSystem.Classes
{
    public class TicketSale
    {
        public Guid ID { get; set; }

        public string CustomerName { get; set; }

        public string CustomerContact { get; set; }

        public Ticket Ticket { get; set; }

        public string TicketName
        {
            get { return Ticket.TicketName; }
        }

        public string TicketPrice
        {
            get { return "Rs. " + Convert.ToString(Ticket.TicketRate); }
        }

        public int NoOfPeople
        {
            get { return Ticket.NoOfPeople; }
        }

        public string EntryTime { get; set; }

        public string ExitTime { get; set; }

        public DateTime TicketDate { get; set; }
    }
}
