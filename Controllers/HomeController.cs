using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using hrportalNew.Models;

namespace hrportalNew.Controllers;

public class HomeController : Controller
{




    public IActionResult Index()
    {
        return View();
    }



}
