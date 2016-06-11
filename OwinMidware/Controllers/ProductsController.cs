using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OwinMidware.Models;

namespace OwinMidware.Controllers
{
    public class ProductsController : ApiController
    {
        ProductsOdata[] products = new ProductsOdata[]
        {
            new ProductsOdata { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new ProductsOdata { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new ProductsOdata { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
        };

        public IEnumerable<ProductsOdata> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
