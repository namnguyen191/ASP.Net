using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyFirstMVCProject.Models;

namespace MyFirstMVCProject.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detail()
        {
            Employees emp = new Employees();
            emp.Id = 1;
            emp.Name = "Nam Nguyen";
            emp.Address = "198 Andy Crescent, Vaughan, ON, Canada";
            return View(emp);
        }
    }
}