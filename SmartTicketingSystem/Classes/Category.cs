using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTicketingSystem.Classes
{
    public class Category
    {
        public Guid ID { get; set; }

        public int NoOfPeople { get; set; }

        public string CategoryName { get; set; }
    }
}
