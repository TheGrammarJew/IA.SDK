﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA.SDK
{
    public class CommandEvent : EventInstance
    {
        public int cooldown = 1;

        public DiscordGuildPermission[] requiresPermissions = new DiscordGuildPermission[0];

        public CheckCommand checkCommand = null;

        public ProcessCommand processCommand = null;

        public CommandEvent(Action<CommandEvent> info) { 
            info.Invoke(this);
        }
    }
}
