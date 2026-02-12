using Microsoft.AspNetCore.Mvc;

namespace corgitankwebsite.Controllers
{
    public class HowToController : Controller
    {
        [HttpGet]
        public IActionResult MainHow()
        {
            return View();
        }

    }
}
