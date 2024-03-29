﻿using DEMO.Web.Models;
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
            int x = 18;
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