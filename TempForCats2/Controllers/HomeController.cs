using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TempForCats2.Models;

namespace TempForCats2.Controllers
{
    public class HomeController : Controller
    {

        public RedirectToRouteResult Index()
        {
            return RedirectToAction("MainPost");
        }


        public ActionResult MainPost()
        {
            var model = new HomeModel();
            return View(model);
        }

        public ActionResult AllPosts(HomeModel model)
        {
            return View(model);
        }

        public ActionResult AboutCat()
        {
            return View();
        }
        public ActionResult Contacts()
        {
            return View();
        }


        public ActionResult Side()
        {
            var model = new RecentModel();
            return View(model);
        }


    }
}
