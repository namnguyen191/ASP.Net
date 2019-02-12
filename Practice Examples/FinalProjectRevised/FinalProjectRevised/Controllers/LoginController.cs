using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalProjectRevised.Models;

namespace FinalProjectRevised.Controllers
{
    public class LoginController : Controller
    {
        ContextClass db = new ContextClass();
        public ActionResult Index()
        {
            ViewBag.ErrorMessage = "";
            return View();
        }

        [HttpPost]
        public ActionResult Index(customer customer)
        {
            var v = db.customers.Where(a => a.email.Equals(customer.email) && a.passwrd.Equals(customer.passwrd)).FirstOrDefault();
            if (v != null)
            {
                ViewBag.ErrorMessage = "Login Successful!";
                return RedirectToAction("Account", "Login", new { id = v.Id });
            }
            else
            {
                ViewBag.ErrorMessage = "Invalid User Name or Password!";
                return View();
            }
        }

        public ActionResult Account(int? id)
        {
            ViewBag.SaveMessage = "";
            customer customer = db.customers.Find(id);
            return View(customer);
        }

        [HttpPost]
        public ActionResult Account(customer customer)
        {
            ViewBag.SaveMessage = "Your Info Is Saved!";
            db.Entry(customer).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return View(customer);
        }

        public ActionResult CreateAccount()
        {
            return View();
        }
    }
}