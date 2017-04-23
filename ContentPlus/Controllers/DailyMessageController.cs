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
    public class DailyMessageController : BaseController
    {
        private ContentPlusEntities db = new ContentPlusEntities();

        //
        // GET: /DailyMessage/

        public ActionResult Index()
        {
            return View(db.DailyMessages.ToList());
        }

        //
        // GET: /DailyMessage/Details/5

        public ActionResult Details(int id = 0)
        {
            DailyMessage dailymessage = db.DailyMessages.Find(id);
            if (dailymessage == null)
            {
                return HttpNotFound();
            }
            return View(dailymessage);
        }

        //
        // GET: /DailyMessage/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /DailyMessage/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DailyMessage dailymessage)
        {
            if (ModelState.IsValid)
            {
                db.DailyMessages.Add(dailymessage);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dailymessage);
        }

        //
        // GET: /DailyMessage/Edit/5

        public ActionResult Edit(int id = 0)
        {
            DailyMessage dailymessage = db.DailyMessages.Find(id);
            if (dailymessage == null)
            {
                return HttpNotFound();
            }
            return View(dailymessage);
        }

        //
        // POST: /DailyMessage/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(DailyMessage dailymessage)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dailymessage).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dailymessage);
        }

        //
        // GET: /DailyMessage/Delete/5

        public ActionResult Delete(int id = 0)
        {
            DailyMessage dailymessage = db.DailyMessages.Find(id);
            if (dailymessage == null)
            {
                return HttpNotFound();
            }
            return View(dailymessage);
        }

        //
        // POST: /DailyMessage/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DailyMessage dailymessage = db.DailyMessages.Find(id);
            db.DailyMessages.Remove(dailymessage);
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