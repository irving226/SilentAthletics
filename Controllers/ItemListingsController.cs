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
    public class ItemListingsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ItemListingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ItemListings
        public async Task<IActionResult> Index()
        {
            return View(await _context.ItemListings.ToListAsync());
        }

        // GET: ItemListings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemListings = await _context.ItemListings
                .FirstOrDefaultAsync(m => m.ID == id);
            if (itemListings == null)
            {
                return NotFound();
            }

            return View(itemListings);
        }

        // GET: ItemListings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ItemListings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,SellerID,CategoryID,Brand,Item,Description,StartPrice,StartTime,EndTime")] ItemListings itemListings)
        {
            if (ModelState.IsValid)
            {
                _context.Add(itemListings);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(itemListings);
        }

        // GET: ItemListings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemListings = await _context.ItemListings.FindAsync(id);
            if (itemListings == null)
            {
                return NotFound();
            }
            return View(itemListings);
        }

        // POST: ItemListings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,SellerID,CategoryID,Brand,Item,Description,StartPrice,StartTime,EndTime")] ItemListings itemListings)
        {
            if (id != itemListings.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(itemListings);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemListingsExists(itemListings.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(itemListings);
        }

        // GET: ItemListings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemListings = await _context.ItemListings
                .FirstOrDefaultAsync(m => m.ID == id);
            if (itemListings == null)
            {
                return NotFound();
            }

            return View(itemListings);
        }

        // POST: ItemListings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var itemListings = await _context.ItemListings.FindAsync(id);
            _context.ItemListings.Remove(itemListings);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItemListingsExists(int id)
        {
            return _context.ItemListings.Any(e => e.ID == id);
        }
    }
}
