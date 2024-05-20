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
            var customerList =  CustomerContext.Customers;
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

            CustomerModel lastCustomer = null;

            if (CustomerContext.Customers.Count >0)
            {
                lastCustomer = CustomerContext.Customers.Last();
            }
            int id =1;

            if (lastCustomer != null)
            {
                id = lastCustomer.Id + 1;
            }



            CustomerContext.Customers.Add(new CustomerModel {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Age = age
            
            });



            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Remove(int id)
        {
            var removeCustomer = CustomerContext.Customers.Find(c => c.Id == id);
            if (removeCustomer != null)
            {
                CustomerContext.Customers.Remove(removeCustomer);
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var willUpdateCustomer = CustomerContext.Customers.FirstOrDefault(a => a.Id == id);

            return View(willUpdateCustomer);
        }
        [HttpPost]
        public IActionResult UpdateCustomer()
        {
            var id = int.Parse(HttpContext.Request.Form["id"].ToString());
            var willUpdateCustomer = CustomerContext.Customers.FirstOrDefault(I => I.Id == id);
            willUpdateCustomer.FirstName = HttpContext.Request.Form["firstName"].ToString();
            willUpdateCustomer.LastName = HttpContext.Request.Form["lastName"].ToString();
            willUpdateCustomer.Age = int.Parse(HttpContext.Request.Form["age"].ToString());



            return RedirectToAction("Index");
        }
       
        



    }
}
