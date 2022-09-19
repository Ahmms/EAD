using Microsoft.AspNetCore.Mvc;
using Project_.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using System;
using Microsoft.AspNetCore.Hosting;

namespace Project_.Controllers
{
    public class PostAdController : Controller
    {
        private IWebHostEnvironment _webHostEnvironment;
        public PostAdController(IWebHostEnvironment env)
        {
            _webHostEnvironment = env;
        }
        public IActionResult Ads()
        {
            var cookie = Request.Cookies["Username"];
            if (cookie == null)
            {
                return RedirectToAction("SignIn", "SignIn");
            }
            return View("Ads");
        }
        public IActionResult AdsView(AdsDatum ad, IFormFile image1)
        {
            
            var cookie = Request.Cookies["Username"];
            if (cookie == null)
            {
                return RedirectToAction("SignIn", "SignIn");
            }
            ad.UserName = Environment.GetEnvironmentVariable("userId");
            string str = AdsFunction.getId();
            if (image1 != null)
            {
                string filename = "Images/AdImages/" + str + ".png";
                string Serverfilename = Path.Combine(_webHostEnvironment.WebRootPath, filename);
                FileStream f = new FileStream(Serverfilename, FileMode.Create);
                image1.CopyTo(f);
                f.Close();
                ad.Image = filename;
            }
            else
            {
                ad.Image = "";
            }
            AdsFunction.uploadAd(ad);
            return View("Ads");
        }
    }

}
