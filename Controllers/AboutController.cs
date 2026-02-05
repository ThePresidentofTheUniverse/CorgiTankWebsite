//This is used specifically for the About section
using Microsoft.AspNetCore.Mvc;

namespace corgitankwebsite.Controllers
{
    public class AboutController : Controller
    {

        [HttpGet]
        public IActionResult About()
        {
            return View();
        }

        public IActionResult AboutWebsite()
        {
            return View();
        }

        public IActionResult AboutCreator()
        {
            return View();
        }


    }
}
