using FinalProjectAquarius.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProjectAquarius.Controllers
{
    public class AccountController : Controller
    {
        ContextClass db = new ContextClass();
        // GET: Account
        public ActionResult Index()
        {
            ViewBag.ErrorMessage = "";
            return View();
        }

        [HttpPost]
        public ActionResult Index(Customer customer)
        {
            var v = db.customers.Where(a => a.email.Equals(customer.email) && a.passwrd.Equals(customer.passwrd)).FirstOrDefault();
            if (v != null)
            {
                return RedirectToAction("Login",new { id = v.id });
            }
            else
            {
                ViewBag.ErrorMessage = "Invalid User Name or Password!";
                return View();
            }
        }

        public ActionResult CreateAccount()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateAccount(Customer customer)
        {
            db.customers.Add(customer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Login(int? id)
        {
            Customer customer = db.customers.Find(id);
            return View(customer);
        }

        [HttpPost]
        public ActionResult Login(Customer customer)
        {
            db.Entry(customer).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return View(customer.id);
        }

    }
}