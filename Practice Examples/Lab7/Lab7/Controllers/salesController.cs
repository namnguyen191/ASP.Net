using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Lab7.Models;

namespace Lab7.Controllers
{
    public class salesController : Controller
    {
        private ContextClass db = new ContextClass();

        // GET: sales
        public ActionResult Index()
        {
            var sales = db.sales.Include(s => s.customer).Include(s => s.pet);
            return View(sales.ToList());
        }

        // GET: sales/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sale sale = db.sales.Find(id);
            if (sale == null)
            {
                return HttpNotFound();
            }
            return View(sale);
        }

        // GET: sales/Create
        public ActionResult Create()
        {
            ViewBag.customerId = new SelectList(db.customers, "Id", "name");
            ViewBag.petId = new SelectList(db.pets, "Id", "Id");
            return View();
        }

        // POST: sales/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,customerId,petId,dateOfSale")] sale sale)
        {
            if (ModelState.IsValid)
            {
                db.sales.Add(sale);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.customerId = new SelectList(db.customers, "Id", "name", sale.customerId);
            ViewBag.petId = new SelectList(db.pets, "Id", "Id", sale.petId);
            return View(sale);
        }

        // GET: sales/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sale sale = db.sales.Find(id);
            if (sale == null)
            {
                return HttpNotFound();
            }
            ViewBag.customerId = new SelectList(db.customers, "Id", "name", sale.customerId);
            ViewBag.petId = new SelectList(db.pets, "Id", "Id", sale.petId);
            return View(sale);
        }

        // POST: sales/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,customerId,petId,dateOfSale")] sale sale)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sale).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.customerId = new SelectList(db.customers, "Id", "name", sale.customerId);
            ViewBag.petId = new SelectList(db.pets, "Id", "Id", sale.petId);
            return View(sale);
        }

        // GET: sales/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sale sale = db.sales.Find(id);
            if (sale == null)
            {
                return HttpNotFound();
            }
            return View(sale);
        }

        // POST: sales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            sale sale = db.sales.Find(id);
            db.sales.Remove(sale);
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
