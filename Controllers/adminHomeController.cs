
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using hrportalNew.Models;
using hrportalNew.Middleware.Admin;

namespace hrportalNew.Controllers;

[AuthAdmin]
public class adminHomeController : Controller
{


    PortalContext context = new PortalContext();

    public IActionResult Index()
    {
        
        return View();
    }



}
