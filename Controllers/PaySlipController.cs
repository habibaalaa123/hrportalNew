using Microsoft.AspNetCore.Mvc;

namespace hrportalNew.Controllers
{
    public class PaySlipController : Controller
    {
        public IActionResult PaySlip()
        {
            return View();
        }
    }
}
