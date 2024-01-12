using Microsoft.AspNetCore.Mvc;
using ordering_and_sales_system.Models;
using System.Diagnostics;

namespace ordering_and_sales_system.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Inventory()
        {
            return View();
        }

        public IActionResult PendingOrders()
        {
            return View();
        }

        public IActionResult TransactionHistory()
        {
            return View();
        }

        public IActionResult Customer()
        {
            return View();
        }

        public IActionResult OrderReport()
        {
            return View();
        }

        public IActionResult SalesReport()
        {
            return View();
        }

        public IActionResult SignOut()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}