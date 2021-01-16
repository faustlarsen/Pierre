using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Pierre.Models;


namespace Pierre.Controllers
{
  public class HomeController : Controller
  {
    private readonly PierreContext _db;

    public HomeController(PierreContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      var PierreList = new GoodiesList();
      PierreList.FlavorList = _db.Flavors.ToList();
      PierreList.TreatList = _db.Treats.ToList();
      return View(PierreList);
    }
  }
}
