
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MGO_MVC.Models;

namespace MGO_MVC.Controllers
{
    public class CategoryController : Controller
    {

        private MGOContext context { get; set; }

        public CategoryController(MGOContext ctx)
        {
            context = ctx;
        }

        [Route("[controller]s")]
        public IActionResult List()
        {
            List<Category> category = context.Categories.OrderBy(c => c.CategoryId).ToList();
            return View(category);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";

            ViewBag.Categories = context.Categories.ToList();

            return View("AddEdit", new Category());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";

            ViewBag.Categories = context.Categories.ToList();

            var category = context.Categories.Find(id);
            return View("AddEdit", category);
        }

        [HttpPost]
        public IActionResult Save(Category category)
        {
            if (category.CategoryId == 0)
            {
                ViewBag.Action = "Add";
            }
            else
            {
                ViewBag.Action = "Edit";
            }

            if (ModelState.IsValid)
            {
                if (ViewBag.Action == "Add")
                {
                    context.Categories.Add(category);
                }
                else
                {
                    context.Categories.Update(category);
                }
                context.SaveChanges();
                return RedirectToAction("List");
            }
            else
            {
                ViewBag.Categories = context.Categories.ToList();
                return View("AddEdit", category);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var category = context.Categories.Find(id);
            return View(category);
        }

        [HttpPost]
        public IActionResult Delete(Category category)
        {
            context.Categories.Remove(category);
            context.SaveChanges();
            return RedirectToAction("List");
        }
    }

}
