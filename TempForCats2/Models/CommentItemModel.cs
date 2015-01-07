using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TempForCats2.Models
{
    public class CommentItemModel
    {
        public string Username { get; set; }
        public string Body { get; set; }
        public DateTime Date { get; set; }
        
        public CommentItemModel()
        {
            Username = "Barsik";
            Body = "Comment Comment Comment";
            Date = DateTime.Now;
        }
    }
}