﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamPP.Core.Domain.UserResponse
{
    public class Player
    {
        public string SteamId { get; set; }
        public int CommunityVisibilityState { get; set; }
        public int ProfileState { get; set; }
        public string PersonaName { get; set; }
        public int LastLogoff { get; set; }
        public string ProfileUrl { get; set; }
        public string Avatar { get; set; }
        public string AvatarMedium { get; set; }
        public string AvatarFull { get; set; }
        public int PersonaState { get; set; }
        public string RealName { get; set; }
        public string PrimaryClanId { get; set; }
        public int TimeCreated { get; set; }
        public int PersonaStateFlags { get; set; }
        public string LocCountryCode { get; set; }
        public string LocStateCode { get; set; }

    }
}
