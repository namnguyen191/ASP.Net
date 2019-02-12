using HTMLHelpers2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTMLHelpers2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            //string value = form["comments"].ToString();
            //string value = Convert.ToString(comments);
            string gender = form["Gender"].ToString();
            TempData["gender"] = gender;
            return RedirectToAction("Index");
        }

        public ActionResult ShowDepartments()
        {
            Context db = new Context();
            ViewBag.Departments = new SelectList(db.Departments, "Id", "name");
            return View();
        }
    }
}