using Microsoft.AspNetCore.Mvc;
using Packs.Models;
using System.Collections.Generic;

namespace Packs.Controllers
{
 public class ItemsController : Controller
 {
  [HttpGet("/things")]
  public ActionResult Index()
  {
      List<Tracking> newTracking = Tracking.GetAll();
      return View(newTracking);
  }

  [HttpGet ("/things/new")]
  public ActionResult New()
  {
      return View();
  }
  [HttpPost ("/things")]
  public ActionResult Create(string name, string category)
  {
      Tracking newTracking = new Tracking(name, category);
      return RedirectToAction("Index");
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