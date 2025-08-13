using hrportalNew.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

public class FooterEventsViewComponent : ViewComponent
{

    PortalContext context = new PortalContext();
    public async Task<IViewComponentResult> InvokeAsync()
    {



        FooterEventModel events = new FooterEventModel();

        try
        {
            var eventList = context.TblEvents
                     .OrderByDescending(n => n.Date)
                     .Take(3)
                     .ToList();
            if (eventList.Count > 0)
            {




                events.eventList = eventList;

            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            // return null;
        }


        return View(events); // 'Default' is the view name
    }
}
