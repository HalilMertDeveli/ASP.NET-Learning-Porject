using AspNetEntity.Data.Contexts;
using AspNetEntity.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspNetEntity.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            UdemyContext context = new UdemyContext();

            //context.Products.Add(new Data.Entities.Product { Name = "Phone", Price = 3400, });
            //context.SaveChanges();

            //var willUpdateProduct = context.Products.Find(1);
            //willUpdateProduct.Name = "HMD ss";
            //context.Products.Update(willUpdateProduct);
            //context.SaveChanges();

            //var willDeleteProduct = context.Products.FirstOrDefault(x => x.Id == 1);

            //context.Products.Remove(willDeleteProduct);
            //context.SaveChanges();


            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
