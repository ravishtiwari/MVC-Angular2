using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MasterDetail.Models
{
    public class ProductCategory
    {

        [Key]
        public int CategoryID { get; set; }


        [Required(ErrorMessage = "CatagoryName can't be empty")]
        public string CatagoryName { get; set; }

      
        public int? ParentID { get; set; }

        public virtual ProductCategory Parent { get; set; }

        public virtual ICollection<ProductCategory> Children { get; set; }

        public virtual ICollection<Product> Products { get; set; }

    }
}