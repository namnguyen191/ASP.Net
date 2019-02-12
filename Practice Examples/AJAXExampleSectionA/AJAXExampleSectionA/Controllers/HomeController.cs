using AJAXExampleSectionA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AJAXExampleSectionA.Controllers
{
    public class HomeController : Controller
    {
        ContextClass db = new ContextClass();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        
        public PartialViewResult All()
        {
            List<Student> model = db.Students.ToList();
            return PartialView("_Students",model);
        }

        public PartialViewResult TopThree()
        {
            List<Student> model = db.Students.OrderByDescending(x => x.TotalMarks).Take(3).ToList();
            return PartialView("_Students",model);
        }

        public PartialViewResult BottomThree()
        {
            List<Student> model = db.Students.OrderByDescending(x => x.TotalMarks).Take(3).ToList();
            return PartialView("_Students", model);
        }
    }
}