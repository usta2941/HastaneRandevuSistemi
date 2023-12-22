using HastaneRandevuSistemi.Entities;
using HastaneRandevuSistemi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HastaneRandevuSistemi.Controllers
{
    
    public class AccountController : Controller
    {
        private readonly DatabaseContext _databaseContext;

        public AccountController(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

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

        [HttpPost]
        public IActionResult AccountRegister(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = new User()
                {
                    FullName = model.Username,
                    Password = model.Password
                };
                _databaseContext.Users.Add(user);
                _databaseContext.SaveChanges();

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
