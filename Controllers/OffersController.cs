using Microsoft.AspNetCore.Mvc;

namespace hrportalNew.Controllers
{
    public class OffersController : Controller
    {
        [HttpGet("offers")]
        public IActionResult Offers()
        {
            return View();
        }
    }
}
