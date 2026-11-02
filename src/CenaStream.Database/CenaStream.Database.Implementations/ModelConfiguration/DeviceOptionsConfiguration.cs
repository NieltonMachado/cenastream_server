using CenaStream.Database.Implementations.Entities.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CenaStream.Database.Implementations.ModelConfiguration
{
    /// <summary>
    /// FluentAPI configuration for the DeviceOptions entity.
    /// </summary>
    public class DeviceOptionsConfiguration : IEntityTypeConfiguration<DeviceOptions>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<DeviceOptions> builder)
        {
            builder
                .HasIndex(entity => entity.DeviceId)
                .IsUnique();
        }
    }
}
