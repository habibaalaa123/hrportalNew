using Microsoft.AspNetCore.Mvc;

namespace hrportalNew.Controllers
{
    public class FAQController : Controller
    {
         [HttpGet("faq")]
        public IActionResult FAQ()
        {
            return View();
        }
    }
}
