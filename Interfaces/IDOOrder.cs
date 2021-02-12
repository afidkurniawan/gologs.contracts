using System;

// ReSharper disable CheckNamespace
namespace GoLogs.Interfaces
{
    // ReSharper disable once InconsistentNaming
    public interface IDOOrder :  IEntity
    {
        /// <summary>
        ///     Universally unique identifier of this <see cref="IDOOrder"/>.
        
        string DOOrderNumber { get; }
        /// <summary>
        /// Cargo Owner Id who request DO Order
        /// </summary>
        int CargoOwnerId { get;  }
    }
}