using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SilentAthleticsWebApp.Models
{
    public interface IAccountRepository
    {
        public IQueryable<Accounts> GetAllAccounts();
    }
}
