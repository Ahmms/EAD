using Microsoft.AspNetCore.Mvc;
using Project_.Models;
namespace Project_.Controllers
{
    public class UsController : Controller
    {
        public ViewResult ContactUs()
        {
            return View("ContactUs");
        }
        public ViewResult AboutUs()
        {
            return View("AboutUs");
        }
        [HttpPost]
        public IActionResult ContactUs(ContactUs cu)
        {
            if (ModelState.IsValid)
            {
                ContactUsFunction.AddMessage(cu);
                return View("ContactUs");
            }
            else
            {
                return View("ContactUs");
            }
        }
    }
}
