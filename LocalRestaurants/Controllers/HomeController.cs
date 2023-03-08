using Microsoft.AspNetCore.Mvc;

namespace LocalRestaurants.Controllers
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