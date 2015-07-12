using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace talker.Models
{
    public class Discussion
    {
        [ScaffoldColumn(false)]
        public int DiscussionID { get; set; }

        public string ProvidingUserName { get; set; }

        public string ReceivingUserName { get; set; }

        public DateTime DiscussionStartTime { get; set; }

        public DateTime DiscussionEndTime { get; set; }

        public double TransactionAmount { get; set; }

        public string Status { get; set; }

        public int Rating { get; set; }

        //public virtual ApplicationUser AppUser { get; set; }
    }
}