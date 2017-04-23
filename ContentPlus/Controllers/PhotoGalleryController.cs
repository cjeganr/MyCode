using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContentPlus.Controllers
{
    public class PhotoGalleryController : BaseController
    {
        //
        // GET: /PhotoGallery/

        public ActionResult Index()
        {
            return View();
        }

    }
}
