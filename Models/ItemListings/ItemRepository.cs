
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SilentAthleticsWebApp.Models
{
    public class ItemRepository : IItemRepository
    {

        private AppDbContext db;

        public ItemRepository(AppDbContext database)
        {
            db = database;
        }





        public void AddItemListing(ItemListing itemListing)
        {

            db.ItemListings.Add(itemListing);

        }

        public void DeleteItemListing(int id)
        {
            db.ItemListings.Remove(db.ItemListings.FirstOrDefault(i => i.ID == id));
        }

        public IQueryable<ItemListing> GetAllItemListings()
        {
            return db.ItemListings;

        }

        public ItemListing GetItemListingById(int id)
        {
            return db.ItemListings.FirstOrDefault(i => i.ID == id);
        }

        public void Save()
        {
            db.SaveChanges();
        }



        public ItemListing UpdateItemListing(ItemListing itemListing)
        {
            ItemListing itemListingToUpdate = db.ItemListings.SingleOrDefault(il => il.ID == itemListing.ID);
            if (itemListingToUpdate != null)
            {
                itemListingToUpdate.Item = itemListing.Item;
                itemListingToUpdate.Brand = itemListing.Brand;
                itemListingToUpdate.Description = itemListing.Description;
                itemListingToUpdate.StartPrice = itemListing.StartPrice;

                db.SaveChanges();
            }
            return itemListingToUpdate;

        }
    }
}
