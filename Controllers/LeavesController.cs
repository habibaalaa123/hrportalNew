using Microsoft.AspNetCore.Mvc;
using hrportalNew.Middleware.User;

namespace hrportalNew.Controllers
{
    [AuthUser]
       
    public class LeavesController : Controller
    {
        [HttpGet("leaves")]
        public IActionResult Leaves()
        {
            return View();
        }
    }
}
