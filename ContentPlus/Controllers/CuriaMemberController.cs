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
    public class CuriaMemberController : BaseController
    {
        private ContentPlusEntities db = new ContentPlusEntities();

        //
        // GET: /CuriaMember/

        public ActionResult Index()
        {
            ViewBag.CuriaList = db.Curias.ToList();
            ViewBag.PriestList = db.Priests.ToList();
            return View(db.CuriaMembers.ToList());
        }

        //
        // GET: /CuriaMember/Details/5

        public ActionResult Details(int id = 0)
        {
            ViewBag.CuriaList = db.Curias.ToList();
            ViewBag.PriestList = db.Priests.ToList();
            CuriaMember curiamember = db.CuriaMembers.Find(id);
            if (curiamember == null)
            {
                return HttpNotFound();
            }
            return View(curiamember);
        }

        //
        // GET: /CuriaMember/Create

        public ActionResult Create()
        {
            ViewBag.CuriaList = db.Curias.ToList();
            ViewBag.PriestList = db.Priests.ToList();
            return View();
        }

        //
        // POST: /CuriaMember/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CuriaMember curiamember)
        {
            if (ModelState.IsValid)
            {
                db.CuriaMembers.Add(curiamember);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(curiamember);
        }

        //
        // GET: /CuriaMember/Edit/5

        public ActionResult Edit(int id = 0)
        {
            ViewBag.CuriaList = db.Curias.ToList();
            ViewBag.PriestList = db.Priests.ToList();
            CuriaMember curiamember = db.CuriaMembers.Find(id);
            if (curiamember == null)
            {
                return HttpNotFound();
            }
            return View(curiamember);
        }

        //
        // POST: /CuriaMember/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CuriaMember curiamember)
        {
            if (ModelState.IsValid)
            {
                db.Entry(curiamember).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(curiamember);
        }

        //
        // GET: /CuriaMember/Delete/5

        public ActionResult Delete(int id = 0)
        {
            ViewBag.CuriaList = db.Curias.ToList();
            ViewBag.PriestList = db.Priests.ToList();
            CuriaMember curiamember = db.CuriaMembers.Find(id);
            if (curiamember == null)
            {
                return HttpNotFound();
            }
            return View(curiamember);
        }

        //
        // POST: /CuriaMember/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CuriaMember curiamember = db.CuriaMembers.Find(id);
            db.CuriaMembers.Remove(curiamember);
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