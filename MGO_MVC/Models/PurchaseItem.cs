using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MGO_MVC.Models
{
    public class PurchaseItem
    {
        [Required]
        public int PurchaseId { get; set; }

        [Required]
        public int ItemId { get; set; }

        public int PurchaseQty { get; set; }

        public Purchase Purchase { get; set; }

        public Item Item { get; set; }

    }
}
