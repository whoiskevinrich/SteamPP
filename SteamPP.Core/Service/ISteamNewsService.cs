using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SteamPP.Core.Domain.NewsResponse;

namespace SteamPP.Core.Service
{
    public interface ISteamNewsService
    {
        AppNews GetAppNews(string appId, int count, int maxLength);
    }
}
