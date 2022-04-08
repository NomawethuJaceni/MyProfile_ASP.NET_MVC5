using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyProfile.Controllers
{
    public class HomeController : Controller
    {
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
        public ActionResult Portfolio()
        {
            ViewBag.Message = "Your Portfolio page.";

            return View();
        }
        public ActionResult Skills()
        {
            ViewBag.Message = "Your Skills page.";

            return View();
        }

        public ActionResult Experiences()
        {
            ViewBag.Message = "Your Experiences page.";

            return View();
        }

    }
}