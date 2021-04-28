using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Microsoft.AspNetCore.Http;
using System.Security.Cryptography;
using System.Text;

namespace SilentAthleticsWebApp.Models
{
    public class AccountRepository : IAccountRepository
    {
        private AppDbContext _context;
        private ISession _session;
        private SHA256 _encryption;

        public AccountRepository(AppDbContext context, IHttpContextAccessor httpContext)
        {
            _context = context;
            _session = httpContext.HttpContext.Session;
        }

        public void Add(Account account)
        {
            _context.Accounts.Add(account);
        }

        public void DeleteAccount(int accountId)
        {
            _context.Accounts.Remove(_context.Accounts.FirstOrDefault(x=>x.Id==accountId));

        }

        public Account GetAccountByID(int accountId)
        {
           return _context.Accounts.FirstOrDefault(x => x.Id == accountId);
        }

        public IQueryable<Account> GetAllAccounts()
        {
            return _context.Accounts;
        }

        public void InsertAccount(Account account)
        {
            _context.Accounts.Add(account);
        }

        public void Register(Account account)
        {
            throw new NotImplementedException();
        }

        public bool Login(Account account)
        {
            Account acc = GetAccountByID(account.Id);
            if (acc == null)
            {
                return false;
            }

            account.Password = passwordEncryption(account.Email, account.Password);

            if (acc.Password == account.Password)
            {
                _session.SetInt32("accountId", acc.Id);
                _session.SetString("accountEmail", account.Email);
                if (acc.IsAdmin == true)
                {
                    _session.SetInt32("accountAdmin", 1);
                }
                else
                {
                    _session.SetInt32("accountAdmin", 0);
                }
                return true;
            }
            return false;
        }

        private string passwordEncryption(string user, string passphrase)
        {
            if (_encryption == null)
            {
                _encryption = SHA256.Create();
            }

            byte[] usernameByteArray = Encoding.ASCII.GetBytes(user.ToLower());
            byte[] passwordByteArray = Encoding.ASCII.GetBytes(passphrase);
            for(int i = 0; i < passwordByteArray.Length; i++)
            {
                passwordByteArray[i] ^= usernameByteArray[i % usernameByteArray.Length];
            }
            byte[] hashedPasswordbyteArray = _encryption.ComputeHash(passwordByteArray);
            string passwordHash = "";
            foreach(byte b in hashedPasswordbyteArray)
            {
                passwordHash += b.ToString("X2");
            }
            return passwordHash;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void UpdateAccount(Account account)
        {
            _context.Entry(account).State=EntityState.Modified;
        }

        public void Logout()
        {
            _session.Remove("accountId");
            _session.Remove("accountEmail");
            _session.Remove("accountAdmin");
            
        }

        public bool IsAdmin()
        {
            if (_session.GetInt32("accountAdmin" )== 1)
            {
                return true;
            }
            return false;
        }

        public bool IsLoggedOn()
        {
            int? accountID = _session.GetInt32("accountID");
            if (accountID == null)
            {
                return false;

            }
            return true;
        }
    }
}
