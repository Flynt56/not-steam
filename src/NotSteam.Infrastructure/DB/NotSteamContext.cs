using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.Extensions.NotSteamContext;
using NotSteam.Infrastructure.Extensions.ModelBuilder;
using NotSteam.Model.Models;

namespace NotSteam.Infrastructure.DB
{
    public class NotSteamContext : IdentityDbContext
    {
        public NotSteamContext(DbContextOptions<NotSteamContext> options)
            : base(options)
        { }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<GameTag> GameTags { get; set; }
        public DbSet<Library> Libraries { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(NotSteamContext).Assembly);
            modelBuilder.Seed();

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            OnBeforeSaving();

            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            OnBeforeSaving();

            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        private void OnBeforeSaving()
        {
            this.UpdateTimestamp();
            this.UpdateSoftDelete();
        }
    }
}
