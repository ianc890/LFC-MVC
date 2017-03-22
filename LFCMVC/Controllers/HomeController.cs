using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LFCMVC.Controllers
{
    public class HomeController : Controller
    {

        [OutputCache(Duration=30, VaryByParam="*")]
        public ActionResult Index()
        {
            ViewBag.Time = System.DateTime.Now.ToString();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}