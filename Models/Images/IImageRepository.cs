using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.Extensions.FileProviders;

namespace SilentAthleticsWebApp.Models.Images
{
   public interface IImageRepository
    {
       
         long Length { get; }
       public string Name { get; }
        public string FileName { get; }

        //gets form field name from content-disposition header
        string ContentDisposition { get; }
        public void CopyTo(Stream target);
        public Stream openReadStream();
        IFileProvider ContentRootFileProvider { get; set; }
        string WebRootPath { get; set; }
        string ContentRootPath { get; }
    }
}
