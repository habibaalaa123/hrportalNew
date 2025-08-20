using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using hrportalNew.Models;
using Newtonsoft.Json;
using hrportalNew.Middleware;
using System;
using System.Text;
using System.Security.Cryptography;

namespace hrportalNew.Controllers;


[NoLoginAccess]

public class LoginController : Controller
{


    PortalContext context = new PortalContext();

    [HttpGet("login")]

    public IActionResult Login(string userName)
    {

        return View();

    }
    public IActionResult AttemptLogin(string userName, string password)
    {
        Console.WriteLine(password);
        password = HashPassword(password);
        Console.WriteLine(password);

        AspnetUser user = context.AspnetUsers.FirstOrDefault(u => u.UserName == userName);
        if (user != null)
        {
            if (context.AspnetMemberships.FirstOrDefault(p => p.UserId == user.UserId).newPassword == password)
            {
                if (userName == "admin")
                {
                    var userData = new
                    {
                    };
                    HttpContext.Session.SetString("admin", JsonConvert.SerializeObject(userData));
                    return Redirect("~/adminHome");
                    
                }
                else
                {
                    UserHome userInfo = new UserHome();
                    var emp = context.Employees.FirstOrDefault(p => p.EmpId == userName);



                    userInfo.name = emp != null ? emp.EmpName : "a";
                    userInfo.username = user.UserName;

                    if (emp != null && emp.EmpId != null)
                    {
                        int temp = StringToInt(emp.EmpId) ?? 0;
                        var userProfile = context.TblUserProfiles.FirstOrDefault(n => n.EmpId == temp);

                        if (userProfile != null && userProfile.ImgPath != null)
                        {
                            userInfo.profilePic = context.TblUserProfiles.FirstOrDefault(n => n.EmpId == temp).ImgPath;
                        }
                        else
                        {
                            userInfo.profilePic = "";
                        }
                    }

                    userInfo.userId = emp.EmpId;


                    var userData = new
                    {
                        userInfo.userId,
                        userInfo.name,
                        userInfo.username,
                        userInfo.profilePic,
                    };

                    HttpContext.Session.SetString("user", JsonConvert.SerializeObject(userData));

                    Console.WriteLine("Login Success");
                    return Redirect("~/userHome");
                }
            }
            else
                {
                    TempData["ErrorMessage"] = "Wrong Password";
                    return RedirectToAction("Login");
                }
            }
        else
        {
            TempData["ErrorMessage"] = "User not found!";
            return RedirectToAction("Login");
        }
        

    }
    public int? StringToInt(string value)
    {
        if (int.TryParse(value, out int result))
            return result;   // valid int
        return 0;          // invalid string
    }
    public static string HashPassword(string password)
 {
     using var sha256 = SHA256.Create();
     byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
     return Convert.ToBase64String(bytes);
 }
}
