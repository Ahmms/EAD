using Microsoft.AspNetCore.Mvc;

namespace Project_.Controllers
{
    public class AllVehicleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
