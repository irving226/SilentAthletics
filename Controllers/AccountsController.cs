using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SilentAthleticsWebApp.Data;
using SilentAthleticsWebApp.Models;

namespace SilentAthleticsWebApp.Controllers
{
    public class AccountsController : Controller
    {
      

        private IAccountRepository _repository;

        public AccountsController(IAccountRepository repository)
        {
            _repository = repository;
        }


        // GET: Accounts
        public IActionResult Index()
        {
            IQueryable<Accounts> allAccounts = _repository.GetAllAccounts();
            return View(allAccounts);
        }

        // GET: Accounts/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accounts = _repository.GetAllAccounts()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (accounts == null)
            {
                return NotFound();
            }

            return View(accounts);
        }

        // GET: Accounts/Create
        public IActionResult Create()
        {
            IQueryable<Accounts> allProducts = _repository.GetAllAccounts(); 
            return View(allProducts);
        }

        // POST: Accounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,UserName,Email,BirthDate,Neighborhood,Address")] Accounts accounts)
        {
            if (ModelState.IsValid)
            {
            }
            return View(accounts);
        }

        // GET: Accounts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
         
            return View();
        }

        // POST: Accounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,UserName,Email,BirthDate,Neighborhood,Address")] Accounts accounts)
        {
            if (id != accounts.Id)
            {
                return NotFound();
            }

          
            
            return View(accounts);
        }

        // GET: Accounts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

           // var accounts = await _context.Accounts
            //    .FirstOrDefaultAsync(m => m.Id == id);
          // if (accounts == null)
          // {
          //     return NotFound();
          // }
          //
          return View();
        }

        // POST: Accounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
        //    var accounts = await _context.Accounts.FindAsync(id);
        //    _context.Accounts.Remove(accounts);
        //    await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AccountsExists(int id)
        {
            return _repository.GetAllAccounts().Any(e => e.Id == id);
        }
    }
}
