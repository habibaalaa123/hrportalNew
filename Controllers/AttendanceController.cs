using Microsoft.AspNetCore.Mvc;
using hrportalNew.Middleware.User;

namespace hrportalNew.Controllers
{
       [AuthUser]
    public class AttendanceController : Controller
    {
         [HttpGet("attendance")]
        public IActionResult Attendance()
        {
            return View();
        }
    }
}
