using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SteamPP.Core.Domain.PlayerResponse;

namespace SteamPP.Core.Service
{
    public interface ISteamPlayerService
    {
        GamesResponse<Game> GetOwnedGames(string steamId, IEnumerable<string> appIdsFilter, bool includeAppInfo = false,
            bool includePlayedFreeGames = false);

        GamesResponse<RecentlyPlayedGame> GetRecentlyPlayedGames(string steamId, int? count = null);

        string GetOwnerOfSharedGame(string steamId, string appId);
    }
}
