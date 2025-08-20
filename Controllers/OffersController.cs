using Microsoft.AspNetCore.Mvc;

namespace hrportalNew.Controllers
{
    public class OffersController : Controller
    {
        public IActionResult Offers()
        {
            return View();
        }
    }
}
