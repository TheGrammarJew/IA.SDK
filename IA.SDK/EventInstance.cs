﻿using System;

namespace IA.SDK
{
    public class EventInstance
    {
        public string name = "name not set";
        public string[] aliases = new string[0];

        public string description = "description not set for this command!";
        public string[] usage = new string[] { "usage not set!" };
        public string errorMessage = "Something went wrong!";

        public bool canBeOverridenByDefaultPrefix = false;
        public bool canBeDisabled = true;
        public bool defaultEnabled = true;

        public ModuleInstance module = new ModuleInstance("");

        public EventAccessibility accessibility = EventAccessibility.PUBLIC;

        public EventInstance()
        {

        }
        public EventInstance(Action<EventInstance> info)
        {
            info.Invoke(this);
        }
    }
}
