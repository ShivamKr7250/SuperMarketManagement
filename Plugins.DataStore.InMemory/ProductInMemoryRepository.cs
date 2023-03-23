using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class ProductInMemoryRepository : IProductRepository
    {
        private List<Product> products;

        public ProductInMemoryRepository()
        {
            products = new List<Product>()
            {
                // Init with default value
                new Product { ProductId = 1, CategoryId = 1, Name = "Iced Tea", Quantity = 100, Price = 1.99 },
                new Product { ProductId = 2, CategoryId = 2, Name = "Coffee", Quantity = 400, Price = 1.00 },
                new Product { ProductId = 3, CategoryId = 3, Name = "Indian Tea", Quantity = 500, Price = 5.00 },
                new Product { ProductId = 4, CategoryId = 4, Name = "Samosa", Quantity = 100, Price = 1.99 },
            };
        }
        public IEnumerable<Product> GetProducts()
        {
            return products;
        }
    }
}
