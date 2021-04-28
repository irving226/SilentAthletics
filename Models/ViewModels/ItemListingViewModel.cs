using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SilentAthleticsWebApp.Models.ViewModels
{
    public class ItemListingViewModel
    {
        public IQueryable<ItemListing> ItemListings { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
