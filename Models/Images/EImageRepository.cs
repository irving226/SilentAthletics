using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SilentAthleticsWebApp.Models.Images
{
    public class EImageRepository : IImageRepository

    {
        private AppDbContext _context;
        public EImageRepository(AppDbContext db)
        {
            _context = db;
        }
        public long Length => throw new NotImplementedException();

        public string Name => throw new NotImplementedException();

        public string FileName => throw new NotImplementedException();

        public string ContentDisposition => throw new NotImplementedException();

        public IFileProvider ContentRootFileProvider { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string WebRootPath { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string ContentRootPath => throw new NotImplementedException();

        public void CopyTo(Stream target)
        {
            throw new NotImplementedException();
        }

        public Stream openReadStream()
        {
            throw new NotImplementedException();
        }
    }
}
