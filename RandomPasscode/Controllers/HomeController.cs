using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RandomPasscode.Models;
using Microsoft.AspNetCore.Http;

namespace RandomPasscode.Controllers
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

            // System.Console.WriteLine(TempData["passcode"]);
            // int? count = HttpContext.Session.GetInt32("count");
            // if(count == null)
            // {
            //     HttpContext.Session.SetInt32("count", 1);
            // }
            // HttpContext.Session.SetInt32("count", 6);
            // ViewBag.count = HttpContext.Session.GetInt32("count");
            
            
            // else
            // {
                
            //     // HttpContext.Session.SetInt32("count", (int)count);
            //     // count += 1;
            // }
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var stringChars = new char[14];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);
            ViewBag.Example = finalString;
            return View();
        }

        // public int IncreaseCount(int count)
        // {
        //     count += 1;
        //     return count;
        // }



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
