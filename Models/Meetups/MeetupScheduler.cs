using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SilentAthleticsWebApp.Models
{

    [Table("Meetings")]
    public class MeetupScheduler  //change to meet up
    {

        public int ID { get; set; }
        [Required(ErrorMessage = "Please specify an ID")]
        public int BuyerID { get; set; }

        //ID will be the ID of the person scheduling the Meet

        //[Required(ErrorMessage="Please specify an ID")]
        public int SellerID { get; set; }
        //     [Required(ErrorMessage = "Please specify a name")]
        public string BuyerName { get; set; }
        //     [Required(ErrorMessage = "Please specify the seller you're meeting with")]
        public string SellerName { get; set; }
        //     [Required(ErrorMessage = "Please specify the item's ID")]
        public int ItemID { get; set; }

        //      [Required(ErrorMessage = "Please specify where you are meeting")]
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
   //     [Required(ErrorMessage = "Please specify a meeting time")]

        [Required]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public DateTime Time { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:M/dd/yyyy}")]
        //  [Required(ErrorMessage = "Please specify the meeting date")]
        public DateTime MeetingDate { get; set; }

    }
}
