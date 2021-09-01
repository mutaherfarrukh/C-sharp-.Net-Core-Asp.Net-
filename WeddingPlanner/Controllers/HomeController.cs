using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WeddingPlanner.Models;

namespace WeddingPlanner.Controllers
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
            if (HttpContext.Session.GetInt32("UserId") != null)
            {
                ViewBag.CurrentUser = _context.Users
                    .FirstOrDefault(u => u.UserId.Equals((int)HttpContext.Session.GetInt32("UserId")));
            }
            return View();
        }

        [HttpPost("Register")]
        public IActionResult Register(RegisterUser newUser)
    {
        if(ModelState.IsValid)
        {
            if(_context.Users.Any(user => user.Email == newUser.Email))
            {
                ModelState.AddModelError("Email", "Email is Already in Use!");
                return View("Index", newUser);
            }
            ///register user here
            PasswordHasher<RegisterUser> Hasher = new PasswordHasher<RegisterUser>();
            newUser.Password = Hasher.HashPassword(newUser, newUser.Password);

            _context.Users.Add(newUser);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        return View("Index", newUser);
    }

        [HttpGet("login")]
        public IActionResult LoginPage()
        {
            return View();
        }

        [HttpPost("checkLogin")]
        public IActionResult CheckLogin(LoginUser login)
        {
            if(ModelState.IsValid)
            {
                RegisterUser userInDb = _context.Users.FirstOrDefault(user => user.Email == login.LoginEmail);
                if(userInDb == null)
                {
                    ModelState.AddModelError("LoginEmail", "Invalid Login");

                    return View("LoginPage", login);
                }
                PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(login, userInDb.Password, login.LoginPassword);

                if(result == 0)
                {
                    ModelState.AddModelError("LoginEmail", "Invalid Login");

                    return View("LoginPage", login);
                }
                Console.WriteLine("logged in");
                HttpContext.Session.SetInt32("userId", userInDb.UserId);
                return RedirectToAction("Dashboard");
            }
            return View("LoginPage");
        }

        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            int? loggedUserId = HttpContext.Session.GetInt32("userId");
            if(loggedUserId == null) return RedirectToAction("Index");


            ViewBag.WedComing = _context.WedUsers
                .Include(u => u.AllUsers)
                .ToList();
                Console.WriteLine("Dashboard");

                Console.WriteLine( _context.WedUsers
                .Include(wdusr => wdusr.RegUserData)
                .ToList());
                Console.WriteLine(loggedUserId);

            ViewBag.CurrentUser = _context.Users
                    .FirstOrDefault(u => u.UserId.Equals(loggedUserId));

            Console.WriteLine("Dashboard3");
            return View();
            
        }


        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        [HttpGet("createnew")]
        public IActionResult SubmitWedDetail()
        {
            return View("SubmitWedDetail");
        }

        [HttpPost("submitWedList")]
        public IActionResult SubmitWedList(WeddingUsers wedUser)
        {
            
            if(ModelState.IsValid)
            {

                _context.Add(wedUser);
                _context.SaveChanges();

                return View("WedDetail");
            }
            return View("Index");
        }

        [HttpGet("submit/{id}")]
        public IActionResult SubmitShow(int id)
        {
            ViewBag.SubmitShow = _context.WedUsers
                .FirstOrDefault(sing => sing.WeddingUserId == id);
            return View("WedDetail");
        }

        [HttpGet("wedPlan/delete/{id}")]
        public IActionResult Delete(int id)
        {

            if(ModelState.IsValid)
            {
            WeddingUsers deleteMe =_context.WedUsers
                .FirstOrDefault(del => del.WeddingUserId == id);
            _context.WedUsers.Remove(deleteMe);
            _context.SaveChanges();

            return RedirectToAction("Dashboard");
            }
        return View("Index");
        }

        [HttpPost("add/rsvp/{id}")]
        public IActionResult RSVPAdd(RSVP rsvp)
        {
            if(ModelState.IsValid)
            {

                _context.Add(rsvp);
                _context.SaveChanges();
                return RedirectToAction("WedDetail");
            }
            else
            {
                return View("WedDetail");
            }
        }

        [HttpPost("remove/rsvp/{id}")]
        public IActionResult UnRSVP(int id)
        {
            RSVP rsvp = _context.RSVPUsers.Where(a => a.WeddingId.Equals(id))
                .FirstOrDefault(b => b.UserId.Equals((int)HttpContext.Session.GetInt32("UserId")));
            _context.Remove(rsvp);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
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
