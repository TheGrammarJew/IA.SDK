﻿using IA.SDK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA.SDK
{
    public class DiscordAudioClient : IDiscordAudioClient
    {
        public virtual Queue<IAudio> AudioQueue
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public virtual bool IsPlaying
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public virtual Task Connect()
        {
            throw new NotImplementedException();
        }

        public virtual Task Disconnect()
        {
            throw new NotImplementedException();
        }

        public virtual Task Pause()
        {
            throw new NotImplementedException();
        }

        public virtual Task Play(IAudio audio, bool skipIfPlaying = false)
        {
            throw new NotImplementedException();
        }

        public virtual Task Skip()
        {
            throw new NotImplementedException();
        }
    }
}
