using Microsoft.AspNetCore.Mvc;
using hrportalNew.Middleware.User;
namespace hrportalNew.Controllers
{

    [AuthUser]
    public class PaySlipController : Controller
    {
        [HttpGet("paySlip")]
        public IActionResult PaySlip()
        {
            return View();
        }
    }
}
