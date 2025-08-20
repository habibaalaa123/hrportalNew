using Microsoft.AspNetCore.Mvc;

namespace hrportalNew.Controllers
{
    public class MyProfileController : Controller
    {
        public IActionResult MyProfile()
        {
            return View();
        }
    }
}
