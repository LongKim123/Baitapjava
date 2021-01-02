using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tuan3.Models;
namespace tuan3.Controllers
{
    public class MenuController : Controller
    {
        Tuan3Entities db = new Tuan3Entities();
        // GET: Menu
        public ActionResult Index()
        {
            var menus = db.Menus;
            return PartialView(menus);
        }
    }
}