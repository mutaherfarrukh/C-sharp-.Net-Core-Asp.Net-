using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsORM.Models;
using Microsoft.EntityFrameworkCore;


namespace SportsORM.Controllers
{
    public class HomeController : Controller
    {

        private static Context _context;

        public HomeController(Context DBContext)
        {
            _context = DBContext;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.BaseballLeagues = _context.Leagues
                .Where(l => l.Sport.Contains("Baseball"))
                .ToList();
            return View();
        }

        [HttpGet("level_1")]
        public IActionResult Level1()
        {
            ViewBag.WomensLeagues = _context.Leagues
                .Where(Wleagues => Wleagues.Name.Contains("Women"))
                .ToList();


            ViewBag.AnyHockey = _context.Leagues
            .Where(Ahockey => Ahockey.Sport.Contains("Hockey"))
            .ToList();

            ViewBag.Football = _context.Leagues
            .Where(NoFootball => !NoFootball.Sport.Contains("Football"))
            .ToList();

            ViewBag.ConfLeagues = _context.Leagues
            .Where(Conferleag => Conferleag.Name.Contains("Conference"))
            .ToList();

            ViewBag.AtlanticLeagues = _context.Leagues
            .Where(atlanticleag => atlanticleag.Name.Contains("Atlantic"))
            .ToList();

            ViewBag.DallasTeams = _context.Teams
            .Where(dalteams => dalteams.Location.Contains("Dallas"))
            .ToList();

            ViewBag.RaptorTeams = _context.Teams
            .Where(rapteam => rapteam.TeamName.Contains("Raptors"))
            .ToList();

            ViewBag.CityLeagues = _context.Teams
            .Where(cityleagues => cityleagues.Location.Contains("City"))
            .ToList();

            ViewBag.TLeagues = _context.Teams
            .Where(TstartLeagues => TstartLeagues.TeamName.Contains("T"))
            .ToList();

            ViewBag.AlphabetLeagues = _context.Teams.OrderBy(alpha => alpha.Location)
            .ToList();

            ViewBag.RevAlphabetTeams= _context.Teams.OrderByDescending(alpha => alpha.TeamName)
            .ToList();

            ViewBag.playerlastCooper= _context.Players.Where(lastNameCooper => lastNameCooper.LastName.Contains("Cooper"))
            .ToList();

            ViewBag.playerFirstJoshua = _context.Players.Where(firstNameJoshua => firstNameJoshua.FirstName.Contains("Joshua"))
            .ToList();

            ViewBag.LastCooperNotFirstJoshua = _context.Players.Where(nojoshyescooper => nojoshyescooper.LastName.Contains("Cooper")).Where(nojoshyescooper => !nojoshyescooper.FirstName.Contains("Joshua"))
            .ToList();


            ViewBag.ThisOrThat = _context.Players.Where(AlexanderOrWyatt => AlexanderOrWyatt.FirstName.Contains("Alexander") || AlexanderOrWyatt.FirstName.Contains("Wyatt"))
            .ToList();



            return View();
        }

        [HttpGet("level_2")]
        public IActionResult Level2()
        {

            ViewBag.AllAltteams = _context.Teams
                .Include(alb => alb.CurrLeague).Where(alb => alb.CurrLeague.Name.Contains("Atlantic Soccer Conference"))
                .ToList();
            // ViewBag.AllAltteams = _context.Leagues
            //     .Include(league => league.Teams)
            //     .FirstOrDefault(league => league.Name == "Atlantic Soccer Conference");


            ViewBag.AllPlayersBoston = _context.Teams
                .Include(alb => alb.CurrentPlayers).Where(alb => alb.TeamName.Contains("Penguins"))
                .ToList();

            // ViewBag.InterPlayer = _context.

            return View();





        }

        [HttpGet("level_3")]
        public IActionResult Level3()
        {
            return View();
        }

    }
}