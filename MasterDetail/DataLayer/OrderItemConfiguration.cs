using MasterDetail.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace MasterDetail.DataLayer
{
    public class OrderItemConfiguration : EntityTypeConfiguration<OrderItem>

    {
        public OrderItemConfiguration()
        {

            Property(oi => oi.OrderItemID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(oi => oi.Amount).IsRequired();
            HasRequired(oi => oi.Order).WithMany(o => o.OrderItems).HasForeignKey(oi => oi.OrderID).WillCascadeOnDelete(false);
            HasRequired(oi => oi.Product).WithMany(p => p.OrderItems).HasForeignKey(oi => oi.ProductID).WillCascadeOnDelete(false);



        }
    }
}