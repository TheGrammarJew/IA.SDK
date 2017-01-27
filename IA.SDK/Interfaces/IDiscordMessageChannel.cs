﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA.SDK.Interfaces
{
    public interface IDiscordMessageChannel : IDiscordChannel
    {

        Task DeleteMessagesAsync(List<IDiscordMessage> messages);

        Task<List<IDiscordMessage>> GetMessagesAsync(int amount = 100);

        Task<IDiscordMessage> SendFileAsync(string path);
        Task<IDiscordMessage> SendFileAsync(MemoryStream stream, string extension);

        Task<IDiscordMessage> SendMessage(string message);
        Task<IDiscordMessage> SendMessage(IDiscordEmbed embed);
    }
}