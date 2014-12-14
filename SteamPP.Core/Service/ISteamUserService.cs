using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SteamPP.Core.Domain.UserResponse;

namespace SteamPP.Core.Service
{
    public interface ISteamUserService
    {
        ICollection<Player> GetPlayerSummaries(IEnumerable<string> steamIds);

        ICollection<Friend> GetFriendList(IEnumerable<string> steamId,
            RelationshipFilterTypes filter = RelationshipFilterTypes.None);
    }
}
