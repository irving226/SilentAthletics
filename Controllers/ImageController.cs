using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using SilentAthleticsWebApp.Models;
using SilentAthleticsWebApp.Models.Images;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SilentAthleticsWebApp.Controllers
{
    public class ImageController : Controller
    {
         private IImageRepository _imageRepo;
        private IWebHostEnvironment _env;
        private string _dir;

        public ImageController(IWebHostEnvironment env, IImageRepository imageRepo)
        {
            _env = env;
            _imageRepo = imageRepo;
        }

        public IActionResult Index()
        {
            return View();
        }



    }
}
