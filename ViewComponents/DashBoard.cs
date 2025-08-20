using hrportalNew.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

public class DashBoardViewComponent : ViewComponent
{


    public async Task<IViewComponentResult> InvokeAsync()
    {
            return View();

    }
}
