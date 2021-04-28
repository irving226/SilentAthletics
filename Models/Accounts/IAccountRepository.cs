using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SilentAthleticsWebApp.Models
{
    public interface IAccountRepository
    {
        
        public IQueryable<Account> GetAllAccounts();
        public Account GetAccountByID(int accountId);
        void InsertAccount(Account account);
        void DeleteAccount(int accountId);
        void UpdateAccount(Account account);
        void Add(Account account);
        void Register(Account account);
        void Save();
        bool Login(Account account);
        void Logout();
        bool IsAdmin();
        bool IsLoggedOn();
    }
}
