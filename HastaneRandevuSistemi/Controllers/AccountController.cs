using HastaneRandevuSistemi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HastaneRandevuSistemi.Controllers
{
    public class AccountController : Controller
    {
        
        public IActionResult Login()
        {
           
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if(model.Username == "Abdülkadir" && model.Password == "30358675872Abc++")
                    return RedirectToAction("AccountOperations"); 

            }
            return View(model);
        }

       

        [HttpGet]
        public IActionResult AccountOperations()
        {
            

            return View();
        }

        
    }
}
