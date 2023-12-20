using HastaneRandevuSistemi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HastaneRandevuSistemi.Controllers
{
    public class AccountController : Controller
    {
        
        public IActionResult Login()
        {
            if(ModelState.IsValid)
            {
               
            }
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // login işlemleri
            }
            return View(model);
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
