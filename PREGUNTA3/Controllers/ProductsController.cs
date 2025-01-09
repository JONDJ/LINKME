using Microsoft.AspNetCore.Mvc;
using ProductApi.Models;
using System.Collections.Generic;

namespace ProductApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // Simulamos una lista de productos
        private static List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Producto A", Stock = 100 },
            new Product { Id = 2, Name = "Producto B", Stock = 200 },
            new Product { Id = 3, Name = "Producto C", Stock = 300 }
        };

        //09/01/2025 7:49
        //Jonathan Ortega
        //INPUT: 
        //OUTPUT: lista de productos
        // GET: api/products
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            return Ok(products);
        }
    }
}
