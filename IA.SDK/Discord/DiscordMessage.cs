﻿using IA.SDK.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IA.SDK
{
    public class DiscordMessage : IDiscordMessage
    {
        public virtual ulong Id
        {
            get
            {
                return 0;
            }
        }

        public virtual IDiscordUser Author
        {
            get
            {
                return null;
            }
        }

        public virtual IDiscordUser Bot
        {
            get
            {
                return null;
            }
        }

        public virtual IDiscordGuild Guild
        {
            get
            {
                return null;
            }
        }

        public virtual string Content
        {
            get
            {
                return "";
            }
        }

        public virtual DateTimeOffset Timestamp
        {
            get
            {
                return new DateTime(0);
            }
        }

        public virtual IReadOnlyCollection<ulong> MentionedUserIds
        {
            get
            {
                return null;
            }
        }

        public virtual IReadOnlyCollection<ulong> MentionedRoleIds
        {
            get
            {
                return null;
            }
        }

        public int ShardId
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IDiscordClient Discord
        {
            get
            {
                return null;
            }
        }

        private IDiscordMessageChannel Channel
        {
            get
            {
                return null;
            }
        }

        public IDiscordAudioChannel VoiceChannel
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        IDiscordMessageChannel IDiscordMessage.Channel
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public virtual async Task DeleteAsync()
        {
            await Task.CompletedTask;
            throw new NotImplementedException();
        }

        public virtual async Task ModifyAsync(string message)
        {
            await Task.CompletedTask;
            throw new NotImplementedException();
        }

        public virtual async Task PinAsync()
        {
            await Task.CompletedTask;
            throw new NotImplementedException();
        }

        public virtual async Task UnpinAsync()
        {
            await Task.CompletedTask;
            throw new NotImplementedException();
        }

        public virtual IDiscordEmbed CreateEmbed()
        {
            throw new NotImplementedException();
        }
    }
}