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

        public Guid Ticket { get; set; }

        public string EntryTime { get; set; }

        public string ExitTime { get; set; }

        public DateTime SoldDate { get; set; }
    }
}
