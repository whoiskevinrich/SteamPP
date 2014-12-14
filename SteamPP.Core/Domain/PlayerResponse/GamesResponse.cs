using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamPP.Core.Domain.PlayerResponse
{
    public class GamesResponse<T>
    {
        public ICollection<T> Games { get; set; }
    }
}
