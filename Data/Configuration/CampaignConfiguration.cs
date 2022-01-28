using ActiveDispatchProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ActiveDispatchProject.Data.Configuration
{
    public class CampaignConfiguration : IEntityTypeConfiguration<Campaign>
    {
        public void Configure(EntityTypeBuilder<Campaign> builder)
        {
            builder.ToTable("Campaign");
            builder.HasKey(c => c.IdCampaign);

            builder.Property(c => c.IdCampaign).HasColumnName("IdCampaign").IsRequired();
            builder.Property(c => c.CampaignName).HasColumnName("CampaignName").HasMaxLength(50).IsRequired();
            builder.Property(c => c.CampaignKey).HasColumnName("CampaignKey").HasMaxLength(50).IsRequired();
            builder.Property(c => c.DailyLimit).HasColumnName("DailyLimit").IsRequired();
            builder.Property(c => c.BotIdentifier).HasColumnName("BotIdentifier").HasMaxLength(50).IsRequired();
            builder.Property(c => c.FlowIdentifier).HasColumnName("FlowIdentifier").HasMaxLength(50);
            builder.Property(c => c.StateId).HasColumnName("StateId").HasMaxLength(50);
            builder.Property(c => c.StartDate).HasColumnName("StartDate").IsRequired();
            builder.Property(c => c.EndDate).HasColumnName("EndDate").IsRequired();
            builder.Property(c => c.StartHour).HasColumnName("StartHour").IsRequired();
            builder.Property(c => c.EndHour).HasColumnName("EndHour").IsRequired();
            builder.Property(c => c.Active).HasColumnName("Active").IsRequired();
            builder.Property(c => c.CreatedAt).HasColumnName("CreatedAt").IsRequired();
            builder.Property(c => c.UpdatedAt).HasColumnName("UpdatedAt");
        }
    }
}
