using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContentPlus.Models;
using System.IO;
using System.Data.Entity.Validation;

namespace ContentPlus.Controllers
{
    [Authorize]
    public class PriestController : BaseController
    {
        private ContentPlusEntities db = new ContentPlusEntities();

        //
        // GET: /Priest/

        public ActionResult Index()
        {
            return View(db.Priests.ToList());
        }

        //
        // GET: /Priest/Details/5

        public ActionResult Details(int id = 0)
        {
            Priest priest = db.Priests.Find(id);
            if (priest == null)
            {
                return HttpNotFound();
            }
            return View(priest);
        }

        //
        // GET: /Priest/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Priest/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Priest priest, IEnumerable<HttpPostedFileBase> files)
        {
            if (ModelState.IsValid)
            {
                priest = SetFilePath(priest, files);
                UploadFile(files);
                db.Priests.Add(priest);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(priest);
        }

        //
        // GET: /Priest/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Priest priest = db.Priests.Find(id);
            if (priest == null)
            {
                return HttpNotFound();
            }
            return View(priest);
        }

        //
        // POST: /Priest/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        //[AllowHtml] - Decorate property
        public ActionResult Edit(Priest priest, IEnumerable<HttpPostedFileBase> files)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    priest = SetFilePath(priest, files);
                    UploadFile(files);

                    db.Entry(priest).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(priest);
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //
        // GET: /Priest/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Priest priest = db.Priests.Find(id);
            if (priest == null)
            {
                return HttpNotFound();
            }
            return View(priest);
        }

        //
        // POST: /Priest/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Priest priest = db.Priests.Find(id);
            db.Priests.Remove(priest);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
        private Priest SetFilePath(Priest priest, IEnumerable<HttpPostedFileBase> files)
        {
            if (files.Count() > 0)
            {
                int i = 0;
                foreach (var file in files)
                {
                    if (i == 0)
                    {
                        if (file != null)
                        {
                            priest.Photo = "/Images/Priests/" + file.FileName;
                        }
                        else
                        {
                            if (priest.Photo == string.Empty || priest.Photo == null)
                            {
                                priest.Photo = "/Images/Priests/no_photo.jpg";
                            }
                            
                        }
                    }
                    i = i + 1;
                }
            }

            return priest;
        }
        public void UploadFile(IEnumerable<HttpPostedFileBase> files)
        {
            if (ModelState.IsValid)
            {
                if (files == null)
                {
                    ModelState.AddModelError("File", "Please Upload Your file");
                }
                else if (files.Count() > 0)
                {
                    foreach (var file in files)
                    {
                        if (file != null)
                        {
                            int MaxContentLength = 1024 * 1024 * 3; //3 MB
                            string[] AllowedFileExtensions = new string[] { ".jpg", ".gif", ".png" };

                            if (!AllowedFileExtensions.Contains(file.FileName.Substring(file.FileName.LastIndexOf('.'))))
                            {
                                ModelState.AddModelError("File", "Please file of type: " + string.Join(", ", AllowedFileExtensions));
                            }

                            else if (file.ContentLength > MaxContentLength)
                            {
                                ModelState.AddModelError("File", "Your file is too large, maximum allowed size is: " + MaxContentLength + " MB");
                            }
                            else
                            {
                                //TO:DO
                                var path = string.Empty;
                                var fileName = Path.GetFileName(file.FileName);
                                if (file.ContentType == "application/pdf")
                                {
                                    path = Path.Combine(Server.MapPath("~/Articles/PDF"), fileName);
                                }
                                else
                                {
                                    path = Path.Combine(Server.MapPath("~/Images/Priests"), fileName);
                                }

                                file.SaveAs(path);
                                ModelState.Clear();
                                ViewBag.Message = "File uploaded successfully";
                            }
                        }
                    }

                }
            }
        }
    }
}