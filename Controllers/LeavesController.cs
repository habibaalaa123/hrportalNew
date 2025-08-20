using Microsoft.AspNetCore.Mvc;

namespace hrportalNew.Controllers
{
    public class LeavesController : Controller
    {
        public IActionResult Leaves()
        {
            return View();
        }
    }
}
