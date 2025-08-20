using Microsoft.AspNetCore.Mvc;
using hrportalNew.Middleware.User;

namespace hrportalNew.Controllers
{
       [AuthUser]
    public class ChangePassController : Controller
    {
         [HttpGet("changePassword")]
        public IActionResult ChangePass()
        {
            return View();
        }
    }
}
