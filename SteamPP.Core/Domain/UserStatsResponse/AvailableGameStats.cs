using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamPP.Core.Domain.UserStatsResponse
{
    public class AvailableGameStats
    {
        public ICollection<AchievementSchema> AchievementSchemata { get; set; }
    }
}
