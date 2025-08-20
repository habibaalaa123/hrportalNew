using Microsoft.AspNetCore.Mvc;
using hrportalNew.Middleware.User;

namespace hrportalNew.Controllers
{
       [AuthUser]
    public class HrDocsController : Controller
    {
         [HttpGet("HRDoc")]
        public IActionResult HrDocs()
        {
            return View();
        }
    }
}
