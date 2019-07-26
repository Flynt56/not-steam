using Microsoft.EntityFrameworkCore;
using NotSteam.Extensions.ModelBuilder;
using NotSteam.Extensions.NotSteamContext;
using NotSteam.Models;
using System.Threading;
using System.Threading.Tasks;

namespace NotSteam.DB
{
    public class NotSteamContext : DbContext
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
        public DbSet<User> Users { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnBeforeOnModelCreating(modelBuilder);

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

        private void OnBeforeOnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ManyToManyRelationshipsSetup();
            modelBuilder.ValidationSetup();
            modelBuilder.Seed();
            // TODO (@IBenko): Add query filter setup call
        }

        private void OnBeforeSaving()
        {
            this.UpdateBaseDateable();
            // this.UpdateSoftDeletable();
        }
    }
}

