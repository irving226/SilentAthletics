using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SilentAthleticsWebSite.Models
{
    public class Accounts
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }

        public string Neighborhood { get; set; }
        public string Email { get; set; }

        public int DateOfBirth { get; set; }
    }
}
