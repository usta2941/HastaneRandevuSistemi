using HastaneRandevuSistemi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HastaneRandevuSistemi.Controllers
{
    public class DoctorController : Controller
    {
        
        public IActionResult Ekle()
        {
            return View();
        }
        /*
        [HttpPost]
        public IActionResult Ekle(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // ekleme işlemleri yapılacak
            }
            return View();
        }*/


    }
}
