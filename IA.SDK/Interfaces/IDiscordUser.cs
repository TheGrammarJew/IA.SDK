﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace IA.SDK.Interfaces
{
    public interface IDiscordUser : IDiscordEntity, IMentionable
    {
        string AvatarUrl { get; }

        bool IsBot { get; }

        string Discriminator { get; }

        IDiscordAudioChannel VoiceChannel { get; }

        IDiscordGuild Guild { get; }

        List<ulong> RoleIds { get; }

        string Username { get; }
        string Nickname { get; }

        bool HasPermissions(IDiscordChannel channel, params DiscordGuildPermission[] permissions);

        Task AddRoleAsync(IDiscordRole role);

        Task AddRolesAsync(List<IDiscordRole> roles);

        Task Ban(IDiscordGuild guild);

        Task Kick();

        Task RemoveRoleAsync(IDiscordRole role);

        Task RemoveRolesAsync(List<IDiscordRole> roles);

        Task SendFile(string path);

        Task<IDiscordMessage> SendMessage(string text);

        Task<IDiscordMessage> SendMessage(IDiscordEmbed embed);

        Task SetNickname(string text);
    }
}