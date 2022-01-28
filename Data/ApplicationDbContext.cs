using ActiveDispatchProject.Data.Configuration;
using ActiveDispatchProject.Models;
using Microsoft.EntityFrameworkCore;

namespace ActiveDispatchProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Batch> Batches { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<CampaignUser> CampaignUsers { get; set; }
        public DbSet<CampaignDay> CampaignDays { get; set; }
        public DbSet<Dispatch> Dispatches { get; set; }
        public DbSet<DispatchStatus> DispatchStatus { get; set; }
        public DbSet<Template> Templates { get; set; }

        public ApplicationDbContext(DbContextOptions op) : base(op)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BatchConfiguration());
            modelBuilder.ApplyConfiguration(new CampaignConfiguration());
            modelBuilder.ApplyConfiguration(new CampaignDayConfiguration());
            modelBuilder.ApplyConfiguration(new CampaignUserConfiguration());
            modelBuilder.ApplyConfiguration(new DispatchConfiguration());
            modelBuilder.ApplyConfiguration(new DispatchStatusConfiguration());
            modelBuilder.ApplyConfiguration(new TemplateConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
