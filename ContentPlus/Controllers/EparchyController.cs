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
    public class EparchyController : BaseController
    {
        private ContentPlusEntities db = new ContentPlusEntities();

        //
        // GET: /Eparchy/

        public ActionResult Index()
        {
            ViewBag.ProvinceList = db.Provinces.ToList();
            return View(db.Eparchies.ToList());
        }

        //
        // GET: /Eparchy/Details/5

        public ActionResult Details(int id = 0)
        {
            ViewBag.ProvinceList = db.Provinces.ToList();
            Eparchy eparchy = db.Eparchies.Find(id);
            if (eparchy == null)
            {
                return HttpNotFound();
            }
            return View(eparchy);
        }

        //
        // GET: /Eparchy/Create

        public ActionResult Create()
        {
            ViewBag.ProvinceList = db.Provinces.ToList();
            return View();
        }

        //
        // POST: /Eparchy/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Eparchy eparchy)
        {
            if (ModelState.IsValid)
            {
                db.Eparchies.Add(eparchy);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eparchy);
        }

        //
        // GET: /Eparchy/Edit/5

        public ActionResult Edit(int id = 0)
        {
            ViewBag.ProvinceList = db.Provinces.ToList();
            Eparchy eparchy = db.Eparchies.Find(id);
            if (eparchy == null)
            {
                return HttpNotFound();
            }
            return View(eparchy);
        }

        //
        // POST: /Eparchy/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Eparchy eparchy)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eparchy).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eparchy);
        }

        //
        // GET: /Eparchy/Delete/5

        public ActionResult Delete(int id = 0)
        {
            ViewBag.ProvinceList = db.Provinces.ToList();
            Eparchy eparchy = db.Eparchies.Find(id);
            if (eparchy == null)
            {
                return HttpNotFound();
            }
            return View(eparchy);
        }

        //
        // POST: /Eparchy/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Eparchy eparchy = db.Eparchies.Find(id);
            db.Eparchies.Remove(eparchy);
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