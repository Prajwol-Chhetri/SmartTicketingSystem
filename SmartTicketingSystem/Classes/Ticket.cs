using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTicketingSystem.Classes
{

    public class Ticket
    {
        public Guid id { get; set; }

        public decimal ticketRate { get; set; }

        public Guid timing { get; set; }

        public Guid category { get; set; }

        public string ticketName { get; set; }
    }
}
