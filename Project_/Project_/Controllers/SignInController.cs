using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project_.Models;
using Project_.Models.Interface;

namespace Project_.Controllers
{
    public class SignInController : Controller
    {
        private IUserRepository userRepository;
        public SignInController(IUserRepository iu)
        {
            userRepository=iu;
        }
        [HttpGet]
        public ViewResult SignIn()
        {
            SignIn si = new SignIn();
            si.message = "";
            return View("SignInPage",si);
        }
        [HttpPost]
        public IActionResult SignIn(SignIn si)
        {
            if (!ModelState.IsValid)
            {
                bool check = userRepository.credential_verification(si);
                if (check == true)
                {
                    // return View("~/Views/Home/LoginHome.cshtml", hs.DisplayUsers());
                    CookieOptions options = new CookieOptions();
                    options.Expires = DateTime.Now.AddDays(365);
                    HttpContext.Response.Cookies.Append("Username", si.userName, options);
                    Environment.SetEnvironmentVariable("userId", ""+si.userName+"");
                    string id = Environment.GetEnvironmentVariable("userId");
                    return RedirectToAction("LoginHome", "Home");
                }
                else
                {
                    si.message = "Invalid UserName or Password!";
                    return View("SignInPage", si);
                }
            }
            else
            {
                return View("SignInPage");
            }
        }
        public IActionResult LogOut()
        {
            var cookie = Request.Cookies["Username"];
            if (cookie == null)
            {
                return RedirectToAction("SignIn", "SignIn");
            }
            Response.Cookies.Delete("Username");
            return RedirectToAction("LoginHome", "Home");
        }
    }
}
