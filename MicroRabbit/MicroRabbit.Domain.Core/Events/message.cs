using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Domain.Core.Events
{
    public abstract class message : IRequest<bool>
    {
        public string MessageType { get; protected set; }
        protected message()
        {
            MessageType = GetType().Name;
        }
    }
}
