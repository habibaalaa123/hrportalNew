using Microsoft.AspNetCore.Mvc;
using hrportalNew.Middleware.User;

namespace hrportalNew.Controllers
{
       [AuthUser]
    public class MyProfileController : Controller
    {
        [HttpGet("myProfile")]
        public IActionResult MyProfile()
        {
            return View();
        }
    }
}
