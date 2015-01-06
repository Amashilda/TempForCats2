using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TempForCats2.Models
{
    public class HomeModel
    {
        public HomeModel() {
            Article = new ArticleModel();
            RecentPosts = new RecentDateModel();
            RecentComment = new RecentDateModel();
        }

        public ArticleModel Article { get; set; }
        public RecentDateModel RecentPosts { get; set; }
        public RecentDateModel RecentComment { get; set; }
    }
}