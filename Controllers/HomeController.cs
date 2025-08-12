using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using hrportalNew.Models;

namespace hrportalNew.Controllers;

public class HomeController : Controller
{


    PortalContext context = new PortalContext();

    public IActionResult Index()
    {
        homeModel home = new homeModel();
      // var todLst ;
      var  todLst= context.TblTods.OrderByDescending(t => t.Date).FirstOrDefault(t => t.First == 1);
        string img_path = todLst.ImgPath.ToString();
        home.tod = img_path;
        //news/////
        try
        {
            var eventList = context.TblEvents
                     .OrderByDescending(n => n.Date)
                     .Take(3)
                     .ToList();
            if (eventList.Count > 0)
            {




                home.eventList = eventList;

            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            // return null;
        }


        return View(home);
    }



}
