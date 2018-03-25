using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RocketNet.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search

        public ActionResult Search()
        {
            return View();
        }


        // GET: /Search/Welcome
        public string Welcome(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", ID:" + ID);
        }

    }
}