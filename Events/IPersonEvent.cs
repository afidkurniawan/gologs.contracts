using GoLogs.Interfaces;

// ReSharper disable CheckNamespace
namespace GoLogs.Events
{
    public interface IPersonEvent
    {
        IPerson Person { get; }
    }
}