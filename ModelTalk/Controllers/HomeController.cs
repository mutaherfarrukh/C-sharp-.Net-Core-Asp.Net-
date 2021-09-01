using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ModelTalk.Models;

namespace ModelTalk.Controllers
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

            return View();
        }

        [HttpPost("display")]
        public IActionResult Display(Sundae newSundae)
        {
            // Sundae tinRoof = new Sundae()
            // {
            //     Scoops = 2,
            //     Flavor = "Vanilla",
            //     Sauce = "Chocolate syrup",
            //     Topping = "Peanuts",
            //     WhippedAndCherry = true,
            // };
            return View(newSundae);
        }

        [HttpGet("form")]
        public IActionResult Form()
        {
            return View();
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
