using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MGO_MVC.Models;


namespace MGO_MVC.Controllers
{
    public class ItemController : Controller
    {

        private MGOContext context { get; set; }

        public ItemController(MGOContext ctx)
        {
            context = ctx;
        }

        [Route("[controller]s")]
        public IActionResult List()
        {
            List<Item> items = context.Items.OrderBy(p => p.CategoryId).ToList();
            return View(items);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("AddEdit", new Item());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var item = context.Items.Find(id);
            return View("AddEdit", item);
        }

        [HttpPost]
        public IActionResult Save(Item item)
        {
            if (ModelState.IsValid)
            {
                if (item.ItemId == 0)
                {
                    context.Items.Add(item);
                }
                else
                {
                    context.Items.Update(item);
                }
                context.SaveChanges();
                return RedirectToAction("List");
            }
            else
            {
                if (item.ItemId == 0)
                {
                    ViewBag.Action = "Add";
                }
                else
                {
                    ViewBag.Action = "Edit";
                }
                return View( item);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var item = context.Items.Find(id);
            return View(item);
        }

        [HttpPost]
        public IActionResult Delete(Item item)
        {
            context.Items.Remove(item);
            context.SaveChanges();
            return RedirectToAction("List");
        }
    }
}

