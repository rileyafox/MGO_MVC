using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MGO_MVC.Models
{
    public class SaleItem
    {
        [Required]
        public int ItemId { get; set; }

        [Required]  
        public int SaleId { get; set; }

        public int SaleQtySold { get; set; }

        public Item Item { get; set; }

        public Sale Sale { get; set; }

    }
}
