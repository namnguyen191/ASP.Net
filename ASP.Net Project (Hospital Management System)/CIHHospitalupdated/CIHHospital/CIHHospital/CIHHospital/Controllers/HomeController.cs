using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CIHHospital.Models;

namespace CIHHospital.Controllers
{
    public class HomeController : Controller
    {
        ContextClass1 db = new ContextClass1();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Login()
        {
            ViewBag.ErrorMessage = "";
            return View();
        }

        [HttpPost]
        public ActionResult Login(Patient patient)
        {
            var v = db.Patients.Where(a => a.Email.Equals(patient.Email) && a.Password.Equals(patient.Password)).FirstOrDefault();
            if (v != null)
            {
                return RedirectToAction("PatientAccount", "Home", new { patientId = v.Id });
            }
            else
            {
                ViewBag.ErrorMessage = "Invalid User Name or Password!";
                return View();
            }
        }

        [HttpGet]
        public ActionResult PatientAccount(int? patientId)
        {
            ViewBag.SaveMessage = "";
            Patient patient = db.Patients.Find(patientId);
            return View(patient);
        }

        [HttpPost]
        public ActionResult PatientAccount(Patient patient)
        {
            ViewBag.SaveMessage = "Your Info Is Saved!";
            db.Entry(patient).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return View(patient);
        }

        public ActionResult CreateAccount()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateAccount(Patient patient)
        {
            db.Patients.Add(patient);
            db.SaveChanges();
            return RedirectToAction("Login");
        }

        public ActionResult DoctorLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DoctorLogin(Doctor doctor)
        {
            var v = db.Doctors.Where(a => a.Email.Equals(doctor.Email) && a.Password.Equals(doctor.Password)).FirstOrDefault();
            if (v != null)
            {
                return RedirectToAction("DoctorAccount", "Home", new { doctorId = v.Id });
            }
            else
            {
                ViewBag.ErrorMessage = "Invalid User Name or Password!";
                return View();
            }
        }

        public ActionResult DoctorAccount(int doctorId)
        {
            Doctor doctor = db.Doctors.Find(doctorId);
            return View(doctor);
        }

        [HttpPost]
        public ActionResult DoctorAccount(Doctor doctor)
        {
            ViewBag.SaveMessage = "Your Info Is Saved!";
            db.Entry(doctor).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return View(doctor);
        }

        public ActionResult Appointment()
        {
            List<int> docId = new List<int>();
            foreach (Doctor doc in db.Doctors.ToList())
            {
                docId.Add(doc.Id);
            }
            ViewBag.DocList = docId;
            return View();
        }

        [HttpPost]
        public ActionResult Appointment(Appointment1 apt)
        {
            
            db.Appointment1.Add(apt);
            db.SaveChanges();
            ViewBag.Message = "Appointment made successfully!";
            return View(apt);
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(Contact con)
        {
            db.Contacts.Add(con);
            db.SaveChanges();
            ViewBag.Message = "Thank you for contacting us!";
            return View(con);
        }
    }
}