using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CRUDelicious.Models;

namespace CRUDelicious.Controllers
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
            ViewBag.AllDishes = _context.Dishes.ToList();
            return View();
        }

        [HttpGet("NewDish")]
        public IActionResult NewDish()
        {
            
            return View();
        }

        [HttpPost("/submit/dish")]
        public IActionResult SubmitDish(Dish newdish)
        {
            if(ModelState.IsValid)
            {

                _context.Dishes.Add(newdish);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            
        return View("NewDish");  
        }

        [HttpGet("dishes/{id}")]
        public IActionResult SingleDishPage(int id)
        {
            ViewBag.SingleCharacter = _context.Dishes.FirstOrDefault(dsh => dsh.DishId == id);
            return View("SingleDish");
        }

        [HttpGet("dishes/delete/{id}")]
        public IActionResult DeleteDish(int id)
        {
            Dish deleteMe =_context.Dishes.FirstOrDefault(del => del.DishId == id);
            _context.Dishes.Remove(deleteMe);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        //UPDATE
        [HttpGet("dishes/edit/{id}")]
        public IActionResult EditDish(int id)
        {
            Dish updateDish = _context.Dishes
                .FirstOrDefault(dsh => dsh.DishId == id);

            return View(updateDish);
        }

        [HttpPost("dishes/submitEdit")]
        public IActionResult SubmitEdit(Dish editedDish)
        {
            if(ModelState.IsValid)
            {
                Dish editMe = _context
                    .Dishes.FirstOrDefault(dsh => dsh.DishId == editedDish.DishId);

                editMe.ChefName = editedDish.ChefName;
                editMe.DishName = editedDish.DishName;
                editMe.Calories = editedDish.Calories;
                editMe.Description = editedDish.Description;
                editMe.Tastiness = editedDish.Tastiness;
                editMe.UpdatedAt = DateTime.Now;

                _context.SaveChanges();

                return RedirectToAction("SingleDish", new {id = editedDish.DishId});

            }
            else
            {
                return View("EditDish");
            }
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
