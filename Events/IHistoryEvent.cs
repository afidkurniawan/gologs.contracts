using GoLogs.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoLogs.Contracts.Events
{
    public interface IHistoryEvent
    {
        IHistory History { get; }
    }
}
