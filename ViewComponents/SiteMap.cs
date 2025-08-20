using hrportalNew.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

public class SiteMapViewComponent : ViewComponent
{


    public async Task<IViewComponentResult> InvokeAsync()
    {
            return View();

    }
}
