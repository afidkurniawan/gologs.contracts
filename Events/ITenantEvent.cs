using GoLogs.Interfaces;

// ReSharper disable CheckNamespace
namespace GoLogs.Events
{
    public interface ITenantEvent
    {
        ITenant Tenant { get; }
    }
}