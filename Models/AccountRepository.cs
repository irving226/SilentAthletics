using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SilentAthleticsWebApp.Models
{
    public class AccountRepository : IAccountRepository
    {
        private AppDbContext _context;

        public AccountRepository(AppDbContext context)
        {
            _context = context;
        }



        public IQueryable<Accounts> GetAllAccounts()
        {
            return _context.Accounts;
        }
    }
}
