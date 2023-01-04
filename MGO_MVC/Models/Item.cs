using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MGO_MVC.Models
{
    public class Item
    {
        [Required]
        public int ItemId { get; set; }

        public string Name { get; set; }

        [Range(0, 1000000)]
        [Column(TypeName = "decimal(8,2)")]
        public decimal Price { get; set; }

        [Range(0, 1000000)]
        [Column(TypeName = "decimal(8,2)")]
        public decimal Cost { get; set; }

        public int CategoryId { get; set; }

        public Category Category {get; set;}

        public ICollection<PurchaseItem> PurchaseItems { get; set; }

        public ICollection<SaleItem> SaleItems { get; set; }

    }
}
