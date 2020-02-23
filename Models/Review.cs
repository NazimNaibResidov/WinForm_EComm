using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecomm.Web.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string message { get; set; }
        public DateTime ReviewTime { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public int userPoint { get; set; }
    }
}