using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using hrportalNew.Models;

namespace hrportalNew.Controllers;

public class LoginController : Controller
{


    PortalContext context = new PortalContext();

    public IActionResult Login(string userName)
    {
        /*try
        {
            AspnetUser user = context.AspnetUsers.FirstOrDefault(u => u.UserName == userName);
            
            if (user != null)
            {
                // map database user to model
                loginModel login = new loginModel();
                login.user = user;

                return View(login); // pass model to view
            }
            else
            {
                Console.WriteLine("User not found");
                return View();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            Console.WriteLine("Error");
            return View();
        }
        
        }*/
        return View();

    }
    public IActionResult AttemptLogin(string userName,string password)
    {
        AspnetUser user = context.AspnetUsers.FirstOrDefault(u => u.UserName == userName);
        if(user != null)
        {
            if (context.AspnetMemberships.FirstOrDefault(p => p.UserId == user.UserId).Password == password)
            {
                UserHome userInfo = new UserHome();
                var emp = context.Employees.FirstOrDefault(p => p.EmpId == userName);
                userInfo.name = emp != null ? emp.EmpName : "a";
                userInfo.username = user.UserName;

                HttpContext.Session.SetString("Name", userInfo.name);
                HttpContext.Session.SetString("UserName", user.UserName);
                HttpContext.Session.SetString("UserId", user.UserId.ToString());

                Console.WriteLine("Login Success");
                return View("Success", userInfo);
            }
            else
            {
                Console.WriteLine("Wrong Password");
                return View("Wrong");
            }
        }
        else
        {
            Console.WriteLine("Username not exist");
            return View("non");
        }

    }
}
