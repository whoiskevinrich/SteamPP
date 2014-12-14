using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamPP.Core.Domain.UserResponse
{
    public class Friend
    {
        public string SteamId { get; set; }
        public string Relationship { get; set; }
        public int FriendSince { get; set; }
    }
}
