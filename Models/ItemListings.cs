using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SilentAthleticsWebApp.Models
{
    public class ItemListings
    {
        public int ID { get; set; }
        public int SellerID { get; set; }

        public int CategoryID { get; set; }
        public string Brand { get; set; }
        public string Item { get; set; }
        public string Description { get; set; }
        public int StartPrice { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
    }
}
