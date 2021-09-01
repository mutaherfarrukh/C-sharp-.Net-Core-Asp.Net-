using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DojoSurvey.Models;
// using CharacterForm.Models;
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
        [Route("submit")]
        public IActionResult Submit(string name, string location, string language, string comment)
        {
            Dictionary<string, string> results = new Dictionary<string, string>()
            {
                {"Name", name},
                {"Location", location},
                {"Language", language},
                {"Comment", comment}
            };

            ViewBag.Result = results;

            foreach (KeyValuePair<string,string> entry in results)
            {
                Console.WriteLine(entry.Key + ": " + entry.Value);
            }

            return View("Result");
        }

    }
}
