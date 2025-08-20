using Microsoft.AspNetCore.Mvc;
using hrportalNew.Middleware.User;

namespace hrportalNew.Controllers
{
       [AuthUser]
    public class InternalVacController : Controller
    {
         [HttpGet("internalVacancies")]
        public IActionResult InternalVac()
        {
            return View();
        }
    }
}
