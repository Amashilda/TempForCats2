using System.Collections.Generic;
using System.Collections.ObjectModel;
using TempForCats2.Models;

namespace TempForCats2.Repository
{
    public static class Recent
    {
        private static ICollection<RecentDateItemModel> Comments = new Collection<RecentDateItemModel>();
        public static ICollection<RecentDateItemModel> Posts = new Collection<RecentDateItemModel>();
    }
    public class GetRecentPosts
    {
        public ICollection<RecentDateItemModel> GetCollection()
        {
            if (Recent.Posts.Count == 0)
                Recent.Posts.Add(new RecentDateItemModel());
            return Recent.Posts;
        }
    }
}