using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SilentAthleticsWebApp.Models
{
    public class MeetupScheduler
    {
        [Required(ErrorMessage = "Please specify an ID")]
        public int BuyerID { get; set; }

        //ID will be the ID of the person scheduling the Meet

[Required(ErrorMessage="Please specify an ID")]
        public int SellerID { get; set; }
        [Required(ErrorMessage = "Please specify a name")]
        public string BuyerName { get; set; }
        [Required(ErrorMessage = "Please specify the seller you're meeting with")]
        public string SellerName { get; set; }
        [Required(ErrorMessage = "Please specify the item's ID")]
        public int ItemID { get; set; }

        [Required(ErrorMessage = "Please specify where you are meeting")]
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        [Required(ErrorMessage = "Please specify a meeting time")]
        public int MeetingTime { get; set; }

        [Required(ErrorMessage = "Please specify the meeting date")]
        public int MeetingDate { get; set; }
    }
}
