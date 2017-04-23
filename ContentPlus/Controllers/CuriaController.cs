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
    public class CuriaController : BaseController
    {
        private ContentPlusEntities db = new ContentPlusEntities();

        //
        // GET: /Curia/

        public ActionResult Index()
        {
            ViewBag.ChurchList = db.Churches.ToList();
            return View(db.Curias.ToList());
        }

        //
        // GET: /Curia/Details/5

        public ActionResult Details(int id = 0)
        {
            ViewBag.ChurchList = db.Churches.ToList();
            Curia curia = db.Curias.Find(id);
            if (curia == null)
            {
                return HttpNotFound();
            }
            return View(curia);
        }

        //
        // GET: /Curia/Create

        public ActionResult Create()
        {
            ViewBag.ChurchList = db.Churches.ToList();
            return View();
        }

        //
        // POST: /Curia/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Curia curia)
        {
            if (ModelState.IsValid)
            {
                db.Curias.Add(curia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(curia);
        }

        //
        // GET: /Curia/Edit/5

        public ActionResult Edit(int id = 0)
        {
            ViewBag.ChurchList = db.Churches.ToList();
            Curia curia = db.Curias.Find(id);
            if (curia == null)
            {
                return HttpNotFound();
            }
            return View(curia);
        }

        //
        // POST: /Curia/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Curia curia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(curia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(curia);
        }

        //
        // GET: /Curia/Delete/5

        public ActionResult Delete(int id = 0)
        {
            ViewBag.ChurchList = db.Churches.ToList();
            Curia curia = db.Curias.Find(id);
            if (curia == null)
            {
                return HttpNotFound();
            }
            return View(curia);
        }

        //
        // POST: /Curia/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Curia curia = db.Curias.Find(id);
            db.Curias.Remove(curia);
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