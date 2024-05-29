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
            return View(new Customer());
        }
        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            //string firstName = HttpContext.Request.Form["firstName"].ToString();
            //string lastName = HttpContext.Request.Form["lastName"].ToString();
            //int age = int.Parse(HttpContext.Request.Form["age"].ToString());

            var controlState = ModelState.IsValid;
            var errors = ModelState.Values.SelectMany(error => error.Errors.Select(stringT =>stringT.ErrorMessage));

            if (customer.FirstName == "HMD")
            {
                ModelState.AddModelError("","First Name coudn't be HMD");
            }


            if (controlState == true)
            {
                Customer lastCustomer = null;

                if (CustomerContext.Customers.Count > 0)
                {
                    lastCustomer = CustomerContext.Customers.Last();
                }
                customer.Id = 1;

                if (lastCustomer != null)
                {
                    customer.Id = lastCustomer.Id + 1;
                }

                CustomerContext.Customers.Add(customer);

                return RedirectToAction("Index");

            }




            return View("Create");
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
        public IActionResult Update(Customer customer)
        {
            //var id = int.Parse(HttpContext.Request.Form["id"].ToString());
            var willUpdateCustomer = CustomerContext.Customers.FirstOrDefault(I => I.Id == customer.Id);
            //willUpdateCustomer.FirstName = HttpContext.Request.Form["firstName"].ToString();
            //willUpdateCustomer.LastName = HttpContext.Request.Form["lastName"].ToString();
            //willUpdateCustomer.Age = int.Parse(HttpContext.Request.Form["age"].ToString());

            willUpdateCustomer.FirstName = customer.FirstName;
            willUpdateCustomer.LastName = customer.LastName;
            willUpdateCustomer.Age = customer.Age;


            return RedirectToAction("Index");
        }
       
        



    }
}
