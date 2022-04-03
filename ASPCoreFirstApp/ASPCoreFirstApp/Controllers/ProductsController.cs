using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace ASPCoreFirstApp.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Message()
        {
            return View();
        }

        public IActionResult Welcome()
        {
            ViewBag.name = "Ricardo";
            ViewBag.secretNumber = 13;
            return View();
        }
    }
}
