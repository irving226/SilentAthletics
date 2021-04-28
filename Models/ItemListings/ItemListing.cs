using Microsoft.AspNetCore.Http;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

using System.Web;
using System.ComponentModel;

namespace SilentAthleticsWebApp.Models
{

    [Table("ItemListings")]
    public partial class ItemListing 
    {
        public int ID { get; set; }
        public int SellerID { get; set; }

        public int CategoryID { get; set; }
        public string Brand { get; set; }
        public string Item { get; set; }
        public string Description { get; set; }
        public int StartPrice { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public IEnumerable<Image> Image {get;set;}

    }
}
