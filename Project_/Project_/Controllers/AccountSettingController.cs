using Microsoft.AspNetCore.Mvc;
using Project_.Models;
namespace Project_.Controllers
{
    public class AccountSettingController : Controller
    {
        public ViewResult Index()
        {
            return View("changePassword");
        }
        public IActionResult changePassword(AccountSetting AS)
        {
            AccountSettingFunctions.changePassword(AS);
            return View("changePassword");
        }
    }
}
