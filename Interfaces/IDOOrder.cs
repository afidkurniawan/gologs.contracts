using System;

// ReSharper disable CheckNamespace
namespace GoLogs.Interfaces
{
    // ReSharper disable once InconsistentNaming
    public interface IDOOrder : IEntity
    {
        /// <summary>
        ///     Universally unique identifier of this <see cref="IDOOrder"/>.
        /// </summary>
        Guid? Uuid { get; }
        
        /// <summary>
        ///     The BL number for this delivery order.
        /// </summary>
        string BlNumber { get; }
        
        /// <summary>
        ///     The BL date for this delivery order.
        /// </summary>
        DateTime BlDate { get; }
    }
}