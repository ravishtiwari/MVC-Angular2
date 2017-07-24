using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MasterDetail.Models;
namespace MasterDetail.DataLayer
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
        public static ApplicationDbContext Create()
        {

            return new ApplicationDbContext();
        }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<ProductCategory> ProductCategories { get; set; }

        public DbSet<Product> Products { get; set; }


        public DbSet<Order> Orders { get; set; }

        public System.Data.Entity.DbSet<MasterDetail.Models.OrderItem> OrderItems { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerConfiguration());
            modelBuilder.Configurations.Add(new ProductCategoryConfiguration());
            modelBuilder.Configurations.Add(new ProductConfiguration());
            modelBuilder.Configurations.Add(new OrderConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}