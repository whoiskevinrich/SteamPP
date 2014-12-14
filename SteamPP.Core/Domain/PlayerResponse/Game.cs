using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamPP.Core.Domain.PlayerResponse
{
    public class Game
    {
        /// <summary>
        /// Unique identifier for the game returned
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// Total number of minutes played "on record", since Steam began tracking total playtime in early 2009
        /// </summary>
        public int PlayTimeForever { get; set; }

        /// <summary>
        /// Total number of minutes played in the last two weeks.
        /// </summary>
        public int PlayTime2Weeks { get; set; }
    }
}
