using ContentPlus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContentPlus.Controllers
{
    public class ParishSearchController : BaseController
    {
        private ContentPlusEntities db = new ContentPlusEntities();
        //
        // GET: /ParishSearch/

        public ActionResult Index(string name)
        {
            //return View();
            if (name != null)
            {
                return View(db.Parishes.Where(x => x.Name.Contains(name)).ToList());
            }
            else
            {
                return View();
            }

        }
        public ActionResult Details(int id = 0)
        {
            Parish parish = db.Parishes.Find(id);
            if (parish == null)
            {
                return HttpNotFound();
            }
            return View(parish);
        }

    }
}
