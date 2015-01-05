using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TempForCats2.Views
{
    public class RecentDateItemModel
    {

            public RecentDateItemModel()
        {
            text = "TextTextText";
            URL = "Comment Comment";
            Date = DateTime.Now;
        }

        public string text { get; set; }
        public string URL { get; set; }
        public DateTime Date { get; set; }

    }
}