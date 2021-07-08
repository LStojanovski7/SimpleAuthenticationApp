using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        [Required]
        public int Quantity { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
