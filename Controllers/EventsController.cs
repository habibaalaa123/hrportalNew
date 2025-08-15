using Microsoft.AspNetCore.Mvc;

namespace hrportalNew.Controllers
{
    public class Events : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
