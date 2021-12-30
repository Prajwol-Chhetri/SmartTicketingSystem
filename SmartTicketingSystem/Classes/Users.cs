using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTicketingSystem.Classes
{

    public enum RoleType
    {
        Admin,
        Staff
    }

    public class Users
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public RoleType Role { get; set; }

        public string Password { get; set; }
    }
}
