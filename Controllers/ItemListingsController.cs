using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using SilentAthleticsWebApp.Models;

using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.Web;
using SilentAthleticsWebApp.Models.Images;

namespace SilentAthleticsWebApp.Controllers
{
    public class ItemListingController : Controller
    {
        private IItemRepository _itemRepository;
        private IWebHostEnvironment _env;
        private string _dir;

        public ItemListingController(IItemRepository repository, IWebHostEnvironment env)
        {
            _itemRepository = repository;
            _env = env;
            _dir = _env.WebRootPath;

        }



        public IActionResult Index()
        {
            IQueryable<ItemListing> allListings = _itemRepository.GetAllItemListings();
            return View(allListings);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ItemListing i)
        {

            _itemRepository.AddItemListing(i);


            return RedirectToAction("Details", new { id = i.ID });
        }
        [HttpPost]
        public IActionResult FileInModel(SomeForm someForm, ItemListing i)
        {
            Image image = new Image();
            



            using (var fileStream = new FileStream(Path.Combine(_dir, $"{someForm.Name}.png"), FileMode.Create, FileAccess.Write))
            {
               
                someForm.File.CopyTo(fileStream);
                image.ImagePath = fileStream.Name;
            }
            
            return RedirectToAction("Index");
        }

 //
 //
 //
        public IActionResult Details(int id)
        {
            //pulls from database and displays it in the view
            ItemListing item = _itemRepository.GetItemListingById(id);
            return View(item);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ItemListing itemListing = _itemRepository.GetItemListingById(id);

            return View(itemListing);
        }
        [HttpPost]
        public IActionResult Edit(ItemListing itemToUpdate, SomeForm someForm)
        {

            Image image = new Image();
            image.ImageTitle = someForm.Name;
            _itemRepository.UpdateItemListing(itemToUpdate);
            _itemRepository.Save();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Delete(ItemListing itemListing, int id)
        {
            return View();
        }


    }
}
