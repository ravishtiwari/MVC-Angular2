using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MasterDetail.Models
{
    public class Product
    {

        public int ProductID { get; set; }

        
        [Required(ErrorMessage="Product Code cann't be empty")]
        [DisplayName("Product Code")]
        public string ProductCode { get; set; }

        [Required(ErrorMessage="Product Name cann't be empty")]
        [DisplayName("Product Name")]
        public string  ProductName { get; set; }

        [Required(ErrorMessage="Product Category cann't be empty")]
        [DisplayName("Product Category")]
        public int CategoryID { get; set; }

        public virtual ProductCategory Category { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }

    }
}