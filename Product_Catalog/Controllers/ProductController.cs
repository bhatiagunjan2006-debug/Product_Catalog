using Product_Catalog.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Product_Catalog.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            return View(GetProducts());
        }

        public ActionResult Details(int id)
        {
            Product product = GetProducts()
                .FirstOrDefault(p => p.ProductId == id);

            return View(product);
        }

        private List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    ProductId = 1,
                    ProductName = "Samsung S23 Ultra",
                    Description = "Galaxy S23 Ultra 256GB, 12GB RAM",
                    Price = 87000,
                    Category = "Electronics"
                },

                new Product
                {
                    ProductId = 2,
                    ProductName = "MacBook",
                    Description = "Apple MacBook Pro 16-inch, M2 Pro chip",
                    Price = 127000,
                    Category = "Electronics"
                },

                new Product
                {
                    ProductId = 3,
                    ProductName = "Tablet",
                    Description = "Lenovo Tab",
                    Price = 5000,
                    Category = "Electronics"
                },

                new Product
                {
                    ProductId = 4,
                    ProductName = "Mobile Cover",
                    Description = "Mobile cover for iphone 17 pro max",
                    Price = 1700,
                    Category = "Mobile Accessories"
                },

                new Product
                {
                    ProductId = 5,
                    ProductName = "Laptop Bag",
                    Description = "Laptop bag for 15.6 inch",
                    Price = 548,
                    Category = "Laptop Accessories"
                },

                new Product
                {
                    ProductId = 6,
                    ProductName = "Earphone",
                    Description = "MIVI wireless earphone",
                    Price = 799,
                    Category = "Earphones"
                },

                new Product
                {
                    ProductId = 7,
                    ProductName = "boAt Karaoke",
                    Description = "boAt PartyPal Karaoke, 90w output",
                    Price = 6999,
                    Category = "Home Audio"
                },

                new Product
                {
                    ProductId = 8,
                    ProductName = "PS5",
                    Description = "Sony PS5 Console Digital",
                    Price = 64990,
                    Category = "Gaming"
                }
            };
        }
    }
}