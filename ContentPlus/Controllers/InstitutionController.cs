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
    public class InstitutionController : BaseController
    {
        private ContentPlusEntities db = new ContentPlusEntities();

        //
        // GET: /Institution/

        public ActionResult Index()
        {
            ViewBag.EparchyList = db.Eparchies.ToList();
            return View(db.Institutions.ToList());
        }

        //
        // GET: /Institution/Details/5

        public ActionResult Details(int id = 0)
        {
            ViewBag.EparchyList = db.Eparchies.ToList();
            Institution institution = db.Institutions.Find(id);
            if (institution == null)
            {
                return HttpNotFound();
            }
            return View(institution);
        }

        //
        // GET: /Institution/Create

        public ActionResult Create()
        {
            ViewBag.EparchyList = db.Eparchies.ToList();
            return View();
        }

        //
        // POST: /Institution/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Institution institution)
        {
            if (ModelState.IsValid)
            {
                db.Institutions.Add(institution);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(institution);
        }

        //
        // GET: /Institution/Edit/5

        public ActionResult Edit(int id = 0)
        {
            ViewBag.EparchyList = db.Eparchies.ToList();
            Institution institution = db.Institutions.Find(id);
            if (institution == null)
            {
                return HttpNotFound();
            }
            return View(institution);
        }

        //
        // POST: /Institution/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Institution institution)
        {
            if (ModelState.IsValid)
            {
                db.Entry(institution).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(institution);
        }

        //
        // GET: /Institution/Delete/5

        public ActionResult Delete(int id = 0)
        {
            ViewBag.EparchyList = db.Eparchies.ToList();
            Institution institution = db.Institutions.Find(id);
            if (institution == null)
            {
                return HttpNotFound();
            }
            return View(institution);
        }

        //
        // POST: /Institution/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Institution institution = db.Institutions.Find(id);
            db.Institutions.Remove(institution);
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
