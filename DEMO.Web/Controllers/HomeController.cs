using DEMO.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DEMO.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag["abc"] = 12;
<<<<<<< HEAD
            int x = 18;
=======
            int x = 10;
>>>>>>> a7b8c7075ccf23d4faa7f7d39aada301ffd47bb5
            return View();
        }

        public IActionResult Privacy()
        {
            ViewBag["bcs"] = 13;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}