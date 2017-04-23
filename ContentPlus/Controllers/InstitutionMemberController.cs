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
    public class InstitutionMemberController : BaseController
    {
        private ContentPlusEntities db = new ContentPlusEntities();

        //
        // GET: /InstitutionMember/

        public ActionResult Index()
        {
            ViewBag.InstitutionList = db.Institutions.ToList();
            return View(db.InstitutionMembers.ToList());
        }

        //
        // GET: /InstitutionMember/Details/5

        public ActionResult Details(int id = 0)
        {
            ViewBag.InstitutionList = db.Institutions.ToList();
            InstitutionMember institutionmember = db.InstitutionMembers.Find(id);
            if (institutionmember == null)
            {
                return HttpNotFound();
            }
            return View(institutionmember);
        }

        //
        // GET: /InstitutionMember/Create

        public ActionResult Create()
        {
            ViewBag.InstitutionList = db.Institutions.ToList();
            return View();
        }

        //
        // POST: /InstitutionMember/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(InstitutionMember institutionmember)
        {
            if (ModelState.IsValid)
            {
                db.InstitutionMembers.Add(institutionmember);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(institutionmember);
        }

        //
        // GET: /InstitutionMember/Edit/5

        public ActionResult Edit(int id = 0)
        {
            ViewBag.InstitutionList = db.Institutions.ToList();
            InstitutionMember institutionmember = db.InstitutionMembers.Find(id);
            if (institutionmember == null)
            {
                return HttpNotFound();
            }
            return View(institutionmember);
        }

        //
        // POST: /InstitutionMember/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(InstitutionMember institutionmember)
        {
            if (ModelState.IsValid)
            {
                db.Entry(institutionmember).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(institutionmember);
        }

        //
        // GET: /InstitutionMember/Delete/5

        public ActionResult Delete(int id = 0)
        {
            ViewBag.InstitutionList = db.Institutions.ToList();
            InstitutionMember institutionmember = db.InstitutionMembers.Find(id);
            if (institutionmember == null)
            {
                return HttpNotFound();
            }
            return View(institutionmember);
        }

        //
        // POST: /InstitutionMember/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            InstitutionMember institutionmember = db.InstitutionMembers.Find(id);
            db.InstitutionMembers.Remove(institutionmember);
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