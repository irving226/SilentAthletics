using Microsoft.AspNetCore.Http;

namespace SilentAthleticsWebApp.Controllers
{
    public class SomeForm
    {
       public IFormFile File { get; set; }
        public string Name { get; set; }
    }
}