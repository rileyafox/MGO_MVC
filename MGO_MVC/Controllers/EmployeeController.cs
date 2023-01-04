using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MGO_MVC.Models;


namespace MGO_MVC.Controllers
{
    public class EmployeeController : Controller
    {
        private MGOContext context { get; set; }


        public EmployeeController(MGOContext ctx)
        {
            context = ctx;
        }

        [Route("[controller]s")]
        public IActionResult List(string filter)
        {
            if (filter == null)
                filter = "all";


            IQueryable<Employee> query = context.Employees

                .OrderBy(i => i.EmployeeId);
            

            if (filter == "manager")
            {
                query = query.Where(i => i.Position == "Manager");
            }

            if (filter == "buyer/seller")
            {
                query = query.Where(i => i.Position == "Buyer/Seller");
            }

            if (filter == "seller")
            {
                query = query.Where(i => i.Position == "Seller");
            }

            var employees = query.ToList();

            EmployeeListViewModel model = new EmployeeListViewModel();

            model.Filter = filter;
            model.Employees = employees;

            return View("List", model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("AddEdit", new Employee());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var tech = context.Employees.Find(id);
            return View("AddEdit", tech);
        }

        [HttpPost]
        public IActionResult Save(Employee employee)
        {
            if (ModelState.IsValid)
            {
                if (employee.EmployeeId == 0)
                {
                    context.Employees.Add(employee);
                }
                else
                {
                    context.Employees.Update(employee);
                }
                context.SaveChanges();
                return RedirectToAction("List");
            }
            else
            {
                if (employee.EmployeeId == 0)
                {
                    ViewBag.Action = "Add";
                }
                else
                {
                    ViewBag.Action = "Edit";
                }
                return View(employee);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var employee = context.Employees.Find(id);
            return View(employee);
        }

        [HttpPost]
        public IActionResult Delete(Employee employee)
        {
            context.Employees.Remove(employee);
            context.SaveChanges();
            return RedirectToAction("List");
        }
    }
}

