using MasterDetail.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace MasterDetail.DataLayer
{
    public class ProductCategoryConfiguration: EntityTypeConfiguration<ProductCategory>
    {

        public ProductCategoryConfiguration()
        {

            HasKey(pc => pc.CategoryID);
            Property(pc => pc.CategoryID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(pc => pc.CatagoryName).IsRequired().HasColumnType("VARCHAR").HasMaxLength(100);
            Property(pc => pc.ParentID).IsOptional();
            HasOptional(pc => pc.Parent).WithMany(pc => pc.Children).HasForeignKey(pc => pc.ParentID).WillCascadeOnDelete(false);

            


        }
    }
}