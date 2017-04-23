using ContentPlus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContentPlus.Controllers
{
    public class HomeController : BaseController
    {
        private ContentPlusEntities db = new ContentPlusEntities();
        public ActionResult Index()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "Welcome").ToList();
            if (home != null)
            {
                ViewBag.Content = home[0].Content.ToString().Substring(0,500);
            }
            //List<Article> newslist = db.Articles.Where(x => x.Category1 == "News").ToList();
            List<NewsAdmin> newslist = db.NewsAdmins.OrderByDescending(x => x.ID).Take(10).ToList();
            if (newslist != null)
            {
                ViewData["NewsList"] = newslist;
            }
            return View(); 
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
