using GoLogs.Interfaces;

// ReSharper disable CheckNamespace
// ReSharper disable InconsistentNaming
namespace GoLogs.Events
{
    public interface IDOOrderEvent
    {
        IDOOrder DOOrder { get; }
    }
}