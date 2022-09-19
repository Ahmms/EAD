using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project_.Models;
using Project_.Models.Interface;

namespace Project_.Controllers
{
    public class SignUpController : Controller
    {
        private IUserRepository userRepository;
        public SignUpController(IUserRepository iu)
        {
            userRepository = iu;
        }
        [HttpGet]
        public ViewResult SignUp()
        {
            return View("SignUpPage");
        }
        [HttpPost]
        public ViewResult SignUp(UserDatum ud)
        {
            if (ModelState.IsValid)
            {
                userRepository.Add_Users(ud);
                SignIn si = new SignIn();
                si.message = "";
                return View("~/Views/SignIn/SignInPage.cshtml", si);
            }
            else
            {
                return View();
            }
        }
    }
}
