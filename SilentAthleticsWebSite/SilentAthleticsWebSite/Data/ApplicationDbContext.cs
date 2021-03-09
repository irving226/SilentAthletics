using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SilentAthleticsWebSite.Models;

namespace SilentAthleticsWebSite.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<SilentAthleticsWebSite.Models.Accounts> Accounts { get; set; }
    }
}
