using hrportalNew.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

public class FeaturesViewComponent : ViewComponent
{


    public async Task<IViewComponentResult> InvokeAsync()
    {
            return View();

    }
}
