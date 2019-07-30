using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Controllers
{
    public class LibraryCardController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: LibraryCard
        public ActionResult Index()
        {
            return View(db.LibraryCards.ToList());
        }

        // GET: LibraryCard/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LibraryCard libraryCard = db.LibraryCards.Find(id);
            if (libraryCard == null)
            {
                return HttpNotFound();
            }
            return View(libraryCard);
        }

        // GET: LibraryCard/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LibraryCard/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LibraryCardId,firstName,lastName,DateOfBirth,Phone,Email")] LibraryCard libraryCard)
        {
            if (ModelState.IsValid)
            {
                db.LibraryCards.Add(libraryCard);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(libraryCard);
        }

        // GET: LibraryCard/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LibraryCard libraryCard = db.LibraryCards.Find(id);
            if (libraryCard == null)
            {
                return HttpNotFound();
            }
            return View(libraryCard);
        }

        // POST: LibraryCard/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LibraryCardId,firstName,lastName,DateOfBirth,Phone,Email")] LibraryCard libraryCard)
        {
            if (ModelState.IsValid)
            {
                db.Entry(libraryCard).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(libraryCard);
        }

        // GET: LibraryCard/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LibraryCard libraryCard = db.LibraryCards.Find(id);
            if (libraryCard == null)
            {
                return HttpNotFound();
            }
            return View(libraryCard);
        }

        // POST: LibraryCard/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LibraryCard libraryCard = db.LibraryCards.Find(id);
            db.LibraryCards.Remove(libraryCard);
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
