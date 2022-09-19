using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project_.Models;
namespace Project_.Controllers
{
    public class HomeController : Controller
    {
        
        public ViewResult Home()
        {
            return View("Home");
        }
        public ViewResult LoginHome()
        {
            List<AdsDatum> ads = new List<AdsDatum>();
            ads = HomeFunctions.getCars();
            if (ads != null)
            {
                return View(ads);
            }
            else return View();
        }
    }
    public class LoginHomeController : Controller
    {
        
    }
}
