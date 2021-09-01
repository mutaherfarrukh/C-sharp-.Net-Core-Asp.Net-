using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ArtistAlbums.Models;

namespace ArtistAlbums.Controllers
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
            ViewBag.AllArtist = _context.Artists
            .Include(art => art.CreatedAlbum)
            .ToList();
            return View();
        }

        [HttpPost("createArtist")]
        public IActionResult CreateArtist(Artist newArtist)
        {
            if(ModelState.IsValid)
            {
                _context.Artists.Add(newArtist);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Index");
        }

        [HttpGet("albums")]
        public IActionResult AlbumPage()
        {
            ViewBag.AllArtist = _context.Artists.ToList();
            ViewBag.AllAlbums = _context.Albums
            .Include(Album =)
            return RedirectToAction("Index");
        }

        [HttpPost("createAlbum")]
        public IActionResult CreateAlbum(Album newAlbum)
        {
            if(ModelState.IsValid)
            {
                _context.Albums.Add(newAlbum);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Index");
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
