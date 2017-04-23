using ContentPlus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ContentPlus.Controllers
{
    public class BaseController : Controller
    {
        private ContentPlusEntities db = new ContentPlusEntities();
        public BaseController()
        {
            //List<Article> newslist = db.Articles.Where(x => x.Category1 == "News").ToList();
            List<NewsAdmin> newslist = db.NewsAdmins.OrderByDescending(x => x.ID).Take(10).ToList();
            if (newslist != null)
            {
                ViewData["NewsList"] = newslist;
            }
        }

        protected override void Initialize(RequestContext requestContext)
        {
            base.Initialize(requestContext);
            var actionName = requestContext.RouteData.Values["action"];
            var actionController = requestContext.RouteData.Values["controller"];
            if (actionController.ToString() == "Publisher" && actionName.ToString() == "Index")
            {
                ViewBag.Header = "~/Content/Website/images/banner/Home.jpg";
            }
            else if (actionController.ToString() == "Publisher" && (actionName.ToString() == "Institutions" || actionName.ToString() == "Ecclesiastical" || actionName.ToString() == "Charitable" || actionName.ToString() == "Educational" || actionName.ToString() == "Others"))
            {
                ViewBag.Header = "~/Content/Website/images/banner/institutions.jpg";
            }
            else if (actionController.ToString() == "Publisher" && (actionName.ToString() == "TrivandrumProvince" || actionName.ToString() == "TrivandrumEparchy"))
            {
                ViewBag.Header = "~/Content/Website/images/banner/Trivandrum.jpg";
            }
            else if (actionController.ToString() == "Publisher" && actionName.ToString() == "MarthandamEparchy")
            {
                ViewBag.Header = "~/Content/Website/images/banner/Marthandom.jpg";
            }
            else if (actionController.ToString() == "Publisher" && actionName.ToString() == "MavelikaraEparchy")
            {
                ViewBag.Header = "~/Content/Website/images/banner/Mavelikara.jpg";
            }
            else if (actionController.ToString() == "Publisher" && actionName.ToString() == "PathanamthittaEparchy")
            {
                ViewBag.Header = "~/Content/Website/images/banner/Pathanamthitta.jpg";
            }
            else if (actionController.ToString() == "Publisher" && actionName.ToString() == "BatheryEparchy")
            {
                ViewBag.Header = "~/Content/Website/images/banner/Bathery.jpg";
            }
            else if (actionController.ToString() == "Publisher" && actionName.ToString() == "TiruvallaProvince" || actionName.ToString() == "TiruvallaEparchy")
            {
                ViewBag.Header = "~/Content/Website/images/banner/Tiruvalla.jpg";
            }
            else if (actionController.ToString() == "Publisher" && actionName.ToString() == "PutturEparchy")
            {
                ViewBag.Header = "~/Content/Website/images/banner/Puttur.jpg";
            }
            else if (actionController.ToString() == "Publisher" && actionName.ToString() == "MuvattupuzhaEparchy")
            {
                ViewBag.Header = "~/Content/Website/images/banner/Muvattupuzha.jpg";
            }
            else if (actionController.ToString() == "Publisher" && (actionName.ToString() == "KurisumalaAshram" 
                || actionName.ToString() == "OrderOfTheImitationOfChrist"
                || actionName.ToString() == "NavajeevanProvince"
                || actionName.ToString() == "NavajyothyProvince"
                || actionName.ToString() == "OrderoftheFriarsMinorCapuchin"
                || actionName.ToString() == "SalesiansofDonBosco"
                || actionName.ToString() == "FranciscanMissionaryBrothers"
                || actionName.ToString() == "DhyanaAshram"
                || actionName.ToString() == "ChayalpadiAshram"
                || actionName.ToString() == "SanthiAshram"
                || actionName.ToString() == "OrderofCisterciansoftheStrict"
                || actionName.ToString() == "SIC"
                || actionName.ToString() == "SICTrivandrum"
                || actionName.ToString() == "SICTiruvalla"
                || actionName.ToString() == "SICBathery"
                || actionName.ToString() == "SICPathanamthitta"
                || actionName.ToString() == "SICMuvattupuzha"
                || actionName.ToString() == "DM"
                || actionName.ToString() == "DMMarthandam"
                || actionName.ToString() == "DMTrivandrum"
                || actionName.ToString() == "DMVenniyoor"
                || actionName.ToString() == "DMPunjab"
                || actionName.ToString() == "DMBathery"
                || actionName.ToString() == "DMChanda"
                || actionName.ToString() == "SMT"
                || actionName.ToString() == "OSS"
                || actionName.ToString() == "SH"
                || actionName.ToString() == "DSS"
                || actionName.ToString() == "SCV"
                || actionName.ToString() == "SMS"
                || actionName.ToString() == "LSJ"
                || actionName.ToString() == "CSJB"
                || actionName.ToString() == "SMA"
                || actionName.ToString() == "SB"
                || actionName.ToString() == "FMM"
                || actionName.ToString() == "GSS"
                || actionName.ToString() == "SOC"
                || actionName.ToString() == "FDSHJ"
                || actionName.ToString() == "AMU"
                ))
            {
                ViewBag.Header = "~/Content/Website/images/banner/Religious.jpg";
            }
            else if (actionController.ToString() == "Publisher" && (actionName.ToString() == "Publications"
            || actionName.ToString() == "Magazines"
            || actionName.ToString() == "ChristavaKahalam"
            || actionName.ToString() == "Aikyadeepam"
            || actionName.ToString() == "Viswasabhodhini"
            || actionName.ToString() == "MalankaraNadham"
            || actionName.ToString() == "Bulletin"
            || actionName.ToString() == "MajorAthibhadrasan"
            || actionName.ToString() == "DiocesanBulletinMTM"
            || actionName.ToString() == "AmalaVoiceMVK"
            || actionName.ToString() == "BatheryRoopathBullettin"
            || actionName.ToString() == "TheEphremite"
            || actionName.ToString() == "SanthomVoice"
            || actionName.ToString() == "Girinadam"
            || actionName.ToString() == "Vimalanadam"
            || actionName.ToString() == "ShanthiVani"
            || actionName.ToString() == "Exodus"
            || actionName.ToString() == "MalankaraBulletin"
            || actionName.ToString() == "PastoralLetters"
            || actionName.ToString() == "Lectionary"
            || actionName.ToString() == "IvanianVoice"
            ))
            {
                ViewBag.Header = "~/Content/Website/images/banner/publications.jpg";
            }  
            else
            {
                ViewBag.Header = "~/Content/Website/images/banner/Home.jpg";
            }
   
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            Exception e = filterContext.Exception;
            //Log Exception e
            filterContext.ExceptionHandled = true;
            filterContext.Result = new ViewResult()
            {
                ViewName = "Error"
            };
        }
        

    }
}
