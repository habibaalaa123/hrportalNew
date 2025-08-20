using Microsoft.AspNetCore.Mvc;

namespace hrportalNew.Controllers
{
    public class FAQController : Controller
    {
        public IActionResult FAQ()
        {
            return View();
        }
    }
}
