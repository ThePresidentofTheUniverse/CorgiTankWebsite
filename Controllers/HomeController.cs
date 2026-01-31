using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace corgitankwebsite.Controllers
{
    public class HomeController : Controller
    {
        //DO NOT REMOVE THIS BREAKS PROGRAM
        [HttpGet]
        public IActionResult Index() //Presents the data to the user / allows them to go different pages
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult AboutWebsite()
        {
            return View();
        }


        //If it uses HttpPost, then it takes in data from the user.
    }
}
