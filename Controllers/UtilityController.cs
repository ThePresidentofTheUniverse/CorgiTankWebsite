//Used for the Utilities Section
using Microsoft.AspNetCore.Mvc;

namespace corgitankwebsite.Controllers
{
    public class UtilityController :Controller
    {
        [HttpGet]
        public IActionResult MainUtility()
        {
            return View();
        }

    }
}
