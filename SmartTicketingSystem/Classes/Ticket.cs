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

        public Guid Timing { get; set; }

        public Guid Category { get; set; }

        public string TicketName { get; set; }
    }
}
