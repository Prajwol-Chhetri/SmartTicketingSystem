using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTicketingSystem.Classes
{

    public class Ticket
    {
        public Guid ID { get; set; }

        public decimal TicketRate { get; set; }

        public Timing TicketTiming { get; set; }

        public string Duration 
        {
            get {return Convert.ToString(TicketTiming.NoOfHours) + " Hours"; } 
        }

        public Category TicketCategory { get; set; }

        public string Category
        {
            get { return TicketCategory.CategoryName; }
        }

        public int NoOfPeople
        {
            get { return TicketCategory.NoOfPeople; }
        }

        public string TicketName { get; set; }
    }
}
