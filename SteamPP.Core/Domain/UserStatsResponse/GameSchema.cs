using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamPP.Core.Domain.UserStatsResponse
{
    public class GameSchema
    {
        public string GameName { get; set; }
        public string GameVersion { get; set; }
        public AvailableGameStats AvailableGameStats { get; set; }
    }
}
