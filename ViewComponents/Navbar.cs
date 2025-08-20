using hrportalNew.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

public class NavbarViewComponent : ViewComponent
{

    PortalContext context = new PortalContext();
    public async Task<IViewComponentResult> InvokeAsync()
    {


        // var dumbUser = HttpContext.Session.GetString("UserName");

        //     ViewBag.User = dumbUser;
            return View("Navbar");

    }
}
