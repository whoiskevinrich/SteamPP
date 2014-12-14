using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamPP.Core.Domain.NewsResponse
{
    public class AppNews
    {
        public string AppId { get; set; }
        public ICollection<NewsItem> NewsItems { get; set; }
    }



}
