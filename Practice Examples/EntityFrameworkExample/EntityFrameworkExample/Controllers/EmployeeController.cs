using EntityFrameworkExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFrameworkExample.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            EmployeeContext employeeContext = new EmployeeContext();
            List<Employee> empList = employeeContext.Employees.ToList();
            return View(empList);
        }

        public ActionResult Details(int id)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            Employee employee = employeeContext.Employees.Single(emp=>emp.Id==id);
            return View(employee);
        }

    }
}