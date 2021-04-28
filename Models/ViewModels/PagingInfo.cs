using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SilentAthleticsWebApp.Models.ViewModels
{
    public class PagingInfo
    {
        public int TotalListings { get; set; }
        public int ListingsPerPage { get; set; }
        public int CurrentPage { get; set; }


        public int TotalPages()
        {
            return (int)Math.Ceiling((double) TotalListings / ListingsPerPage);
            //if its a whole, then thats the answer. Else its changed to rounded up num
        }
    }
}
