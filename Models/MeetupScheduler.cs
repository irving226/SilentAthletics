using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SilentAthleticsWebApp.Models
{
    public class MeetupScheduler
    {
        public int BuyerID { get; set; }

        //ID will be the ID of the person scheduling the Meet
        public int ID { get; set; }
        public int BuyerName { get; set; }
        public int SellerName { get; set; }
        public int ItemID { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public int MeetingTime { get; set; }
        public int MeetingDate { get; set; }
    }
}
