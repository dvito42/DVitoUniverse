using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DVitoUniverse.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Web Developer Portfolio.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact information.";

            return View();
        }

        //Added controller for Resume view
        public ActionResult Resume()
        {
            ViewBag.Message = "Resume.";

            return View();
        }


    }
}