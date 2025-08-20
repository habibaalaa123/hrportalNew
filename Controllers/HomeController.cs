using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using hrportalNew.Models;
using hrportalNew.Middleware.User;
using hrportalNew.Middleware;

namespace hrportalNew.Controllers;

[NoLoginAccess]

public class HomeController : Controller
{


    PortalContext context = new PortalContext();

    public IActionResult Index()
    {
        HomeModel home = new HomeModel();
     
        var todLst = context.TblTods.OrderByDescending(t => t.Date).FirstOrDefault(t => t.First == 1);
        string img_path = todLst.ImgPath.ToString();
        home.tod = img_path;

        try
        {
            var eventList = context.TblEvents
                     .OrderByDescending(n => n.Date)
                     .Take(4)
                     .ToList();
            if (eventList.Count > 0)
            {




                home.eventList = eventList;

            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
         
        }

        try
        {
            var teamList = context.TblTopmngs
                     .OrderBy(n => n.Order)
                     .Take(8)
                     .ToList();
            if (teamList.Count > 0)
            {
                home.teamList = teamList;

            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());

        }
        return View(home);
    }



}
