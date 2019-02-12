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
    public class soldPetsController : Controller
    {
        private ContextClass db = new ContextClass();

        // GET: soldPets
        public ActionResult Index()
        {
            var soldPets = db.soldPets.Include(s => s.category);
            return View(soldPets.ToList());
        }

        // GET: soldPets/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            soldPet soldPet = db.soldPets.Find(id);
            if (soldPet == null)
            {
                return HttpNotFound();
            }
            return View(soldPet);
        }

        // GET: soldPets/Create
        public ActionResult Create()
        {
            ViewBag.categoryId = new SelectList(db.categories, "Id", "categoryName");
            return View();
        }

        // POST: soldPets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,categoryId,birthDate,gender,price")] soldPet soldPet)
        {
            if (ModelState.IsValid)
            {
                db.soldPets.Add(soldPet);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.categoryId = new SelectList(db.categories, "Id", "categoryName", soldPet.categoryId);
            return View(soldPet);
        }

        // GET: soldPets/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            soldPet soldPet = db.soldPets.Find(id);
            if (soldPet == null)
            {
                return HttpNotFound();
            }
            ViewBag.categoryId = new SelectList(db.categories, "Id", "categoryName", soldPet.categoryId);
            return View(soldPet);
        }

        // POST: soldPets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,categoryId,birthDate,gender,price")] soldPet soldPet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(soldPet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.categoryId = new SelectList(db.categories, "Id", "categoryName", soldPet.categoryId);
            return View(soldPet);
        }

        // GET: soldPets/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            soldPet soldPet = db.soldPets.Find(id);
            if (soldPet == null)
            {
                return HttpNotFound();
            }
            return View(soldPet);
        }

        // POST: soldPets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            soldPet soldPet = db.soldPets.Find(id);
            db.soldPets.Remove(soldPet);
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
