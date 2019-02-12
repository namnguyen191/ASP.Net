using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CIHHospital.Models;

namespace CIHHospital.Controllers
{
    public class Emergency_ContactController : Controller
    {
        private ContextClass1 db = new ContextClass1();

        // GET: Emergency_Contact
        public ActionResult Index()
        {
            var emergency_Contacts = db.Emergency_Contacts.Include(e => e.Patient);
            return View(emergency_Contacts.ToList());
        }

        // GET: Emergency_Contact/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Emergency_Contact emergency_Contact = db.Emergency_Contacts.Find(id);
            if (emergency_Contact == null)
            {
                return HttpNotFound();
            }
            return View(emergency_Contact);
        }

        // GET: Emergency_Contact/Create
        public ActionResult Create()
        {
            ViewBag.Patient_Id = new SelectList(db.Patients, "Id", "First_Name");
            return View();
        }

        // POST: Emergency_Contact/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Patient_Id,First_Name,Last_Name,Relationship,Phone_No")] Emergency_Contact emergency_Contact)
        {
            if (ModelState.IsValid)
            {
                db.Emergency_Contacts.Add(emergency_Contact);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Patient_Id = new SelectList(db.Patients, "Id", "First_Name", emergency_Contact.Patient_Id);
            return View(emergency_Contact);
        }

        // GET: Emergency_Contact/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Emergency_Contact emergency_Contact = db.Emergency_Contacts.Find(id);
            if (emergency_Contact == null)
            {
                return HttpNotFound();
            }
            ViewBag.Patient_Id = new SelectList(db.Patients, "Id", "First_Name", emergency_Contact.Patient_Id);
            return View(emergency_Contact);
        }

        // POST: Emergency_Contact/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Patient_Id,First_Name,Last_Name,Relationship,Phone_No")] Emergency_Contact emergency_Contact)
        {
            if (ModelState.IsValid)
            {
                db.Entry(emergency_Contact).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Patient_Id = new SelectList(db.Patients, "Id", "First_Name", emergency_Contact.Patient_Id);
            return View(emergency_Contact);
        }

        // GET: Emergency_Contact/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Emergency_Contact emergency_Contact = db.Emergency_Contacts.Find(id);
            if (emergency_Contact == null)
            {
                return HttpNotFound();
            }
            return View(emergency_Contact);
        }

        // POST: Emergency_Contact/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Emergency_Contact emergency_Contact = db.Emergency_Contacts.Find(id);
            db.Emergency_Contacts.Remove(emergency_Contact);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
