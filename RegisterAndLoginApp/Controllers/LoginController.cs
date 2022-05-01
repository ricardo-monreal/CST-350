using Microsoft.AspNetCore.Mvc;
using RegisterAndLoginApp.Models;
using RegisterAndLoginApp.Services;
using NLog;
using RegisterAndLoginApp.Services.Utility;

namespace RegisterAndLoginApp.Controllers
{
    public class LoginController : Controller
    {

        


        public IActionResult Index()
        {
            return View();
        }

        // Activity 6: Part 3
        [HttpGet]
        [CustomAuthorization]
        public IActionResult PrivateSectionMustBeLoggedIn()
        {
            return Content("I am a protected method if the proper attribute is applied to me");
        }

        [LogActionFilter]
        public IActionResult ProcessLogin(UserModel user)
        {
            // record the user who attempted to login
            //MyLogger.GetInstance().Info("Entering the ProcessLogin method.");
            //MyLogger.GetInstance().Info("Parameter: " + user.ToString());

            SecurityService securityService = new SecurityService();

            if (securityService.isValid(user))
            {
                // remember who is logged in
                HttpContext.Session.SetString("username", user.UserName);
                // record success or failure
                //MyLogger.GetInstance().Info("Login success.");
                return View("LoginSuccess", user);
                
                

            }
            else
            {
                //MyLogger.GetInstance().Info("Login failure");
                // cancel any existing valid loign
                HttpContext.Session.Remove("username");
                return View("LoginFailed", user);
            }
        }
    }
}
