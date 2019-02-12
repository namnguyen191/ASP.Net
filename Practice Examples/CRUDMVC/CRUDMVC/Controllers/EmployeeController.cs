using CRUDMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUDMVC.Controllers
{
    public class EmployeeController : Controller
    {
        ContextClass db = new ContextClass();
        // GET: Employee
        public ActionResult Index()
        {          
            return View(db.Employees.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges(); //Commit changes to the database
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            //Employee employee = db.Employees.Single(emp => emp.Id == id);
            Employee employee = db.Employees.Find(id);
            return View(employee);
        }

        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            db.Entry(employee).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Employee employee = db.Employees.Find(id);
            return View(employee);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee employee = db.Employees.Find(id);
            db.Employees.Remove(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Employee employee = db.Employees.Find(id);
            return View(employee);
        }

    }
}