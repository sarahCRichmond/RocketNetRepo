using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RocketNet.Controllers
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

        public ActionResult Pokes()
        {
            ViewBag.Message = "List of Pokemon";

            return View();
        }

        public ActionResult Logout()
        {
            ViewBag.Message = "Logged out";

            return View();
        }

        public ActionResult Account()
        {
            ViewBag.Message = "Account page";

            return View();
        }

        public ActionResult Wishlist()
        {
            ViewBag.Message = "Wishlist page";

            return View();
        }
    }
}