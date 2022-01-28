using ActiveDispatchProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ActiveDispatchProject.Data.Configuration
{
    public class DispatchStatusConfiguration : IEntityTypeConfiguration<DispatchStatus>
    {
        public void Configure(EntityTypeBuilder<DispatchStatus> builder)
        {
            builder.ToTable("DispatchStatus");
            builder.HasKey(d => d.IdDispatchStatus);

            builder.Property(d => d.IdDispatchStatus).HasColumnName("IdDispatchStatus").IsRequired();
            builder.Property(d => d.StatusName).HasColumnName("StatusName").HasMaxLength(50).IsRequired();
            builder.Property(d => d.Description).HasColumnName("Description").HasMaxLength(50).IsRequired();
            builder.Property(d => d.CreatedAt).HasColumnName("CreatedAt").IsRequired();
        }
    }
}
