using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CharactersPowers.Models;
using Microsoft.EntityFrameworkCore;
using CharacterPowers.Models;

namespace CharactersPowers.Controllers
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
            ViewBag.AllCharacters = _context.Characters.ToList();
            return View();
        }

        [HttpGet("characters/form")]
        public IActionResult AddCharacterPage()
        {
            return View();
        }

        [HttpPost("characters/submit")]
        public IActionResult SubmitCharacter(Character newChar)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newChar);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View("AddCharacterPage");

        }

        [HttpGet("powers")]
        public IActionResult PowersPage()
        {
            ViewBag.AllPowers = _context.Powers
            .Include(pow => pow.CharacterPowers)
            .ThenInclude(name => name.Character)
            .ToList();
            return View("Powers");
        }

        [HttpGet("powers/form")]
        public IActionResult AddPowerPage()
        {
            return View();
        }

        [HttpPost("powers/submit")]
        public IActionResult SubmitPower(Power newPower)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newPower);
                _context.SaveChanges();

                return RedirectToAction("PowersPage");
            }
            return View("AddPowerPage");

        }

        [HttpGet("characters/{id}")]
        public IActionResult SingleCharacterPage(int id)
        {
            ViewBag.AllPowers = _context.Powers.ToList();
            ViewBag.SingleCharacter = _context.Characters
                .Include(chara => chara.CharacterPowers)
                .ThenInclude(chp => chp.Power)
                .FirstOrDefault(ch => ch.CharacterId == id);

            return View("SingleCharacter");
        }

        [HttpPost("characters/addPower")]
        public IActionResult AddPowerToCharacter(CharacterHasPower chp)
        {
            _context.Add(chp);
            _context.SaveChanges();

            return RedirectToAction("SingleCharacterPage", new {id=chp.CharacterId});
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