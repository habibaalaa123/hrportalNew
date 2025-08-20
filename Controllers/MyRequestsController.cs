using Microsoft.AspNetCore.Mvc;
using hrportalNew.Middleware.User;

namespace hrportalNew.Controllers
{
       [AuthUser]
    public class MyRequestController : Controller
    {
        [HttpGet("myRequests")]
        public IActionResult MyRequest()
        {
            return View();
        }
    }
}
