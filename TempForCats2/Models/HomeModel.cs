﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TempForCats2.Models
{
    public class HomeModel : ArticleModel
    {
        public HomeModel() {
            Article = new ArticleModel();
        }

        public ArticleModel Article { get; set; }

    }
}