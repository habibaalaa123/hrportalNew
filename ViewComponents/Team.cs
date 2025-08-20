using hrportalNew.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

public class TeamViewComponent : ViewComponent
{


    public async Task<IViewComponentResult> InvokeAsync()
    {
            return View();

    }
}
