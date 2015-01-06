using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TempForCats2.Models;

namespace TempForCats2.Controllers
{
    public class LeftController : Controller
    {
        //
        // GET: /Left/

        public ActionResult Side()
        {
            var model = new RecentModel();
            return View(model);
        }

    }
}
