using Microsoft.AspNetCore.Mvc;

namespace hrportalNew.Controllers
{
    public class PeopleCommunityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
