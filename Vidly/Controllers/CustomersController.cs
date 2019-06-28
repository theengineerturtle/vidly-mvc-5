using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
       
        // GET: Customers
        public ActionResult Index()
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer{Id=1,Name="Gökhan"},
                new Customer{Id=2,Name="Musa"},
                new Customer{Id=3, Name="Fatih"},
            };
            return View(customers);
        }

        public ActionResult Details(int? id)
        {
            if (id == null || id<=0)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            List<Customer> customers = new List<Customer>()
            {
                new Customer{Id=1,Name="Gökhan"},
                new Customer{Id=2,Name="Musa"},
                new Customer{Id=3, Name="Fatih"},
            };

            Customer customer = new Customer();
            customer = customers.FirstOrDefault(x => x.Id == id);
            if (customer == null)
                return HttpNotFound();
            return View(customer);

        }
    }
}