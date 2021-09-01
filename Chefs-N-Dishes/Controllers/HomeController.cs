using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Chefs_N_Dishes.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Chefs_N_Dishes.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;

        public HomeController(MyContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return RedirectToAction("AllChef");
        }

        // [HttpGet("dishes")]
        // public IActionResult Dishes()
        // {
        //     return View();
        // }

        [HttpGet("new")]
        public IActionResult ChefNew()
        {
            return View("NewChef");
        }

        [HttpGet("/dishesnew")]
        public IActionResult DishNew()
        {
            ViewBag.AllChef = _context.Chefs.ToList();
            return View("NewDish");
        }

        [HttpPost("submit/chef")]
        public IActionResult SubmitChef(Chef chef)
        {
            if(ModelState.IsValid)
            {
                _context.Add(chef);
                _context.SaveChanges();
                return RedirectToAction("AllChef");
            }
            
        return View("NewChef");  
        }

        [HttpGet("AllChef")]
        public IActionResult AllChef()
        {
            
                ViewBag.AllChef = _context.Chefs
                .Include(chf => chf.CreatedDishes)
                .ToList();
                return View();
        }

        [HttpPost("/submit/dish")]
        public IActionResult SubmitDish(Dish newdish)
        {
            if(ModelState.IsValid)
            {

                _context.Dishes.Add(newdish);
                _context.SaveChanges();
                return RedirectToAction("Dishes");
            }
            
        return View("NewDish");  
        }

        [HttpGet("Dishes")]
        public IActionResult Dishes()
        {
            
                ViewBag.Dishes = _context.Dishes
                .Include(dsh => dsh.Creator)
                .ToList();
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
