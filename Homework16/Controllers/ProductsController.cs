using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Homework16.Models;

namespace Homework16.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private List<Product> products = new List<Product>()
        {
            new Product {Id = 1, Name = "Product 1", Quantity = 200},
            new Product {Id = 2, Name = "Product 6", Quantity = 300},
            new Product {Id = 3, Name = "Product 5", Quantity = 400},
            new Product {Id = 4, Name = "Product 4", Quantity = 500},
        };

        [HttpPost]
        [Route("modifyProduct")]
        public IActionResult ModifyProduct(Product product)
        {
            var existProduct = products.FirstOrDefault(product => product.Id == product.Id);

            if (existProduct != null)
            {
                existProduct.Name = product.Name;
                existProduct.Quantity = product.Quantity;
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("getProducts")]
        public IActionResult GetProducts()
        {
            return Ok(products);
        }

        [HttpPost]
        [Route("deleteProduct")]
        public IActionResult DeleteProduct(int id)
        {
            var existProduct = products.FirstOrDefault(products => products.Id == id);
            if (existProduct != null)
            {
                products.Remove(existProduct);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("addProduct")]
        public IActionResult AddProduct(Product product)
        {
            bool existId = false;
            //Проверяем наличие переданного Id
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Id == product.Id)
                {
                    existId = true;
                    break;
                }
            }

            if (existId)
            {
                return BadRequest();
            }
            else
            {
                products.Add(product);
                return Ok();
            }
        }
    }
}
