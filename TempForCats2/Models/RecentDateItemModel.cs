using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TempForCats2.Models
{
    public class RecentDateItemModel
    {
        static public int num = 1;
        public RecentDateItemModel()
        {
            text = "TextTextText "+num++;
            URL = "Comment Comment";
            Date = DateTime.Now;
        }

        public string text { get; set; }
        public string URL { get; set; }
        public DateTime Date { get; set; }

    }
}