﻿using Microservice.Core.Events;
using System;

namespace Microservice.Core.Commands
{
    public abstract class Command:Message
    {
        public DateTime Timestamp { get; protected set; }
        protected Command()
        {
            Timestamp = DateTime.Now;
        }
    }
}
