using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TempForCats2.Models
{
    public class RecentDateItemModel
    {
        static public int num = 1;
        
        public string text { get; set; }
        public string URL { get; set; }
        public DateTime Date { get; set; }

        public RecentDateItemModel()
        {
            text = "Text "+num++;
            URL = "URL";
            Date = DateTime.Now;
        }
    }
}