using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SilentAthleticsWebApp.Models
{
    public class AppDbContext:DbContext
    {
        //fields/props

        public DbSet<MeetupScheduler> Meetings { get; set; }

        public DbSet<ItemListing> ItemListings { get; set; }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<Image> Images { get; set; }
      

        //constructors

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ItemListing>().HasData(new ItemListing
            {
                ID = 1,
                Brand = "Neversummer",
                Description = "Like new",
                Item = "Snowboard",
                StartTime = 5,       
            }) ;
            modelBuilder.Entity<ItemListing>().HasData(new ItemListing
            {
                ID=2,
                Brand = "Rossignol",
                Description = "Like new",
                Item = "Skis",
                StartTime = 5
            });
            modelBuilder.Entity<ItemListing>().HasData(new ItemListing
            {
                ID=3,
                Brand = "Arbor",
                Description = "Like new",
                Item = "Snowboard",
                StartTime = 5
            });
            modelBuilder.Entity<ItemListing>().HasData(new ItemListing
            {
                ID=4,
                Brand = "Burton",
                Description = "used",
                Item = "Snowboard",
                StartTime = 5
            });
            modelBuilder.Entity<ItemListing>().HasData(new ItemListing
            {
                ID=5,
                Brand = "Neversummer",
                Description = "Like new",
                Item = "Skis",
                StartTime = 100
            });
            modelBuilder.Entity<Account>().HasData(new Account
            {
                Id = 1,
                Email = "brianirv@yahoo.com",
                Password = "cambodiandrive",
                IsAdmin = true
            });

        }

        }
}
