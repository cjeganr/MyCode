using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContentPlus.Models;
using System.IO;

namespace ContentPlus.Controllers
{
    [Authorize]
    public class ArticlesController : BaseController
    {
        private ContentPlusEntities db = new ContentPlusEntities();

        //
        // GET: /Articles/

        public ActionResult Index()
        {
            return View(db.Articles.ToList());
        }
        public ActionResult Show()
        {
            return View(db.Articles.ToList());
        }
        //
        // GET: /Articles/Details/5

        public ActionResult Details(int id = 0)
        {
            Article article = db.Articles.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            return View(article);
        }

        
        //
        // GET: /Articles/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Articles/Create

        [HttpPost]
        //[ValidateInput(false)]
        //[ValidateAntiForgeryToken]
        public ActionResult Create(Article article, IEnumerable<HttpPostedFileBase> files)
        {            
            if (ModelState.IsValid)
            {
                article = SetFilePath(article,files);
                UploadFile(files);
                
                article.UpdatedDate = DateTime.Now;
                article.CreatedDate = DateTime.Now;
                db.Articles.Add(article);
                db.SaveChanges();
                return RedirectToAction("Show");
            }

            return View(article);
        }
        
        //
        // GET: /Articles/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Article article = db.Articles.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            return View(article);
        }

        //
        // POST: /Articles/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Article article, IEnumerable<HttpPostedFileBase> files)
        {
            if (ModelState.IsValid)
            {
                article = SetFilePath(article, files);
                UploadFile(files);
                
                article.UpdatedDate = DateTime.Now;
                db.Entry(article).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Show");
            }
            return View(article);
        }

        //
        // GET: /Articles/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Article article = db.Articles.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            return View(article);
        }

        //
        // POST: /Articles/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Article article = db.Articles.Find(id);
            db.Articles.Remove(article);
            db.SaveChanges();
            return RedirectToAction("Show");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
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
                            string[] AllowedFileExtensions = new string[] { ".jpg", ".gif", ".png", ".pdf" };

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
                                    path = Path.Combine(Server.MapPath("~/Articles/Images"), fileName);
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

        private Article SetFilePath(Article article, IEnumerable<HttpPostedFileBase> files)
        {
            if (files.Count() > 0)
            {
                int i = 0;
                foreach (var file in files)
                {
                    if (i==0)
	                {
                        if (file != null)
                        {
                            article.Photo1 = "/Articles/Images/" + file.FileName; 
                        }
                        else
                        {
                            if (article.Photo1 == string.Empty || article.Photo1 == null)
                            {
                                article.Photo1 = "/Images/Priests/no_photo.jpg";
                            }
                            
                        }
	                }
                    else if (i==1)
	                {
                        if (file != null)
                        {
                            article.Photo2 = "/Articles/Images/" + file.FileName;
                        }
                        else
                        {
                            if (article.Photo2 == string.Empty || article.Photo2 == null)
                            {
                                article.Photo2 = "/Images/Priests/no_photo.jpg";
                            }
                        }
	                }
                    else if(i==2)
	                {
                        if (file != null)
                        {
                            article.Photo3 = "/Articles/Images/" + file.FileName;
                        }
                        else
                        {
                            if (article.Photo3 == string.Empty || article.Photo3 == null)
                            {
                                article.Photo3 = "/Images/Priests/no_photo.jpg";
                            }
                        }
	                }
                    else if (i == 3)
                    {
                        if (file != null)
                        {
                            article.PDF1 = "/Articles/PDF/" + file.FileName;
                        }
                    }
                    else if (i == 4)
                    {
                        if (file != null)
                        {
                            article.PDF2 = "/Articles/PDF/" + file.FileName;
                        }
                    }
                    else if (i == 5)
                    {
                        if (file != null)
                        {
                            article.PDF3 = "/Articles/PDF/" + file.FileName;
                        }
                    }
                    i = i + 1;
                }
            }
           
            return article;
        }
    }
}