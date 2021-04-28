using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SilentAthleticsWebApp.Models
{
    public  class Image
    {
        public int Id { get; set; }
        public string ImageTitle { get; set; }

        [DisplayName("Upload File")]
        public string ImagePath { get; set; }
        public byte[] ImageData { get; set; }
        //public HttpPostedFileBase ImageFile { get; set; }
     
    }
}
