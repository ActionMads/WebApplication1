using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            using(var _context = ApplicationDbContext.Create())
            {
                var customer = new Customer();
                customer.Company = "It-minds";
                _context.Customers.Add(customer);

                var employee = new Employee();
                _context.Employees.Add(employee);

                _context.SaveChanges();
            }
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}