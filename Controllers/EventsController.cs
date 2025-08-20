using Microsoft.AspNetCore.Mvc;

namespace hrportalNew.Controllers
{
    public class EventsController : Controller
    {
         [HttpGet("events")]
        public IActionResult Events()
        {
            return View();
        }
    }
}
