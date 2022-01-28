using ActiveDispatchProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ActiveDispatchProject.Data.Configuration
{
    public class BatchConfiguration : IEntityTypeConfiguration<Batch>
    {
        public void Configure(EntityTypeBuilder<Batch> builder)
        {
            builder.ToTable("Batch");
            builder.HasKey(b => b.IdBatch);

            builder.Property(b => b.IdBatch).HasColumnName("IdBatch").IsRequired();
            builder.Property(b => b.BatchNumber).HasColumnName("BatchNumber").IsRequired();
            builder.Property(b => b.Amount).HasColumnName("Amount").IsRequired();
            builder.Property(b => b.SchedulingDate).HasColumnName("SchedulingDate").IsRequired();
            builder.Property(b => b.Sent).HasColumnName("Sent").IsRequired();
            builder.Property(b => b.CreatedAt).HasColumnName("CreatedAt").IsRequired();

            builder.Property(b => b.FkCampaign).HasColumnName("FkCampaign").IsRequired();
            builder.Property(b => b.FkDispatch).HasColumnName("FkDispatch").IsRequired();

            builder.HasOne<Campaign>(b => b.Campaign)
                .WithMany(c => c.Batches)
                .HasForeignKey(b => b.FkCampaign);

            builder.HasOne<Dispatch>(b => b.Dispatch)
                .WithMany(d => d.Batches)
                .HasForeignKey(b => b.FkDispatch);
        }
    }
}
