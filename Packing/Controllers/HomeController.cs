using Microsoft.AspNetCore.Mvc;
using Packs.Models;

namespace Packs.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

  }
}