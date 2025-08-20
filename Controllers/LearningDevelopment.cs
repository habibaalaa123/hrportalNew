using Microsoft.AspNetCore.Mvc;
namespace hrportalNew.Controllers
{
    public class LearningDevelopmentController : Controller
    {
        [HttpGet("learningDevelopment")]
        public IActionResult LearningDevelopment()
        {

            return View();
        }
    }
}
