using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProductsAndCategories.Models;

namespace ProductsAndCategories.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;

        public HomeController(MyContext context)
        {
            _context = context;
        }


        [HttpPost("submit/product")]
        public IActionResult SubmitProduct(Product product)
        {
            if(ModelState.IsValid)
            {
                // _context.Update(product);
                _context.Add(product);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            
        return View("Index");  
        }

        [HttpPost("submit/category")]
        public IActionResult SubmitCategory(Category cat)
        {
            if(ModelState.IsValid)
            {
                _context.Add(cat);
                _context.SaveChanges();
                return RedirectToAction("Categories");
            }
            
        return View("Categories");  
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            
            ViewBag.Index = _context.products
            // .(prd => prd.ProductId == id);
            // ViewBag.AllProduct = _context.products
            // .Include(prd => prd.productsAssociated)
            .ToList();
            return View();
        }

        [HttpGet("products/{id}")]
        public IActionResult SingleProduct(int id)
        {
            ViewBag.SingleProduct = _context.products
            .FirstOrDefault(prd => prd.ProductId == id);

            ViewBag.NotCategories = _context.categories
            .Include(ct => ct.categoriesAssociated)
                .ThenInclude(ct2 => ct2.products)
            .Where(ab => ab.categoriesAssociated.Any(cd => cd.products.ProductId.Equals(id)))
            .ToList();

            ViewBag.Categories = _context.categories
            .Include(ct => ct.categoriesAssociated)
            //     .ThenInclude(ct2 => ct2.products)
            // .Where(ab => ab.categoriesAssociated.Any(cd => cd.products.ProductId.Equals(id)))
            .ToList();


            return View("DisplayProduct");
        }

        [HttpGet("Categories")]
        public IActionResult Categories()
        {
                ViewBag.Categories = _context.categories
                .ToList();
                return View();
        }
        // [HttpPost("submitProduct")]
        // public IActionResult SubmitOneProduct(Product ct)
        // {
        //     if(ModelState.IsValid)
        //     {
        //     _context.Add(ct);
        //     _context.SaveChanges();
        //     return RedirectToAction("DisplayProduct");
        //     }
        //     return View("DisplayProduct");
        // }

        [HttpGet("category/{id}")]
        public IActionResult SingleCategory(int id)
        {
            ViewBag.SingleCategory = _context.categories.FirstOrDefault(prd => prd.CategoryId == id);
            ViewBag.products = _context.products.ToList();

            ViewBag.dispProduct = _context.products
            .Where(pit => pit.ProductId == id)
            .ToList();
            return View("DisplayCategory");
        }

        [HttpPost("submit/Onecategory")]
        public IActionResult SubmitOneCategory(Category cat)
        {
            if(ModelState.IsValid)
            {
                _context.Add(cat);
                _context.SaveChanges();
                return RedirectToAction("DisplayCategory");
            }
            
        return View("DisplayCategory");  
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
