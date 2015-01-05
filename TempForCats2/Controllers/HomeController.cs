using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TempForCats2.Controllers
{
    public class HomeController : Controller
    {

        public RedirectToRouteResult Index()
        {
            return ReturnToAction("MainPost");
        }


        public ActionResult MainPost()
        {
            return View();
        }

        public ActionResult AllPosts()
        {
            return View();
        }


    }
}
