using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SessionTalk.Models;
using Microsoft.AspNetCore.Http;

namespace SessionTalk.Controllers
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
            ViewBag.UserName = HttpContext.Session.GetString("Name");
            ViewBag.CurrentPage = "Home";
            return View();
        }

        [HttpGet("counter")]
        public IActionResult Counter()
        {
            ViewBag.UserName = HttpContext.Session.GetString("Name");
            ViewBag.CurrentPage = "Counter";
            int? countVar = HttpContext.Session.GetInt32("Count");
            ViewBag.Count = countVar;
            return View();
        }

        [HttpPost("submit")]
        public IActionResult Submit(string name)
        {
            HttpContext.Session.SetString("Name", name);
            return RedirectToAction("Index");
        }

        [HttpGet("countUp")]
        public IActionResult CountUp()
        {
            int? countVar = HttpContext.Session.GetInt32("Count");
            if(countVar == null)
            {
                HttpContext.Session.SetInt32("Count", 1);
            }
            else
            {
                HttpContext.Session.SetInt32("Count", (int)countVar + 1);
            }


            return RedirectToAction("Counter");
        }

        public IActionResult Privacy()
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