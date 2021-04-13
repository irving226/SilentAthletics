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

        public DbSet<Accounts> Accounts { get; set; }

        //constructors

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Accounts>().HasData(new Accounts
            {
                Id=01,
              FirstName="Brian",
              LastName="Irving",
              Address="1333 AWS Ave, Denver CO 80111",
              Email="Brianirv@outlook.com",
              BirthDate=02/26/91


            });
        }

        }
}
