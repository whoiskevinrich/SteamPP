using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamPP.Core.Domain.NewsResponse
{
    public class NewsItem
    {
        public string Gid { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public bool IsExternalUrl { get; set; }
        public string Author { get; set; }
        public string Contents { get; set; }
        public string FeedLabel { get; set; }
        public int Date { get; set; }
        public string FeedName { get; set; }
    }
}
