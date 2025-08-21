using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace hrportalNew.Middleware;

    public class NoLoginAccessAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var user = context.HttpContext.Session.GetString("user");
            var admin = context.HttpContext.Session.GetString("admin");
        if (!string.IsNullOrEmpty(user))
        {
            context.Result = new RedirectResult("home");
        }
        else if (!string.IsNullOrEmpty(admin)) {
                context.Result = new RedirectResult("adminHome");
        }
            base.OnActionExecuting(context);
        }
    }