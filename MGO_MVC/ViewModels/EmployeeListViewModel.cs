using System.Collections.Generic;

namespace MGO_MVC.Models
{
    public class EmployeeListViewModel
    {

        public string Filter { get; set; }

        public IEnumerable<Employee> Employees { get; set; }

    }
}
