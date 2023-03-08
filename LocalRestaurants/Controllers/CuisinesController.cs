using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LocalRestaurants.Models;
using System.Collections.Generic;
using System.Linq;

namespace LocalRestaurants.Controllers
{
  public class CuisinesController : Controller
  {
    private readonly LocalRestaurantsContext _db;

    public CuisinesController(LocalRestaurantsContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Cuisine> model = _db.Cuisines.ToList();
      return View(model);
    }
  }
}