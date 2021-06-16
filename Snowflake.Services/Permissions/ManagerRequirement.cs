﻿using System;
using Snowflake.Services.Enums;
using Microsoft.AspNetCore.Authorization;

namespace Snowflake.Services.Permissions
{
    public class ManagerRequirement : IAuthorizationRequirement
    {
        public LevelEnum UserLevel { get; set; }

        public ManagerRequirement(LevelEnum userLevel)
        {
            UserLevel = userLevel;
        }
    }
}
