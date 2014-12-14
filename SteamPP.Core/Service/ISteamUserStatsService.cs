using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SteamPP.Core.Domain.UserStatsResponse;

namespace SteamPP.Core.Service
{
    public interface ISteamUserStatsService
    {
        ICollection<AchievementProgress> GetAchievementPercentages(string gameId);
        PlayerAchievements GetPlayerAchievements(string steamId, string appId, string language = null);
        PlayerAchievements GetUserStatsForGame(string steamId, string appId, string language = null);
    }
}
