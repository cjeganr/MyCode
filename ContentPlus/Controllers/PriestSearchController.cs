using ContentPlus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContentPlus.Controllers
{

    public class PriestSearchController : BaseController
    {
        private ContentPlusEntities db = new ContentPlusEntities();

        //
        // GET: /PriestSearch/

        public ActionResult Index(string name)
        {
            //return View();
            if (name != null)
            {
                return View(db.Priests.Where(x => x.Name.Contains(name)).ToList());    
            }
            else
            {
                return View();
            }
            
        }
        public ActionResult Details(int id = 0)
        {
            Priest priest = db.Priests.Find(id);
            if (priest == null)
            {
                return HttpNotFound();
            }
            return View(priest);
        }
    }
}
