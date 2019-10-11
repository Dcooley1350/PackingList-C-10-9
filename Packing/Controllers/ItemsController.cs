using Microsoft.AspNetCore.Mvc;
using Packs.Models;
using System.Collections.Generic;

namespace Packs.Controllers
{
    public class ItemsController : Controller
    {
        [HttpGet("/categories/{categoryId}/items/{itemId}")]
        public ActionResult Show(int categoryId, int itemId)
        {
            Tracking item = Tracking.Find(itemId);
            Category category = Category.Find(categoryId);
            Dictionary<string, object> model = new Dictionary<string, object>();
            model.Add("tracking", item);
            model.Add("category", category);
            return View(model);
        }
        [HttpGet ("/categories/{categoryId}/items/new")]
        public ActionResult New(int categoryId)
        {
            Category category = Category.Find(categoryId);
            return View(category);
        }

        [HttpPost ("/things/itemDelete")]
        public ActionResult Delete(string searchID)
        {
            int intId = int.Parse(searchID);

            Tracking.DeleteItem(intId);
            return View();
        }
    } 
}

