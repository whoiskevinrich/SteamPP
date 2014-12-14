using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamPP.Core.Domain.UserStatsResponse
{
    public class Achievement
    {
        /// <summary>
        /// The API name of the achievement
        /// </summary>
        public string ApiName { get; set; }

        /// <summary>
        /// Whether or not the achievement has been completed
        /// </summary>
        public int Achieved { get; set; }

        /// <summary>
        /// Localized achievement name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Localized description of the achievement
        /// </summary>
        public string Description { get; set; }
    }

}
