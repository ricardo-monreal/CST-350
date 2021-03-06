using ASPCoreFirstApp.Models;
using ASPCoreFirstApp.Services;
using Bogus;
using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace ASPCoreFirstApp.Controllers
{
    public class ProductsController : Controller
    {
        //HardCodedSampleDataRepository repository = new HardCodedSampleDataRepository();
        //ProductsDAO repository = new ProductsDAO();

        // use dependency injection, see Program.cs to see the data source for the repository.
        public IProductDataService repository { get; set; }



        public ProductsController(IProductDataService dataService)
        {
            //repository = new ProductsDAO();
            repository = dataService;
            //repository = new HardCodedSampleDataRepository();
        }

        public IActionResult Index()
        {
            
            return View(repository.AllProducts());
        }

        // respond to search results
        public IActionResult SearchResults(string searchTerm)
        {
            List<ProductModel> productList = repository.SearchProducts(searchTerm);
            return View("Index", productList);
        }

        public IActionResult SearchForm()
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

        public IActionResult ShowOneProduct(int Id)
        {
            return View(repository.GetProductById(Id));
        }

        public IActionResult ShowOneProductJSON(int Id)
        {
            return Json(repository.GetProductById(Id));
        }

        public IActionResult ShowEditForm(int Id)
        {
            return View(repository.GetProductById(Id));
        }

        public IActionResult ProcessEdit(ProductModel product)
        {
            repository.Update(product);
            return View("Index", repository.AllProducts());
        }

        public IActionResult ProcessEditReturnOneItem(ProductModel product)
        {
            repository.Update(product);
            return PartialView("_productCard", product);
        }


        // coding challenge
        public IActionResult Delete(int Id)
        {
            ProductsDAO productsDAO = new ProductsDAO();
            productsDAO.Delete(Id);

            List<ProductModel> products = productsDAO.AllProducts();
            
            return View("Index", products);
        }
    }
}
