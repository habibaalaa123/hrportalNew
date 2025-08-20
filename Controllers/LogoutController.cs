using Microsoft.AspNetCore.Mvc;

namespace hrportalNew.Controllers
{
    public class LogoutController : Controller
    {
       [HttpGet("Logout")]
        public async Task<IActionResult> Logout()
        {
            HttpContext.Session.Clear();
            return Redirect("/login");
        }
    }
}
