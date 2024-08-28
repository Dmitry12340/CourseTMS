using Microsoft.AspNetCore.Mvc;
using Homework17.Models;

namespace Homework17.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        public List<Product> products = new List<Product>()
        {
            new Product {Id = 1, Name = "Product 1", Quantity = 200},
            new Product {Id = 2, Name = "Product 6", Quantity = 300},
            new Product {Id = 3, Name = "Product 5", Quantity = 400},
            new Product {Id = 4, Name = "Product 4", Quantity = 500},
        };

        [HttpPost]
        [Route("ModifyProduct")]
        public IActionResult ModifyProduct(Product product)
        {
            var existProduct = products.FirstOrDefault(product => product.Id == product.Id);

            if (existProduct != null)
            {
                existProduct.Name = product.Name;
                existProduct.Quantity = product.Quantity;
                return View("MenuModifyProduct");
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("GetProducts")]
        public IActionResult GetProducts()
        {
            return View("GetProduct", products);
        }

        [HttpPost]
        [Route("DeleteProduct")]
        public IActionResult DeleteProduct(int id)
        {
            bool existId = false;
            int count = 0;
            //Проверяем наличие переданного Id
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Id == id)
                {
                    existId = true;
                    count = i;
                    break;
                }
            }

            if (existId)
            {
                products.RemoveAt(count);
                return View("MenuDeleteProduct");
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("AddProduct")]
        public IActionResult AddProduct(Product product)
        {
            bool existId = false;
            //Проверяем наличие переданного элемента по Id
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
                return View("MenuAddProduct");
            }
        }

        [HttpGet]
        [Route("MenuProduct")]
        public IActionResult MenuProduct()
        {
            return View("MenuProduct");
        }

        [HttpGet]
        [Route("MenuAddProduct")]
        public IActionResult MenuAddProduct()
        {
            return View("MenuAddProduct");
        }

        [HttpGet]
        [Route("MenuModifyProduct")]
        public IActionResult MenuModifyProduct()
        {
            return View("MenuModifyProduct");
        }

        [HttpGet]
        [Route("MenuDeleteProduct")]
        public IActionResult MenuDeleteProduct()
        {
            return View("MenuDeleteProduct");
        }
    }
}
