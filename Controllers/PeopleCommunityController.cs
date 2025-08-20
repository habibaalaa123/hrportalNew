using Microsoft.AspNetCore.Mvc;

namespace hrportalNew.Controllers
{
    public class PeopleCommunityController : Controller
    {
        [HttpGet("peopleCommunity")]
        public IActionResult PeopleCommunity()
        {
            return View();
        }
    }
}
