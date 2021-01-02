using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tuan3.Models;
namespace tuan3.Controllers
{
    public class BannerController : Controller
    {
        Tuan3Entities db = new Tuan3Entities();
        // GET: Banner
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HeaderBanner()
        {
            var headerBanner = db.Banners.Where(c => c.Name == "Header").FirstOrDefault();
            return PartialView(headerBanner);
        }
        public ActionResult LeftBanner()
        {
            var leftBanner = db.Banners.Where(c => c.Name == "Left").FirstOrDefault();
            return PartialView(leftBanner);
        }
        public ActionResult RightBanner()
        {
            var rightBanner = db.Banners.Where(c => c.Name == "Right").FirstOrDefault();
            return PartialView(rightBanner);
        }
    }
}