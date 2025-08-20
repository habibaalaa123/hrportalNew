using Microsoft.AspNetCore.Mvc;

namespace hrportalNew.Controllers
{
    public class AttendanceController : Controller
    {
        public IActionResult Attendance()
        {
            return View();
        }
    }
}
