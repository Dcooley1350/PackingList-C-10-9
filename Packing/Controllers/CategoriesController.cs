using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Packs.Models;

namespace Packs.Controllers
{
    public class CategoriesController : Controller
    {
        [HttpGet("/categories")]
        public ActionResult Index()
        {
            List<Category> allCategories = Category.GetAll();
            return View(allCategories);
        }
        [HttpGet("/categories/new")]
        public ActionResult New()
        {
            return View();
        }
        [HttpPost("/categories")]
        public ActionResult Create(string categoryName)
        {
            Category newCategory = new Category (categoryName);
            return RedirectToAction("Index");
        }
        [HttpGet("/categories/{id}")]
        public ActionResult Show(int id)
        {
            Dictionary<string, object> model = new Dictionary<string,object>();
            Category selectedCategory = Category.Find(id);
            List<Tracking> packings = selectedCategory.Trackings;
            model.Add("category",selectedCategory);
            model.Add("tracking", packings);
            return View(model);
        }
        [HttpPost("/categories/{categoryId}/items")]
        public ActionResult Create(int categoryId, string name, string category)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Category foundCategory = Category.Find(categoryId);
            Tracking newTracking = new Tracking(name, category);
            foundCategory.AddItem(newTracking);
            List<Tracking> categoryItems = foundCategory.Trackings;
            model.Add("tracking", categoryItems);
            model.Add("category",foundCategory);
            return View("Show",model);

        }
    }
}