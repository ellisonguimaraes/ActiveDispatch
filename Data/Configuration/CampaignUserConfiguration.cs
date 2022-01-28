using ActiveDispatchProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ActiveDispatchProject.Data.Configuration
{
    public class CampaignUserConfiguration : IEntityTypeConfiguration<CampaignUser>
    {
        public void Configure(EntityTypeBuilder<CampaignUser> builder)
        {
            builder.ToTable("CampaignUser");
            builder.HasKey(c => c.IdCampaignUser);

            builder.Property(c => c.IdCampaignUser).HasColumnName("IdCampaignUser").IsRequired();
            builder.Property(c => c.Email).HasColumnName("Email").IsRequired();
            builder.Property(c => c.CreatedAt).HasColumnName("CreatedAt").IsRequired();

            builder.Property(c => c.FkCampaign).HasColumnName("FkCampaign").IsRequired();

            builder.HasOne<Campaign>(cu => cu.Campaign)
                .WithMany(ca => ca.CampaignUsers)
                .HasForeignKey(cu => cu.FkCampaign);
        }
    }
}
