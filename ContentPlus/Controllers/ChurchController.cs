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
    public class ChurchController : BaseController
    {
        private ContentPlusEntities db = new ContentPlusEntities();

        //
        // GET: /Church/

        public ActionResult Index()
        {
            return View(db.Churches.ToList());
        }

        //
        // GET: /Church/Details/5

        public ActionResult Details(int id = 0)
        {
            Church church = db.Churches.Find(id);
            if (church == null)
            {
                return HttpNotFound();
            }
            return View(church);
        }

        //
        // GET: /Church/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Church/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Church church)
        {
            if (ModelState.IsValid)
            {
                db.Churches.Add(church);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(church);
        }

        //
        // GET: /Church/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Church church = db.Churches.Find(id);
            if (church == null)
            {
                return HttpNotFound();
            }
            return View(church);
        }

        //
        // POST: /Church/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Church church)
        {
            if (ModelState.IsValid)
            {
                db.Entry(church).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(church);
        }

        //
        // GET: /Church/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Church church = db.Churches.Find(id);
            if (church == null)
            {
                return HttpNotFound();
            }
            return View(church);
        }

        //
        // POST: /Church/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Church church = db.Churches.Find(id);
            db.Churches.Remove(church);
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