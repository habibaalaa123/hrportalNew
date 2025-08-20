using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace hrportalNew.Middleware.Admin;

public class AuthAdminAttribute : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        var admin = context.HttpContext.Session.GetString("admin");
        
        if (string.IsNullOrEmpty(admin))
        {
            context.Result = new RedirectResult("/");
        }
    }
}