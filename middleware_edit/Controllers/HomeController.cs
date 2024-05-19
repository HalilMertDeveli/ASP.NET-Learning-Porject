using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using middleware_edit.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;



namespace middleware_edit.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var customerList =  CustomerContext.customerModelList;
            return View(customerList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateWithForm()
        {
            string firstName = HttpContext.Request.Form["firstName"].ToString();
            string lastName = HttpContext.Request.Form["lastName"].ToString();
            int age = int.Parse(HttpContext.Request.Form["age"].ToString());

            var lastCustomer = CustomerContext.customerModelList.Last();


            var id = lastCustomer.Id + 1;

            CustomerContext.customerModelList.Add(new CustomerModel {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Age = age
            
            });



            return RedirectToAction("Index");
        }
      
       
    }
}
