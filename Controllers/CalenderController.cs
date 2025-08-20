using Microsoft.AspNetCore.Mvc;
using hrportalNew.Middleware.User;

namespace hrportalNew.Controllers
{
       [AuthUser]
    public class CalenderController : Controller
    {
         [HttpGet("calender")]
        public IActionResult Calender()
        {
            return View();
        }
    }
}
