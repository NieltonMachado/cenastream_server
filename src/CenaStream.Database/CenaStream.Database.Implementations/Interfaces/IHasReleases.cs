using System.Collections.Generic;
using CenaStream.Database.Implementations.Entities.Libraries;

namespace CenaStream.Database.Implementations.Interfaces;

/// <summary>
/// An abstraction representing an entity that has releases.
/// </summary>
public interface IHasReleases
{
    /// <summary>
    /// Gets a collection containing this entity's releases.
    /// </summary>
    ICollection<Release> Releases { get; }
}
