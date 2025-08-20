using Microsoft.AspNetCore.Mvc;

namespace hrportalNew.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult Events()
        {
            return View();
        }
    }
}
