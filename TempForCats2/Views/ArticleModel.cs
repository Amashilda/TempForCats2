using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TempForCats2.Views
{
    public class ArticleModel
    {
        public ArticleModel() { 
            Title = "The title sdhi;fbasvbs;bkdvb;sb";
            Body = "aefgpaewbfiewaugf ewifgbapwiefbwaei gweifgaiwebfiawf";
            Date = DateTime.Now;
        
        }


        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime Date { get; set; }

        public ICollection<CommentItemModel> Comments { get; set; }
    }
}