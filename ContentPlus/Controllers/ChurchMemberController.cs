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
    public class ChurchMemberController : Controller
    {
        private ContentPlusEntities db = new ContentPlusEntities();

        //
        // GET: /ChurchMember/

        public ActionResult Index()
        {
            ViewBag.ChurchList = db.Churches.ToList();
            ViewBag.PriestList = db.Priests.ToList();
            return View(db.ChurchMembers.ToList());
        }

        //
        // GET: /ChurchMember/Details/5

        public ActionResult Details(int id = 0)
        {
            ViewBag.ChurchList = db.Churches.ToList();
            ViewBag.PriestList = db.Priests.ToList();
            ChurchMember churchmember = db.ChurchMembers.Find(id);
            if (churchmember == null)
            {
                return HttpNotFound();
            }
            return View(churchmember);
        }

        //
        // GET: /ChurchMember/Create

        public ActionResult Create()
        {
            ViewBag.ChurchList = db.Churches.ToList();
            ViewBag.PriestList = db.Priests.ToList();
            return View();
        }

        //
        // POST: /ChurchMember/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ChurchMember churchmember)
        {
            if (ModelState.IsValid)
            {
                db.ChurchMembers.Add(churchmember);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(churchmember);
        }

        //
        // GET: /ChurchMember/Edit/5

        public ActionResult Edit(int id = 0)
        {
            ViewBag.ChurchList = db.Churches.ToList();
            ViewBag.PriestList = db.Priests.ToList();
            ChurchMember churchmember = db.ChurchMembers.Find(id);
            if (churchmember == null)
            {
                return HttpNotFound();
            }
            return View(churchmember);
        }

        //
        // POST: /ChurchMember/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ChurchMember churchmember)
        {
            if (ModelState.IsValid)
            {
                db.Entry(churchmember).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(churchmember);
        }

        //
        // GET: /ChurchMember/Delete/5

        public ActionResult Delete(int id = 0)
        {
            ViewBag.ChurchList = db.Churches.ToList();
            ViewBag.PriestList = db.Priests.ToList();
            ChurchMember churchmember = db.ChurchMembers.Find(id);
            if (churchmember == null)
            {
                return HttpNotFound();
            }
            return View(churchmember);
        }

        //
        // POST: /ChurchMember/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ChurchMember churchmember = db.ChurchMembers.Find(id);
            db.ChurchMembers.Remove(churchmember);
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