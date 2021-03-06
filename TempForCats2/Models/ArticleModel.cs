﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace TempForCats2.Models
{
    public class ArticleModel
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime Date { get; set; }
        
        public ArticleModel()
        {
            Title = "The title sdhi;fbasvbs;bkdvb;sb";
            Body = "aefgpaewbfiewaugf ewifgbapwiefbwaei gweifgaiwebfiawf";
            Date = DateTime.Now;

            Comments = new Collection<CommentItemModel>();
        }
        
        public ICollection<CommentItemModel> Comments { get; set; }
    }
}