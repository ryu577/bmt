using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace talker.Models
{
    public class PlacedBid
    {
        [Key]
        public int PlacedBidId { get; set; }
        public string ReceivingMemberId { get; set; }
        public string ProvidingMemberId { get; set; }
        public int BidId { get; set; }
        public DateTime BidTime { get; set; }
        public virtual LiveBid AssociatedBid { get; set; }
    }
}