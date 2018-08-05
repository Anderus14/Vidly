using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        public ActionResult Customers()
        {
            var customer = new List<Customer>
            {
                new Customer {Name = "John Smith"},
                new Customer {Name = "Mary Doe" },
                new Customer {Name = "Mateusz Małolepszy"}
            };
            var viewModel = new RandomMovieViewModel
            {
                Customers = customer
            };

            return View(viewModel);
        }

        public ActionResult Details()
        {
            return View();
        }
    }
}