using ASPCoreFirstApp.Models;
using ASPCoreFirstApp.Services;
using Bogus;
using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace ASPCoreFirstApp.Controllers
{
    public class ProductsController : Controller
    {

        ProductsDAO repository = new ProductsDAO();

        public ProductsController()
        {
            repository = new ProductsDAO();
        }

        public IActionResult Index()
        {
            //HardCodedSampleDataRepository repository = new HardCodedSampleDataRepository();
            return View(repository.AllProducts());
        }

        // respond to search results
        public IActionResult SearchResults(string searchTerm)
        {
            List<ProductModel> productList = repository.SearchProducts(searchTerm);
            return View("Index", productList);
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
