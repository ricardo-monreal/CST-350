using ASPCoreFirstApp.Models;
using Bogus;

namespace ASPCoreFirstApp.Services
{
    public class HardCodedSampleDataRepository : IProductDataService
    {

        static List<ProductModel> productList;

        public HardCodedSampleDataRepository()
        {
            productList = new List<ProductModel>();

            productList.Add(new ProductModel(1, "Mouse Pad", 4.99m, "Amazon Basic's mouse pad"));
            productList.Add(new ProductModel(2, "Wireless Mouse", 11.99m, "Basic Wireless mouse with dongle"));
            productList.Add(new ProductModel(3, "16gb USB Drive", 7.99m, "USB Drive with 16gb of storage"));
            productList.Add(new ProductModel(4, "Nintendo Switch", 299.99m, "Nintendo Switch Console"));

            for (int i = 0; i < 100; i++)
            {
                productList.Add(new Faker<ProductModel>()
                    .RuleFor(p => p.Id, i + 5)
                    .RuleFor(p => p.Name, f => f.Commerce.ProductName())
                    .RuleFor(p => p.Price, f => f.Random.Decimal(100))
                    .RuleFor(p => p.Description, f => f.Rant.Review())

                    );
            }
        }



        public List<ProductModel> AllProducts()
        {
            return productList;
        }

        public bool Delete(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public ProductModel GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> SearchProducts(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public int Update(ProductModel product)
        {
            throw new NotImplementedException();
        }
    }
}
