using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SAROJ_SEVA_SANSTHAN.Controllers
{
    public class HomeHiController : Controller
    {
        // GET: HomeHi
        public ActionResult Index()
        {
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
        public ActionResult Vision()
        {
            return View();
        }
        public ActionResult Mission()
        {
            return View();
        }
        public ActionResult Gallery()
        {
            return View();
        }
        public ActionResult Invitation()
        {
            return View();
        }
        public ActionResult Facility()
        {
            return View();
        }
        public ActionResult Enquiry()
        {
            return View();
        }
    }
}