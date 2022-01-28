using ActiveDispatchProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ActiveDispatchProject.Data.Configuration
{
    public class CampaignDayConfiguration : IEntityTypeConfiguration<CampaignDay>
    {
        public void Configure(EntityTypeBuilder<CampaignDay> builder)
        {
            builder.ToTable("CampaignDay");
            builder.HasKey(c => c.IdCampaignDay);

            builder.Property(c => c.IdCampaignDay).HasColumnName("IdCampaignDay").IsRequired();
            builder.Property(c => c.WeekdayNumber).HasColumnName("WeekdayNumber").IsRequired();
            builder.Property(c => c.CreatedAt).HasColumnName("CreatedAt").IsRequired();

            builder.Property(c => c.FkCampaign).HasColumnName("FkCampaign").IsRequired();

            builder.HasOne<Campaign>(cd => cd.Campaign)
                .WithMany(ca => ca.CampaignDays)
                .HasForeignKey(cd => cd.FkCampaign);
        }
    }
}
