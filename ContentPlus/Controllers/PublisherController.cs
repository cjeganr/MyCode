using ContentPlus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContentPlus.Controllers
{
    public class PublisherController : BaseController
    {
        //
        // GET: /Publisher/
        private ContentPlusEntities db = new ContentPlusEntities();
        public ActionResult Index()
        {

            List<Article> home =   db.Articles.Where(x => x.Title == "Home").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View(); 
        }
        public ActionResult MajorArchiepiscopalChurch()
        {

            List<Article> home = db.Articles.Where(x => x.Title == "MajorArchiepiscopalChurch").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult LateHeads()
        {
            List<Priest> priest = db.Priests.Where(x => x.Field4 == "LateHeads").ToList();
            return View(priest);
        }

        public ActionResult Welcome()
        {

            List<Article> home = db.Articles.Where(x => x.Title == "Home").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult NewsDetails(int id = 0)
        {
            Article article = db.Articles.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            return View(article);
        }
        public ActionResult AllNews()
        {   
            //List<Article> newslist = db.Articles.Where(x => x.Category1 == "News").ToList();
            List<NewsAdmin> newslist = db.NewsAdmins.OrderByDescending(x => x.ID).ToList();
            return View(newslist);
        }
        public ActionResult LateBishops()
        {
            List<Priest> priest = db.Priests.Where(x => x.Field4 == "LateBishops").ToList();
            return View(priest);
        }
        public ActionResult LatePrelates()
        {
            List<Priest> priest = db.Priests.Where(x => x.Field4 == "LatePrelates").ToList();
            return View(priest);
        }
        public ActionResult Hirerachy()
        {
            return View();
        }
        public ActionResult Pope()
        {
            List<Priest> priest = db.Priests.Where(x => x.Field4 == "Pope").ToList();
            return View(priest[0]);
        }
        public ActionResult MajorArchBishop()
        {
            List<Priest> priest = db.Priests.Where(x => x.Field4 == "MajorArchBishop").ToList();
            return View(priest[0]);
        }
        public ActionResult SynodFathers()
        {
            List<Priest> priest = db.Priests.Where(x => x.Field4 == "SynodFathers").ToList();
            return View(priest);
        }
        public ActionResult OrdinarySynod()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "OrdinarySynod").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult FirstOrdinarySynod()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "FirstOrdinarySynod").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult SecondOrdinarySynod()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "SecondOrdinarySynod").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult ThirdOrdinarySynod()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "ThirdOrdinarySynod").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult FourthOrdinarySynod()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "FourthOrdinarySynod").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult FifthOrdinarySynod()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "FifthOrdinarySynod").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult SixthOrdinarySynod()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "SixthOrdinarySynod").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult SeventhOrdinarySynod()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "SeventhOrdinarySynod").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult EighthOrdinarySynod()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "EighthOrdinarySynod").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult NinthOrdinarySynod()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "NinthOrdinarySynod").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult TenthOrdinarySynod()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "TenthOrdinarySynod").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult EleventhOrdinarySynod()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "EleventhOrdinarySynod").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult TwelthOrdinarySynod()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "TwelthOrdinarySynod").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult ThirteenthOrdinarySynod()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "ThirteenthOrdinarySynod").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult FourteenOrdinarySynod()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "FourteenOrdinarySynod").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult FifteenOrdinarySynod()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "FifteenOrdinarySynod").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult SixteenOrdinarySynod()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "SixteenOrdinarySynod").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult SeventeenOrdinarySynod()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "SeventeenOrdinarySynod").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult EighteenOrdinarySynod()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "EighteenOrdinarySynod").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult ExtraOrdinarySynod()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "ExtraOrdinarySynod").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult Curia()
        {
            List<Curia> curia = db.Curias.Where(x => x.Field4 == "Curia").ToList();
            return View(curia[0]);
            
        }
        public ActionResult Provinces()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "Provinces").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult Religious()
        {
            return View();
        }
        public ActionResult Institutions()
        {
            return View();
        }
        public ActionResult Publications()
        {
            return View();
        }
        public ActionResult PriestDetails(int id)
        {
            Priest priest = db.Priests.Find(id);
            if (priest == null)
            {
                return HttpNotFound();
            }
            return View(priest);
        }
        public ActionResult PermanentSynod()
        {
            List<Curia> curia = db.Curias.Where(x => x.Field4 == "PermanentSynod").ToList();
            if (curia != null)
            {
                ViewBag.Content = curia[0].Description;
            }
            return View();            
        }
        public ActionResult Offices()
        {
            List<Curia> curia = db.Curias.Where(x => x.Field4 == "Offices").ToList();
            if (curia != null)
            {
                ViewBag.Content = curia[0].Description;
            }
            return View();
                       
        }
        public ActionResult SynodalCommissions()
        {
            List<Curia> curia = db.Curias.Where(x => x.Field4 == "SynodalCommissions").ToList();
            return View(curia[0]);
        }
        public ActionResult Tribunals()
        {
            List<Curia> curia = db.Curias.Where(x => x.Field4 == "Tribunals").ToList();
            return View(curia[0]);
        }
        public ActionResult Canonisation()
        {
            List<Curia> curia = db.Curias.Where(x => x.Field4 == "Canonisation").ToList();
            return View(curia[0]);
        }

        
        public ActionResult TrivandrumProvince()
        {
            List<Province> province = db.Provinces.Where(x => x.Name == "Trivandrum").ToList();
            return View(province[0]);
        }
        public ActionResult TiruvallaProvince()
        {
            List<Province> province = db.Provinces.Where(x => x.Name == "Tiruvalla").ToList();
            return View(province[0]);
        }
        public ActionResult ExarchateInUSA()
        {
            List<Province> province = db.Provinces.Where(x => x.Name == "Exarchate In USA").ToList();
            return View(province[0]);
        }
        public ActionResult ExtraterritorialRegions()
        {
            List<Province> province = db.Provinces.Where(x => x.Name == "ExtraterritorialRegions").ToList();
            return View(province[0]);
        }
        public ActionResult GurgaonDelhi()
        {
            List<Province> province = db.Provinces.Where(x => x.Name == "GurgaonDelhi").ToList();
            return View(province[0]);
        }
        public ActionResult USAAndCanada()
        {
            List<Province> province = db.Provinces.Where(x => x.Name == "USAAndCanada").ToList();
            return View(province[0]);
        }
        public ActionResult ExarchateofKhadkiPune()
        {
            List<Province> province = db.Provinces.Where(x => x.Name == "ExarchateofKhadkiPune").ToList();
            return View(province[0]);
        }

        public ActionResult ETR()
        {
            List<Province> province = db.Provinces.Where(x => x.Name == "ETR").ToList();
            return View(province[0]);
        }
        public ActionResult UnderConstruction()
        {
            return View();
        }
        public ActionResult TrivandrumEparchy()
        {
            List<Eparchy> eparchy = db.Eparchies.Where(x => x.Field4 == "TrivandrumEparchy").ToList();
            return View(eparchy[0]);
        }
        public ActionResult MarthandamEparchy()
        {
            List<Eparchy> eparchy = db.Eparchies.Where(x => x.Field4 == "MarthandamEparchy").ToList();
            return View(eparchy[0]);
        }
        public ActionResult MavelikaraEparchy()
        {
            List<Eparchy> eparchy = db.Eparchies.Where(x => x.Field4 == "MavelikaraEparchy").ToList();
            return View(eparchy[0]);
        }
        
        public ActionResult PathanamthittaEparchy()
        {
            List<Eparchy> eparchy = db.Eparchies.Where(x => x.Field4 == "PathanamthittaEparchy").ToList();
            return View(eparchy[0]);
        }
        public ActionResult TiruvallaEparchy()
        {
            List<Eparchy> eparchy = db.Eparchies.Where(x => x.Field4 == "TiruvallaEparchy").ToList();
            return View(eparchy[0]);
        }
        public ActionResult BatheryEparchy()
        {
            List<Eparchy> eparchy = db.Eparchies.Where(x => x.Field4 == "BatheryEparchy").ToList();
            if (eparchy.Count> 0)
            {
                return View(eparchy[0]);    
            }
            else
            {
                return View(); 
            }
            
        }
        public ActionResult MuvattupuzhaEparchy()
        {
            List<Eparchy> eparchy = db.Eparchies.Where(x => x.Field4 == "MuvattupuzhaEparchy").ToList();
            return View(eparchy[0]);
        }
        public ActionResult PutturEparchy()
        {
            List<Eparchy> eparchy = db.Eparchies.Where(x => x.Field4 == "PutturEparchy").ToList();
            return View(eparchy[0]);
        }
        public ActionResult ItalyEparchy()
        {
            List<Eparchy> eparchy = db.Eparchies.Where(x => x.Field4 == "ItalyEparchy").ToList();
            return View(eparchy[0]);
        }
        public ActionResult GermanyEparchy()
        {
            List<Eparchy> eparchy = db.Eparchies.Where(x => x.Field4 == "GermanyEparchy").ToList();
            return View(eparchy[0]);
        }
        public ActionResult UKEparchy()
        {
            List<Eparchy> eparchy = db.Eparchies.Where(x => x.Field4 == "UKEparchy").ToList();
            return View(eparchy[0]);
        }
        public ActionResult CanadaEparchy()
        {
            List<Eparchy> eparchy = db.Eparchies.Where(x => x.Field4 == "CanadaEparchy").ToList();
            return View(eparchy[0]);
        }
        public ActionResult MiddleEastEparchy()
        {
            List<Eparchy> eparchy = db.Eparchies.Where(x => x.Field4 == "MiddleEastEparchy").ToList();
            return View(eparchy[0]);
        }
        public ActionResult ETRIndiaEparchy()
        {
            List<Eparchy> eparchy = db.Eparchies.Where(x => x.Field4 == "ETRIndiaEparchy").ToList();
            return View(eparchy[0]);
        }
        public ActionResult AustraliaSingapore()
        {
            List<Eparchy> eparchy = db.Eparchies.Where(x => x.Field4 == "AustraliaSingapore").ToList();
            return View(eparchy[0]);
        } 
        public ActionResult PermanentSynodMembers()
        {
            List<CuriaPriest> curiaMembers = new List<CuriaPriest>();

            var joined = (from Item1 in db.CuriaMembers.ToList()
                         join Item2 in db.Priests.ToList()
                         on Item1.PriestId equals Item2.ID // join on some property
                         select new { Item1.Positionheld, Item2.Name }).ToList();

            foreach (var item in joined)
            {
                CuriaPriest obj = new CuriaPriest();
                obj.Name = item.Name;
                obj.Positionheld = item.Positionheld;
                curiaMembers.Add(obj);
            }
            if (curiaMembers != null)
            {
                return View(curiaMembers);
            }
            else
            {
                return View();
            }            
        }
        public ActionResult PermanentSynodReports()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "CuriaReports").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult SynodCommReport()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "SynodCommReport").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult SynodCommLiturgy()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "SynodCommLiturgy").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult SynodCommBibleApostolate()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "SynodCommBibleApostolate").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult SynodCommEvangelization()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "SynodCommEvangelization").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult SynodCommFaithfuloutsideIndia()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "SynodCommFaithfuloutsideIndia").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult SynodCommTheologyandPublications()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "SynodCommTheologyandPublications").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult SynodCommPublications()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "SynodCommPublications").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult SynodCommEcumenismandDialogue()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "SynodCommEcumenismandDialogue").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult SynodCommClergy()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "SynodCommClergy").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult SynodCommReligious()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "SynodCommReligious").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult SynodCommLaity()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "SynodCommLaity").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult SynodCommYouth()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "SynodCommYouth").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult SynodCommFamily()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "SynodCommFamily").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult SynodCommCatechism()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "SynodCommCatechism").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult SynodCommVocation()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "SynodCommVocation").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult SynodCommSeminaryFormation()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "SynodCommSeminaryFormation").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        
        public ActionResult SynodCommEducation()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "SynodCommEducation").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult SynodCommSocialApostolateandDalitChristians()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "SynodCommSocialApostolateandDalitChristians").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult SynodCommHealthService()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "SynodCommHealthService").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult SynodCommCommunications()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "SynodCommCommunications").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult OrderOfTheImitationOfChrist()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "Order Of The Imitation Of Christ").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        
        public ActionResult OrderOfTheFriarsMinorCapuchin()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "Order Of The Friars Minor Capuchin").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult SalesiansOfDonBosco()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "Salesians Of Don Bosco (sdb)").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult KurisumalaAshram()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "Kurisumala Ashram").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult FranciscanMissionaryBrothers()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "Franciscan Missionary Brothers").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult MalabarMissionaryBrothers()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "Malabar Missionary Brothers").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult DisciplesOfDivineSaviour()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "Disciples Of Divine Saviour (dds)").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult DhyanaAshram()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "Dhyana Ashram").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult ChayalpadiAshram()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "Chayalpadi Ashram").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult SanthiAshram()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "Santhi Ashram").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult SIC()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "SIC").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult DM()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "DM").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        //public ActionResult SMT()
        //{
        //    List<Article> home = db.Articles.Where(x => x.Title == "SMT").ToList();
        //    if (home.Count > 0)
        //    {
        //        ViewBag.Content = home[0].Content;
        //    }
        //    return View();
        //}
        public ActionResult OSS()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "OSS").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult SH()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "SH").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult DSS()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "DSS").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult SCV()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "SCV").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult SMS()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "SMS").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult LSJ()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "LSJ").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }

        public ActionResult SMA()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "SMA").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult SB()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "SB").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult SMT()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "SMT").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult GSS()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "GSS").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult SOC()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "SOC").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult FDSHJ()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "FDSHJ").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult AMU()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "AMU").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult Ecclesiastical()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "Ecclesiastical").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult Charitable()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "Charitable").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult Educational()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "Educational").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult Others()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "Others").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult ChristavaKahalam()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "Christava Kahalam").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult Aikyadeepam()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "Aikyadeepam").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult MalankaraBalan()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "Malankara Balan").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult SICTrivandrum()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "SICTrivandrum").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult SICTiruvalla()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "SICTiruvalla").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult SICBathery()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "SICBathery").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult SICPathanamthitta()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "SICPathanamthitta").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult SICMuvattupuzha()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "SICMuvattupuzha").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult DMMarthandam()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "DMMarthandam").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult DMTrivandrum()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "DMTrivandrum").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult DMVenniyoor()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "DMVenniyoor").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult DMPunjab()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "DMPunjab").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult DMBathery()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "DMBathery").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult DMChanda()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "DMChanda").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult CSJB()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "CSJB").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult LSDP()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "LSDP").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult Pushpavani()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "Pushpavani").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult KudumbaJyothis()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "KudumbaJyothis").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult MalankaraVilakku()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "MalankaraVilakku").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult MajorAthibhadrasan()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "MajorAthibhadrasan").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult GirideepamTLA()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "GirideepamTLA").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult DiocesanBulletinMTM()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "DiocesanBulletinMTM").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult AmalaVoiceMVK()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "AmalaVoiceMVK").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult BatheryRoopathBullettin()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "BatheryRoopathBullettin").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult MalankaraVoiceDelhi()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "MalankaraVoiceDelhi").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult FMM()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "FMM").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult NavajeevanProvince()
        {
            List<Eparchy> eparchy = db.Eparchies.Where(x => x.Field4 == "NavajeevanProvince").ToList();
            return View(eparchy[0]);
        }
        public ActionResult NavajyothyProvince()
        {
            List<Eparchy> eparchy = db.Eparchies.Where(x => x.Field4 == "NavajyothyProvince").ToList();
            return View(eparchy[0]);
        }

        public ActionResult KristiyaSanyasaSamajam()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "KristiyaSanyasaSamajam").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }

        public ActionResult DisciplesofDivineSavior()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "DisciplesofDivineSavior").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult OrderofCisterciansoftheStrict()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "OrderofCisterciansoftheStrict").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult MalankaraBulletin()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "MalankaraBulletin").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult PastoralLetters()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "PastoralLetters").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult Lectionary()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "Lectionary").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult SuviseshaSangam()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "SuviseshaSangam").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult TheEphremite()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "TheEphremite").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult IvanianVoice()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "IvanianVoice").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult SanthomVoice()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "SanthomVoice").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult Girinadam()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "Girinadam").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult Vimalanadam()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "Vimalanadam").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult ShanthiVani()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "ShanthiVani").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
        public ActionResult Exodus()
        {
            List<Article> home = db.Articles.Where(x => x.Title == "Exodus").ToList();
            if (home.Count > 0)
            {
                ViewBag.Content = home[0].Content;
            }
            return View();
        }
    }
}
