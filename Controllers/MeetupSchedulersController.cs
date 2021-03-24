using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SilentAthleticsWebApp.Data;
using SilentAthleticsWebApp.Models;
using System.Linq;
using System.Threading.Tasks;

namespace SilentAthleticsWebApp.Controllers
{
    public class MeetupSchedulersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MeetupSchedulersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MeetupSchedulers
        public async Task<IActionResult> Index()
        {
            return View(await _context.MeetupSchedulers.ToListAsync());
        }

        // GET: MeetupSchedulers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meetupScheduler = await _context.MeetupSchedulers
                .FirstOrDefaultAsync(m => m.ID == id);
            if (meetupScheduler == null)
            {
                return NotFound();
            }

            return View(meetupScheduler);
        }

        // GET: MeetupSchedulers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MeetupSchedulers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BuyerID,ID,BuyerName,SellerName,ItemID,StreetAddress,City,State,ZipCode,MeetingTime,MeetingDate")] MeetupScheduler meetupScheduler)
        {
            if (ModelState.IsValid)
            {
                _context.Add(meetupScheduler);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(meetupScheduler);
        }

        // GET: MeetupSchedulers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meetupScheduler = await _context.MeetupSchedulers.FindAsync(id);
            if (meetupScheduler == null)
            {
                return NotFound();
            }
            return View(meetupScheduler);
        }

        // POST: MeetupSchedulers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BuyerID,ID,BuyerName,SellerName,ItemID,StreetAddress,City,State,ZipCode,MeetingTime,MeetingDate")] MeetupScheduler meetupScheduler)
        {
            if (id != meetupScheduler.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(meetupScheduler);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MeetupSchedulerExists(meetupScheduler.ID))
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
            return View(meetupScheduler);
        }

        // GET: MeetupSchedulers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meetupScheduler = await _context.MeetupSchedulers
                .FirstOrDefaultAsync(m => m.ID == id);
            if (meetupScheduler == null)
            {
                return NotFound();
            }

            return View(meetupScheduler);
        }

        // POST: MeetupSchedulers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var meetupScheduler = await _context.MeetupSchedulers.FindAsync(id);
            _context.MeetupSchedulers.Remove(meetupScheduler);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MeetupSchedulerExists(int id)
        {
            return _context.MeetupSchedulers.Any(e => e.ID == id);
        }
    }
}
