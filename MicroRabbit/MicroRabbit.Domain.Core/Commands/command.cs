using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Domain.Core.Commands
{
    public abstract class command : message
    {
        public DateTime Timestamp { get; protected set; }
        protected command() 
        {
            Timestamp = DateTime.Now;
}

    }
}
