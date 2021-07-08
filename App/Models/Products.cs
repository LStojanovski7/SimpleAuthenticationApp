using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [Required]
        public string ProductName { get; set; }

        public virtual Order Orders { get; set; }
    }
}
