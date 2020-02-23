using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ecomm.Web.Models
{
    public class User
    {
        public User()
        {
            Reviews = new HashSet<Review>();
            IsActive = false;
        }
        public int Id { get; set; }
       
        public string Name { get; set; }
       
        public string Email { get; set; }
        
        public string UserName { get; set; }
        
        public bool? IsActive { get; set; }
       
        public string Password { get; set; }
        public Role Role { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}