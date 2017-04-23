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
    public class NewsController : BaseController
    {
        private ContentPlusEntities db = new ContentPlusEntities();

        public ActionResult ShowAdmin()
        {
            return View();
        }
        //
        // GET: /News/

        public ActionResult Index()
        {
            return View(db.NewsAdmins.ToList());
        }

        //
        // GET: /News/Details/5

        public ActionResult Details(int id = 0)
        {
            NewsAdmin newsadmin = db.NewsAdmins.Find(id);
            if (newsadmin == null)
            {
                return HttpNotFound();
            }
            return View(newsadmin);
        }

        //
        // GET: /News/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /News/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NewsAdmin newsadmin)
        {
            if (ModelState.IsValid)
            {
                db.NewsAdmins.Add(newsadmin);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(newsadmin);
        }

        //
        // GET: /News/Edit/5

        public ActionResult Edit(int id = 0)
        {
            NewsAdmin newsadmin = db.NewsAdmins.Find(id);
            if (newsadmin == null)
            {
                return HttpNotFound();
            }
            return View(newsadmin);
        }

        //
        // POST: /News/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(NewsAdmin newsadmin)
        {
            if (ModelState.IsValid)
            {
                db.Entry(newsadmin).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(newsadmin);
        }

        //
        // GET: /News/Delete/5

        public ActionResult Delete(int id = 0)
        {
            NewsAdmin newsadmin = db.NewsAdmins.Find(id);
            if (newsadmin == null)
            {
                return HttpNotFound();
            }
            return View(newsadmin);
        }

        //
        // POST: /News/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NewsAdmin newsadmin = db.NewsAdmins.Find(id);
            db.NewsAdmins.Remove(newsadmin);
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