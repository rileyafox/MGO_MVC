using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MGO_MVC.Models
{
    public class Purchase
    {
        [Required]
        public int PurchaseId { get; set; }

        public DateTime PurchaseDate { get; set; }

        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }

        public ICollection<PurchaseItem> PurchaseItems { get; set; }

    }
}
