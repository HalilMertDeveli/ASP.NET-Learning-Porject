
using dependecyInversion.Models;
using dependecyInversion.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace dependecyInversion.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        private readonly IProductService _productService;


        private readonly ITransientService _transitService;
        private readonly  IScopedService _scoppedService;
        private readonly ISingletonService _singletonService;


        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        public HomeController(IProductService productService, ITransientService transitService, IScopedService scoppedService, ISingletonService singletonService)
        {
            _productService = productService;

            _transitService = transitService;
            _scoppedService = scoppedService;
            _singletonService = singletonService;
        }
        public IActionResult Index()
        {
            ViewBag.Singleton = _singletonService.GuidId;
            ViewBag.Transient = _transitService.GuidId;
            ViewBag.Scoped = _scoppedService.GuidId;



            int returnTotal = _productService.GetTotal();
            return View(returnTotal);
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
    public interface IProductService
    {
        int GetTotal();
    }
    public class ProductManager : IProductService
    {
        public int GetTotal()
        {
            return 40;
        }
    }
}
