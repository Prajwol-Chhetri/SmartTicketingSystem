using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTicketingSystem.Classes
{
    public class TicketSale
    {
        public Guid id { get; set; }

        public Guid ticket { get; set; }

        public string checkInTime { get; set; }

        public string checkOutTime { get; set; }

        public DateTime soldDate { get; set; }
    }
}
