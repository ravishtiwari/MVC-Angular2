using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MasterDetail.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }

        [Required(ErrorMessage = "Customer name can't be empty")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "Phone can't be empty")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Address can't be empty")]
        public string Address { get; set; }


        public virtual ICollection<Order> Orders { get; set; }
    }
}