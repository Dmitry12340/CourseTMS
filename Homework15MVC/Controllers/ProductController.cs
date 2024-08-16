using Microsoft.AspNetCore.Mvc;

namespace Homework15MVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
