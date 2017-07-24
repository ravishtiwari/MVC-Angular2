using MasterDetail.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace MasterDetail.DataLayer
{
    public class ProductConfiguration:EntityTypeConfiguration<Product>

    {
        public ProductConfiguration()
        {

            Property(p => p.ProductID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.ProductCode).HasColumnType("VARCHAR").IsRequired().HasMaxLength(100);
            Property(p => p.ProductName).HasColumnType("VARCHAR").IsRequired().HasMaxLength(500);
            Property(p => p.CategoryID).IsRequired();
            HasRequired(p => p.Category).WithMany(pc => pc.Products).HasForeignKey(p => p.CategoryID).WillCascadeOnDelete(false);



        }
    }
}