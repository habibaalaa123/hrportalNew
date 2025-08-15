using Microsoft.AspNetCore.Mvc;

namespace hrportalNew.Controllers
{
    public class HrDocsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
