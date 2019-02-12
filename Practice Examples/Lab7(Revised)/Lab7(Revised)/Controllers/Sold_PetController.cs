using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Lab7_Revised_.Models;

namespace Lab7_Revised_.Controllers
{
    public class Sold_PetController : Controller
    {
        private ContextClass db = new ContextClass();

        // GET: Sold_Pet
        public ActionResult Index()
        {
            return View(db.Sold_Pets.ToList());
        }

        // GET: Sold_Pet/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sold_Pet sold_Pet = db.Sold_Pets.Find(id);
            if (sold_Pet == null)
            {
                return HttpNotFound();
            }
            return View(sold_Pet);
        }

        // GET: Sold_Pet/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sold_Pet/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Category_Id,Birthdate,Gender,Price")] Sold_Pet sold_Pet)
        {
            if (ModelState.IsValid)
            {
                db.Sold_Pets.Add(sold_Pet);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sold_Pet);
        }

        // GET: Sold_Pet/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sold_Pet sold_Pet = db.Sold_Pets.Find(id);
            if (sold_Pet == null)
            {
                return HttpNotFound();
            }
            return View(sold_Pet);
        }

        // POST: Sold_Pet/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Category_Id,Birthdate,Gender,Price")] Sold_Pet sold_Pet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sold_Pet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sold_Pet);
        }

        // GET: Sold_Pet/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sold_Pet sold_Pet = db.Sold_Pets.Find(id);
            if (sold_Pet == null)
            {
                return HttpNotFound();
            }
            return View(sold_Pet);
        }

        // POST: Sold_Pet/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sold_Pet sold_Pet = db.Sold_Pets.Find(id);
            db.Sold_Pets.Remove(sold_Pet);
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
