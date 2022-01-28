using ActiveDispatchProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ActiveDispatchProject.Data.Configuration
{
    public class TemplateConfiguration : IEntityTypeConfiguration<Template>
    {
        public void Configure(EntityTypeBuilder<Template> builder)
        {
            builder.ToTable("Template");
            builder.HasKey(t => t.IdTemplate);

            builder.Property(t => t.IdTemplate).HasColumnName("IdTemplate").IsRequired();
            builder.Property(t => t.TemplateName).HasColumnName("TemplateName").HasMaxLength(50).IsRequired();
            builder.Property(t => t.CreatedAt).HasColumnName("CreatedAt").IsRequired();

            builder.Property(t => t.FkCampaign).HasColumnName("FkCampaign").IsRequired();

            builder.HasOne<Campaign>(t => t.Campaign)
                .WithMany(c => c.Templates)
                .HasForeignKey(c => c.FkCampaign);
        }
    }
}
