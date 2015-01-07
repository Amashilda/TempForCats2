using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TempForCats2.Models;

namespace TempForCats2.Controllers
{
    public class ArticleController : Controller
    {
        //
        // GET: /Article/

        public ActionResult Recent()
        {
            var model = new RecentDateModel();
            return View(model);
        }

    }
}
