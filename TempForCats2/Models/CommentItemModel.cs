﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TempForCats2.Models
{
    public class CommentItemModel
    {
        public CommentItemModel()
        {
            Username = "Alex";
            Body = "Comment Comment";
            Date = DateTime.Now;
        }


        public string Username { get; set; }
        public string Body { get; set; }
        public DateTime Date { get; set; }
    }
}