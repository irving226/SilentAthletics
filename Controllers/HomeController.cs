using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SilentAthleticsWebApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace SilentAthleticsWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private int _pageSize = 5;

   

      

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

 //     public IActionResult Index(int itemListingPage = 1)
 //     {
 //         IQueryable<ItemListing> allItemListings = itemRepository.GetAllItemListings();
 //         IQueryable<ItemListing> someItemListings = allItemListings.OrderBy(i => i.ID).Skip//(itemListingPage - 1) * _pageSize).Take(_pageSize);
 //
 //         ViewBag.ItemListingCount = allItemListings.Count();
 //         return View();
 //
 //     }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
