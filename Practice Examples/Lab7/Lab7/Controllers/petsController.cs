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
    public class petsController : Controller
    {
        private ContextClass db = new ContextClass();

        // GET: pets
        public ActionResult Index()
        {
            var pets = db.pets.Include(p => p.category);
            return View(pets.ToList());
        }

        // GET: pets/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pet pet = db.pets.Find(id);
            if (pet == null)
            {
                return HttpNotFound();
            }
            return View(pet);
        }

        // GET: pets/Create
        public ActionResult Create()
        {
            ViewBag.categoryId = new SelectList(db.categories, "Id", "categoryName");
            return View();
        }

        // POST: pets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,categoryId,birthDate,gender,price")] pet pet)
        {
            if (ModelState.IsValid)
            {
                db.pets.Add(pet);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.categoryId = new SelectList(db.categories, "Id", "categoryName", pet.categoryId);
            return View(pet);
        }

        // GET: pets/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pet pet = db.pets.Find(id);
            if (pet == null)
            {
                return HttpNotFound();
            }
            ViewBag.categoryId = new SelectList(db.categories, "Id", "categoryName", pet.categoryId);
            return View(pet);
        }

        // POST: pets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,categoryId,birthDate,gender,price")] pet pet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.categoryId = new SelectList(db.categories, "Id", "categoryName", pet.categoryId);
            return View(pet);
        }

        // GET: pets/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pet pet = db.pets.Find(id);
            if (pet == null)
            {
                return HttpNotFound();
            }
            return View(pet);
        }

        // POST: pets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            pet pet = db.pets.Find(id);
            db.pets.Remove(pet);
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
