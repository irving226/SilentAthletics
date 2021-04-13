using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using SilentAthleticsWebApp.Models;

namespace SilentAthleticsWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
       

        public DbSet<SilentAthleticsWebApp.Models.ItemListings> ItemListings { get; set; }

        public DbSet<SilentAthleticsWebApp.Models.MeetupScheduler> MeetupSchedulers { get; set; }
    
}
}
