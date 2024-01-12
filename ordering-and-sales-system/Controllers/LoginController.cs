using Microsoft.AspNetCore.Mvc;
using ordering_and_sales_system.Models;

namespace ordering_and_sales_system.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View("Views/Accounts/Login.cshtml");
        }

        [HttpPost]
        public IActionResult Login(LoginModel login)
        {
            return RedirectToAction("Dashboard", "Home");
        }
    }
}
