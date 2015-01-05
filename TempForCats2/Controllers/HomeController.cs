using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TempForCats2.Views;

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

        public ActionResult AllPosts()
        {
            return View();
        }


    }
}
