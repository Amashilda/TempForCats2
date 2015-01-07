using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;


namespace TempForCats2.Models
{
    public class RecentDateModel
    {
        public ICollection<RecentDateItemModel> Items { get; set; }

        public RecentDateModel()
        {
            Items = new Collection<RecentDateItemModel>();
            Items.Add(new RecentDateItemModel());
        }
    }
}