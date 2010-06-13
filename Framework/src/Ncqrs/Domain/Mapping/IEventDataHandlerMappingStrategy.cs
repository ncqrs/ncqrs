﻿using System;
using System.Collections.Generic;
using Ncqrs.Eventing;

namespace Ncqrs.Domain.Mapping
{
    public interface IEventDataHandlerMappingStrategy
    {
        IEnumerable<IEventHandler<IEvent>> GetEventHandlersFromAggregateRoot(IEventSource eventSource);
    }
}