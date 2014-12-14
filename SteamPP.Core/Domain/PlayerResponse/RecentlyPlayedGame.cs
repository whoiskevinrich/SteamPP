using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamPP.Core.Domain.PlayerResponse
{
    public class RecentlyPlayedGame : Game
    {
        /// <summary>
        /// The name of the game
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// filename of image icon URL is constructed by using http://media.steampowered.com/steamcommunity/public/images/apps/{appid}/{hash}.jpg
        /// </summary>
        public string ImgIconUrl { get; set; }

        /// <summary>
        /// filename of image logo URL is constructed by using http://media.steampowered.com/steamcommunity/public/images/apps/{appid}/{hash}.jpg
        /// </summary>
        public string ImgLogoUrl { get; set; }
    }
}
