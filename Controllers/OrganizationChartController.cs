using Microsoft.AspNetCore.Mvc;

namespace hrportalNew.Controllers
{
    public class OrganizationChartController : Controller
    {
        [HttpGet("organizationChart")]
        public IActionResult OrganizationChart()
        {
            return View();
        }
    }
}
