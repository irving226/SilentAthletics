using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SilentAthleticsWebApp.Models
{
    public class PageInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        

        public int TotalPages => (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);
    }//https://erau.zoom.us/rec/play/zWmAQkWwool9H79zc5yKJkSFT5W4W9Z28fcgnVjsgRMoEpNsSgM5qH9h2cVENb176eGxEunSYGp0gDuJ.mRIXmUcHzdbV7c37
}
