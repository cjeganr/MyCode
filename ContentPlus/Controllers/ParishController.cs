using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContentPlus.Models;

namespace ContentPlus.Controllers
{
    [Authorize]
    public class ParishController : Controller
    {
        private ContentPlusEntities db = new ContentPlusEntities();

        //
        // GET: /Parish/

        public ActionResult Index()
        {
            return View(db.Parishes.ToList());
        }

        //
        // GET: /Parish/Details/5

        public ActionResult Details(int id = 0)
        {
            Parish parish = db.Parishes.Find(id);
            if (parish == null)
            {
                return HttpNotFound();
            }
            return View(parish);
        }

        //
        // GET: /Parish/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Parish/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Parish parish)
        {
            if (ModelState.IsValid)
            {
                db.Parishes.Add(parish);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(parish);
        }

        //
        // GET: /Parish/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Parish parish = db.Parishes.Find(id);
            if (parish == null)
            {
                return HttpNotFound();
            }
            return View(parish);
        }

        //
        // POST: /Parish/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Parish parish)
        {
            if (ModelState.IsValid)
            {
                db.Entry(parish).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(parish);
        }

        //
        // GET: /Parish/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Parish parish = db.Parishes.Find(id);
            if (parish == null)
            {
                return HttpNotFound();
            }
            return View(parish);
        }

        //
        // POST: /Parish/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Parish parish = db.Parishes.Find(id);
            db.Parishes.Remove(parish);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}