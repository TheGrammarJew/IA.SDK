﻿using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace IA.SDK.Interfaces
{
    public interface IDiscordMessageChannel : IDiscordChannel
    {
        bool Nsfw { get; }

        Task DeleteMessagesAsync(List<IDiscordMessage> messages);

        Task<List<IDiscordMessage>> GetMessagesAsync(int amount = 100);

        Task<IDiscordMessage> SendFileAsync(string path);
        Task<IDiscordMessage> SendFileAsync(MemoryStream stream, string extension);

        Task SendOption(string message, IDiscordUser user, params Option[] reactionEmoji);
        Task SendOption(IDiscordEmbed embed, IDiscordUser user, params Option[] reactionEmoji);

        Task<IDiscordMessage> SendMessage(string message);
        Task<IDiscordMessage> SendMessage(IDiscordEmbed embed);

        Task SendTypingAsync();
    }
}