using AspNetEntity.Data.Contexts;
using AspNetEntity.Data.Entities;
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

            context.Employees.Add(new PartTimeEmployee
            {
                DailtWage = 400,
                FirstName = "part",
                LastName = "part",

            });

            context.Employees.Add(new PartTimeEmployee
            {

                DailtWage = 400,
                FirstName = "part 2",
                LastName = "part 2",

            });

            context.Employees.Add(new FullTimeEmployee {
                FirstName = "full", 
                LastName = " full",
                HourlyWage = 60,
            });

            context.SaveChangesAsync();

            var parts = context.PartTimeEmployees.ToList();

            var parts2 = context.Employees.Where(x => x is PartTimeEmployee).ToList();



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
