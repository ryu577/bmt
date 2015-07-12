using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace talker.Models
{
    public class LiveBid
    {
        //[ScaffoldColumn(false)]
        [Key]
        public int BidID { get; set; }

        public string ProvidingUserName { get; set; }

        public DateTime AvailableStartTime { get; set; }

        public DateTime AvailableEndTime { get; set; }

        public double DesiredBidPrice { get; set; }

        public bool Status { get; set; } //True means the bid is live. False means it should have been transferred to the talks DB.

        public User AppUser { get; set; }

        public int? CategoryID { get; set; }

        public Category Category { get; set; }
    }
}