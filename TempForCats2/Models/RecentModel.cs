using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TempForCats2.Models
{
    public class RecentModel
    {
        public RecentModel() {
            RecentPosts = new RecentDateModel();
            RecentComment = new RecentDateModel();
        }

        public RecentDateModel RecentPosts { get; set; }
        public RecentDateModel RecentComment { get; set; }
    }
}