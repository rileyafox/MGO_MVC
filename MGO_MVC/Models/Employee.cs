using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MGO_MVC.Models
{
    public class Employee
    {
        [Required]
        public int EmployeeId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Position { get; set; }

        [Range(0, 1000000)]
        [Column(TypeName = "decimal(8,2)")]
        public decimal Commission { get; set; }

    }
}
