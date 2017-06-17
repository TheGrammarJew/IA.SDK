﻿using System;
using System.Threading.Tasks;

namespace Meru.SDK.Interfaces
{
    public interface IDiscordEmbed
    {
        IEmbedAuthor Author { get; set; }
        Color Color { get; set; }
        string Description { get; set; }
        IEmbedFooter Footer { get; set; }
        string ImageUrl { get; set; }
        string ThumbnailUrl { get; set; }
        string Title { get; set; }
        string Url { get; set; }

        IDiscordEmbed AddField(string title, string value);
        IDiscordEmbed AddField(IEmbedField field);
        IDiscordEmbed AddField(Action<IEmbedField> field);

        IDiscordEmbed AddInlineField(string title, string value);

        IEmbedAuthor CreateAuthor();
        IDiscordEmbed CreateAuthor(string text, string iconUrl, string url);

        IEmbedFooter CreateFooter();
        IDiscordEmbed CreateFooter(string text, string iconUrl);

        IDiscordEmbed SetAuthor(string name, string imageurl, string url);

        IDiscordEmbed SetColor(Color color);
        IDiscordEmbed SetColor(float r, float g, float b);

        IDiscordEmbed SetDescription(string description);
        IDiscordEmbed SetFooter(string text, string iconurl); 
        IDiscordEmbed SetImageUrl(string url);
        IDiscordEmbed SetThumbnailUrl(string url);
        IDiscordEmbed SetTitle(string title);
        IDiscordEmbed SetUrl(string url);

        Task<IDiscordMessage> SendToChannel(ulong channelId);
        Task<IDiscordMessage> SendToUser(ulong userId);
    }
}