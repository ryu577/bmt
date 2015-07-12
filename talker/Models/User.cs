using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace talker.Models
{
    public class User
    {
        [Key]
        public string Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public DateTime DateCreated { get; set; }
    }
}