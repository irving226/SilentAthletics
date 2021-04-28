using Microsoft.AspNetCore.Http;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SilentAthleticsWebApp.Models
{
   public interface IItemRepository 
    {


        public IQueryable<ItemListing> GetAllItemListings();
        public ItemListing GetItemListingById(int id);
     //   void AddImages(IQueryable<Image> images);

  
 
        void AddItemListing(ItemListing itemListing);
        void DeleteItemListing(int id);
       public  ItemListing UpdateItemListing(ItemListing itemListing);
        void Save();

       

    }


}


