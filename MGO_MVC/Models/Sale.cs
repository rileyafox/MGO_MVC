using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MGO_MVC.Models
{
    public class Sale
    {
        [Required]
        public int SaleId { get; set; }

        public DateTime SaleDate { get; set; }

        public DateTime SaleTime { get; set; }

        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public ICollection<SaleItem> SaleItems { get; set; }
    }
}
