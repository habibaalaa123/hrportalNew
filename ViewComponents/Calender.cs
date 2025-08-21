using hrportalNew.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

public class CalenderViewComponent : ViewComponent
{


    public async Task<IViewComponentResult> InvokeAsync()
    {
       
        return View();

    }
}
