namespace Ecomm.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initital : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SubCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Markas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        SubCategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SubCategories", t => t.SubCategoryId, cascadeDelete: true)
                .Index(t => t.SubCategoryId);
            
            CreateTable(
                "dbo.Models",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        MarkaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Markas", t => t.MarkaId, cascadeDelete: true)
                .Index(t => t.MarkaId);
            
            CreateTable(
                "dbo.Discounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ModelId = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Percent = c.Byte(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Models", t => t.ModelId, cascadeDelete: true)
                .Index(t => t.ModelId);
            
            CreateTable(
                "dbo.Productproepties",
                c => new
                    {
                        ProductId = c.Int(nullable: false),
                        PropertyId = c.Int(nullable: false),
                        Id = c.Int(nullable: false),
                        value = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => new { t.ProductId, t.PropertyId })
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Properties", t => t.PropertyId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.PropertyId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ModelId = c.Int(nullable: false),
                        State = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Models", t => t.ModelId, cascadeDelete: true)
                .Index(t => t.ModelId);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        message = c.String(),
                        ReviewTime = c.DateTime(nullable: false),
                        UserId = c.Int(nullable: false),
                        userPoint = c.Int(nullable: false),
                        Product_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .Index(t => t.UserId)
                .Index(t => t.Product_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        UserName = c.String(),
                        IsActive = c.Boolean(),
                        Password = c.String(),
                        Role = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Properties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Productproepties", "PropertyId", "dbo.Properties");
            DropForeignKey("dbo.Productproepties", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Reviews", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.Reviews", "UserId", "dbo.Users");
            DropForeignKey("dbo.Products", "ModelId", "dbo.Models");
            DropForeignKey("dbo.Discounts", "ModelId", "dbo.Models");
            DropForeignKey("dbo.Markas", "SubCategoryId", "dbo.SubCategories");
            DropForeignKey("dbo.Models", "MarkaId", "dbo.Markas");
            DropForeignKey("dbo.SubCategories", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Reviews", new[] { "Product_Id" });
            DropIndex("dbo.Reviews", new[] { "UserId" });
            DropIndex("dbo.Products", new[] { "ModelId" });
            DropIndex("dbo.Productproepties", new[] { "PropertyId" });
            DropIndex("dbo.Productproepties", new[] { "ProductId" });
            DropIndex("dbo.Discounts", new[] { "ModelId" });
            DropIndex("dbo.Models", new[] { "MarkaId" });
            DropIndex("dbo.Markas", new[] { "SubCategoryId" });
            DropIndex("dbo.SubCategories", new[] { "CategoryId" });
            DropTable("dbo.Properties");
            DropTable("dbo.Users");
            DropTable("dbo.Reviews");
            DropTable("dbo.Products");
            DropTable("dbo.Productproepties");
            DropTable("dbo.Discounts");
            DropTable("dbo.Models");
            DropTable("dbo.Markas");
            DropTable("dbo.SubCategories");
            DropTable("dbo.Categories");
        }
    }
}
