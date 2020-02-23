using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ecomm.Web.Models
{
    public class SubCategory
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:30,MinimumLength =3)]
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}