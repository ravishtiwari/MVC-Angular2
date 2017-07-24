using MasterDetail.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace MasterDetail.DataLayer
{
    public class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
        {

            Property(c => c.CustomerID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.CustomerName).IsRequired().HasMaxLength(500).HasColumnType("VARCHAR");
            Property(c => c.Phone).IsRequired().HasMaxLength(100).HasColumnType("VARCHAR");
            Property(c => c.Address).IsRequired().HasMaxLength(500).HasColumnType("VARCHAR");
            //HasMany(c => c.Orders).WithRequired(o => o.Customer).HasForeignKey(o => o.CustomerID).WillCascadeOnDelete(false);

        }
    }
}