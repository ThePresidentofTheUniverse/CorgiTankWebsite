//Used for the Things I Love section
using Microsoft.AspNetCore.Mvc;

namespace corgitankwebsite.Controllers
{

    public class LoveController : Controller
    {
        [HttpGet]
        public IActionResult MainLove()
        {
            return View();
        }

        public IActionResult Music()
        {
            return View();
        }

        public IActionResult Film()
        {
            return View();
        }

        public IActionResult VideoGame()
        {
            return View();
        }
    }
}
