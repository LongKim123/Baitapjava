using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tuan4.Models;
namespace tuan4.Controllers
{
    public class LaptopController : Controller
    {
        TMDT5Entities db = new TMDT5Entities();
        // GET: Laptop
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult getCompany()
        {
            var ListCompany = db.laptops.GroupBy(l => l.Company).Select(l => l.Key);
            return PartialView(ListCompany);
        }
        public ActionResult getCPU()
        {
            var ListCPU = db.laptops.GroupBy(l => l.Cpu).Select(l => l.Key);
            return PartialView(ListCPU);
        }
        public ActionResult getTypename()
        {
            var ListType = db.laptops.GroupBy(l => l.TypeName).Select(l => l.Key);
            return PartialView(ListType);
        }
        public ActionResult getInches()
        {
            var List1 = db.laptops.GroupBy(l => l.Inches).Select(l => l.Key);
            return PartialView(List1);
        }
        public ActionResult getScreenResolution()
        {
            var List2 = db.laptops.GroupBy(l => l.ScreenResolution).Select(l => l.Key);
            return PartialView(List2);
        }
        public ActionResult getMemory()
        {
            var List3 = db.laptops.GroupBy(l => l.Memory).Select(l => l.Key);
            return PartialView(List3);
        }
        public ActionResult getGPU()
        {
            var List4 = db.laptops.GroupBy(l => l.Gpu).Select(l => l.Key);
            return PartialView(List4);
        }
        public ActionResult getOS()
        {
            var List5 = db.laptops.GroupBy(l => l.OpSys).Select(l => l.Key);
            return PartialView(List5);
        }


    }
}