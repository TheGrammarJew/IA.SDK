﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA.SDK.Interfaces
{
    public interface IDiscordGuild : IDiscordEntity
    {
        Task<IDiscordUser> GetUserAsync(ulong user_id);
        Task<IDiscordChannel> GetDefaultChannel();
    }
}
