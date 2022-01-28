using ActiveDispatchProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ActiveDispatchProject.Data.Configuration
{
    public class DispatchConfiguration : IEntityTypeConfiguration<Dispatch>
    {
        public void Configure(EntityTypeBuilder<Dispatch> builder)
        {
            builder.ToTable("Dispatch");
            builder.HasKey(d => d.IdDispatch);

            builder.Property(d => d.IdDispatch).HasColumnName("IdDispatch").IsRequired();
            builder.Property(d => d.TemplateName).HasColumnName("TemplateName").HasMaxLength(50).IsRequired();
            builder.Property(d => d.CurrentBatch).HasColumnName("CurrentBatch").IsRequired();
            builder.Property(d => d.TotalBatches).HasColumnName("TotalBatches").IsRequired();
            builder.Property(d => d.AwaitingCount).HasColumnName("AwaitingCount").IsRequired();
            builder.Property(d => d.SentCount).HasColumnName("SentCount").IsRequired();
            builder.Property(d => d.ReceivedCount).HasColumnName("ReceivedCount").IsRequired();
            builder.Property(d => d.ViewedCount).HasColumnName("ViewedCount").IsRequired();
            builder.Property(d => d.FailedCount).HasColumnName("FailedCount").IsRequired();
            builder.Property(d => d.StartDate).HasColumnName("StartDate").IsRequired();
            builder.Property(d => d.EndDate).HasColumnName("EndDate").IsRequired();
            builder.Property(d => d.Active).HasColumnName("Active").IsRequired();
            builder.Property(d => d.CreatedAt).HasColumnName("CreatedAt").IsRequired();
            builder.Property(d => d.UpdatedAt).HasColumnName("UpdatedAt");

            builder.Property(d => d.FkCampaign).HasColumnName("FkCampaign").IsRequired();
            builder.Property(d => d.FkUser).HasColumnName("FkUser");
            builder.Property(d => d.FkDispatchStatus).HasColumnName("FkDispatchStatus").IsRequired();

            builder.HasOne<Campaign>(d => d.Campaign)
                .WithMany(ca => ca.Dispatches)
                .HasForeignKey(d => d.FkCampaign);

            builder.HasOne<CampaignUser>(d => d.CampaignUser)
                .WithMany(cu => cu.Dispatches)
                .HasForeignKey(d => d.FkUser);

            builder.HasOne<DispatchStatus>(d => d.DispatchStatus)
                .WithMany(ds => ds.Dispatches)
                .HasForeignKey(d => d.FkDispatchStatus);
        }
    }
}
