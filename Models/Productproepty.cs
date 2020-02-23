using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ecomm.Web.Models
{
    public class Productproepty
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int PropertyId { get; set; }
        public Property Property { get; set; }
        [Required]
        [StringLength(maximumLength:500,MinimumLength =1)]
        public string value { get; set; }
    }
}