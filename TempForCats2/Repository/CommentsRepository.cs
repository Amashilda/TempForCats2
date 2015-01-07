using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TempForCats2.Repository
{
    public static class CommentsRepository
    {
        public static ICollection<string> Comments = new Collection<string>();
    }
}