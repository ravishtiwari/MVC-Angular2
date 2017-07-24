namespace MasterDetail.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class product : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(nullable: false),
                        OrderDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Customers", t => t.CustomerID)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.OrderItems",
                c => new
                    {
                        OrderItemID = c.Int(nullable: false, identity: true),
                        OrderID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.OrderItemID)
                .ForeignKey("dbo.Orders", t => t.OrderID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.OrderID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        ProductCode = c.String(nullable: false, maxLength: 100, unicode: false),
                        ProductName = c.String(nullable: false, maxLength: 500, unicode: false),
                        CategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductID)
                .ForeignKey("dbo.ProductCategories", t => t.CategoryID)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.ProductCategories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CatagoryName = c.String(nullable: false, maxLength: 100, unicode: false),
                        ParentID = c.Int(),
                    })
                .PrimaryKey(t => t.CategoryID)
                .ForeignKey("dbo.ProductCategories", t => t.ParentID)
                .Index(t => t.ParentID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderItems", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Products", "CategoryID", "dbo.ProductCategories");
            DropForeignKey("dbo.ProductCategories", "ParentID", "dbo.ProductCategories");
            DropForeignKey("dbo.OrderItems", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.Orders", "CustomerID", "dbo.Customers");
            DropIndex("dbo.ProductCategories", new[] { "ParentID" });
            DropIndex("dbo.Products", new[] { "CategoryID" });
            DropIndex("dbo.OrderItems", new[] { "ProductID" });
            DropIndex("dbo.OrderItems", new[] { "OrderID" });
            DropIndex("dbo.Orders", new[] { "CustomerID" });
            DropTable("dbo.ProductCategories");
            DropTable("dbo.Products");
            DropTable("dbo.OrderItems");
            DropTable("dbo.Orders");
        }
    }
}
