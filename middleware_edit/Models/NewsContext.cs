using System.Collections.Generic;

namespace middleware_edit.Models
{
    public static class NewsContext
    {
        public static List<News> List = new List<News>
        {
            new News(){Title="Haber 1"},
            new News(){Title="Haber 2"},
            new News(){Title="Habar 3"},
        };
    }
}
