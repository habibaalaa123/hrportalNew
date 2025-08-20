using Microsoft.AspNetCore.Mvc;
using hrportalNew.Middleware.User;
namespace hrportalNew.Controllers
{
     [AuthUser]
     
    public class TawasolController : Controller
    {
        [HttpGet("tawasol")]
        public IActionResult Tawasol()
        {
            return View();
        }
    }
}
