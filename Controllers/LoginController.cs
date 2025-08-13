using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using hrportalNew.Models;

namespace hrportalNew.Controllers;

public class LoginController : Controller
{


    PortalContext context = new PortalContext();

    public IActionResult Login()
    {
        return View();
    }



}
