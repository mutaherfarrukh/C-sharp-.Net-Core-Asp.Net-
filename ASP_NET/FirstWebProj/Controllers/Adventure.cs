using Microsoft.AspNetCore.Mvc;

namespace ChooseYourOwnAdventure.Controllers
{
    public class AdventureController : Controller
    {

        [HttpGet(" ")]
        public IActionResult Main()
        {
            return View();
        }
    }
}