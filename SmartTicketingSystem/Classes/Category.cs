using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTicketingSystem.Classes
{
    public class Category
    {
        public Guid id { get; set; }

        public int noOfPeople { get; set; }

        public string categoryName { get; set; }
    }
}
