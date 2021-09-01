using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DojoSurvey.Models;
using Microsoft.AspNetCore.Http;

namespace DojoSurvey.Controllers
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

        [HttpGet("result")]
        public IActionResult Result()
        {
            return View();
        }

        // [HttpPost("submit")]
        // public IActionResult Submit(Character newCharacter)
        // {
        //     if(ModelState.IsValid)
        //     {
        //         return RedirectToAction("Result");
        //     }
        //     Console.WriteLine(newCharacter);
        //     return View("Index");
        // }

        [HttpPost]
        [Route("result")]
        public IActionResult Submit(Dojo dojo)
        {
            if(ModelState.IsValid)
            {

            // Dictionary<string, string> results = new Dictionary<string, string>()
            // {
            //     {"Name", name},
            //     {"DojoLocation", DojoLocation},
            //     {"FavoriteLanguage", FavoriteLanguage},
            //     {"Comment", comment}
            // };

            // ViewBag.Result = results;

            // foreach (KeyValuePair<string,string> entry in results)
            // {
            //     Console.WriteLine(entry.Key + ": " + entry.Value);
            // }

            return View("Result", dojo);
            }
            return View("Index");

    }
    }
}
