using System.Collections.Generic;
using System.Linq;

namespace SteamPP.Core.Domain.UserStatsResponse
{
    public class PlayerAchievements
    {
        /// <summary>
        /// Steam ID (Player) whose information is being returned
        /// </summary>
        public string SteamId { get; set; }
        
        /// <summary>
        /// The name of the game achievements have been earned for
        /// </summary>
        public string GameName { get; set; }

        /// <summary>
        /// Achievemnets earned for this game
        /// </summary>
        public ICollection<Achievement> Achievements { get; set; }
        
        
        public bool Success { get; set; }
    }
}