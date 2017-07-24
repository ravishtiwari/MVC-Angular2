using MasterDetail.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace MasterDetail.DataLayer
{
    public class OrderConfiguration : EntityTypeConfiguration<Order>
    {

        public OrderConfiguration()
        {
            Property(o => o.OrderID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(o => o.OrderDate).IsRequired();
            Property(o => o.CustomerID).IsRequired();
            HasRequired(o => o.Customer).WithMany(c => c.Orders).HasForeignKey(o => o.CustomerID).WillCascadeOnDelete(false);
        }
    }
}