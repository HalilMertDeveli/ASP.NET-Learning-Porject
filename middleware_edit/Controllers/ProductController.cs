using Microsoft.AspNetCore.Mvc;

namespace middleware_edit.Controllers
{
    public class ProductController:Controller
    {
        public IActionResult Index()
        {
            return View();//if there is no name in here you have to name as index
        }
        public IActionResult Product()
        {
            return View("Product");//if there is no name in here you have to name as index
        }
    }
}
