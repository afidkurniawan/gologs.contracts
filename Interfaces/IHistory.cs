using System;

namespace GoLogs.Interfaces
{
    public interface IHistory :IEntity
    {
        string DOOrderNumber { get;  }
        int StateId { get; }
    }
}
