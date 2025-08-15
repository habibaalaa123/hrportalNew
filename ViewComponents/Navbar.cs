using hrportalNew.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

public class NavbarViewComponent : ViewComponent
{

    PortalContext context = new PortalContext();
    public async Task<IViewComponentResult> InvokeAsync()
    {


        var dumbUser = HttpContext.Session.GetString("UserName");

        if (string.IsNullOrEmpty(dumbUser))
        {
            // session is closed (no active user)
            return View("NavbarLogout");
        }
        else
        {
            // session is open (user is logged in)
            ViewBag.User = dumbUser;
            return View("NavbarLogin");
        }

    }
}
