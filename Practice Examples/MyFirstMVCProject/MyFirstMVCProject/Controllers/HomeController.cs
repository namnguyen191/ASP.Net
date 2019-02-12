using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyFirstMVCProject.Models;

namespace MyFirstMVCProject.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            /*ViewBag.DateMessage = DateTime.Now.ToString();
            ViewData["CurrentDate"] = DateTime.Now.ToString();
            */

            ViewBag.Countries = new List<string>()
            {
                "Canada",
                "USA",
                "UK",
                "India",
                "China"
            };

            return View();
        }

        public ActionResult Message()
        {
            return View();
        }

        public ActionResult CustomerInfo()
        {
            Customers cust = new Customers();
            cust.Id = 1234;
            cust.Name = "John Doe";
            cust.Amount = 245.99;
            Customers cust2 = new Customers();
            cust2.Id = 345;
            cust2.Name = "Jame Smith";
            cust2.Amount = 999;
            return View(cust);
        }

    }
}