using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecomm.Web.Models
{
    public class Product
    {
        public Product()
        {
            Reviews = new HashSet<Review>();
        }
        public int Id { get; set; }
        public int ModelId { get; set; }
        public Model Model { get; set; }
        public State State { get; set; }
        public decimal Price { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}