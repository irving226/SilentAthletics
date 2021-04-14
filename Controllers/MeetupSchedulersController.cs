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

        [HttpGet]
        public IActionResult Create()
        {
            //returns create cshtml page
            return View();
        }

        [HttpPost]
        public IActionResult Create(MeetupScheduler m)
        {

            //returns the details page post addition of data
            return RedirectToAction("Details");
        }

        public IActionResult Details(int id)
        {
            //pulls from database and displays it in view
            MeetupScheduler m = new MeetupScheduler();
            m.BuyerID = 0;
            m.BuyerName = "Brian";
            m.SellerName = "Izzy";
            m.SellerID = 1;

            return View(m);

        }

        [HttpGet]
        public IActionResult Edit(int id)
        {

            //grabs the obj from database to be edited
            MeetupScheduler m = new MeetupScheduler();
            m.BuyerID = 0;
            m.BuyerName = "Brian";
            m.SellerName = "Izzy";
            m.SellerID = 1;

            return View(m);
        }

        [HttpPost]
        public IActionResult Edit(MeetupScheduler m)
        {
            return RedirectToAction("Details");
           
        }

    }
}