using TempForCats2.Repository;
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
            string query = Request.QueryString["Lol"];
            var model = new ArticleModel();
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

        //public ActionResult AddComment()
        //{
        //    string comment = Request.Form["Comment"];
        //    return RedirectToAction("MainPost");
        //}

       //public ActionResult AddComment(string Comment)
       //{
       //   string comment = Request.Form["Comment"];
       //    return RedirectToAction("MainPost");
       //}

       //public ActionResult AddComment(AddCommentModel model)
       //{
       //    return RedirectToAction("MainPost");
       //}

        [HttpGet]
        public ActionResult AddComment()
        {
            string query = Request.QueryString["Lol"];
            var model = new ArticleModel();
            return View(model);
        }


        [HttpPost]
       public ActionResult AddComment(AddCommentModel model)
       {
            if (!string.IsNullOrWhiteSpace(model.Comment)){
                CommentsRepository.Comments.Add(model.Comment);
            }
            return View(new ArticleModel());
       }




    }
}
