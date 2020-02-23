using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace Ecomm.Web.Models
{
    public class EcommDbContext:DbContext
    {
        public EcommDbContext():base("ecomm")
        {

        }
     public DbSet<Product> Products { get; set; }
     public DbSet<User> Users { get; set; }
     public DbSet<Category> Categories { get; set; }
     public DbSet<SubCategory> subCategories { get; set; }
     public DbSet<Model> Models { get; set; }
     public DbSet<Marka> Markas { get; set; }
     public DbSet<Discount> Discounts { get; set; }
     public DbSet<Property> Properties { get; set; }
     public DbSet<Productproepty> Productproepties { get; set; }
     public DbSet<Review> Reviews { get; set; }
     protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Productproepty>().HasKey((x) => new { x.ProductId, x.PropertyId });
        }
    }
}