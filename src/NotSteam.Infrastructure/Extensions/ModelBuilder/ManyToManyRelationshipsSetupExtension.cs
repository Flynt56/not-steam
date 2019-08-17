using NotSteam.Model.Models;

namespace NotSteam.Core.Extensions.ModelBuilder
{
    public static class ManyToManyRelationshipsSetupExtension
    {
        public static void ManyToManyRelationshipsSetup(this Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
        {
            GameTag(modelBuilder);
            Library(modelBuilder);
            Purchase(modelBuilder);
            Review(modelBuilder);
        }

        private static void Review(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Review>()
                .HasKey(r => new { r.UserId, r.GameId });

            modelBuilder.Entity<Review>()
                .HasOne(r => r.Game)
                .WithMany(g => g.Reviews)
                .HasForeignKey(r => r.GameId);

            modelBuilder.Entity<Review>()
                .HasOne(r => r.User)
                .WithMany(u => u.Reviews)
                .HasForeignKey(r => r.UserId);
        }

        private static void Purchase(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Purchase>()
                .HasKey(p => new { p.UserId, p.GameId });

            modelBuilder.Entity<Purchase>()
                .HasOne(p => p.Game)
                .WithMany(g => g.Purchases)
                .HasForeignKey(p => p.GameId);

            modelBuilder.Entity<Purchase>()
                .HasOne(p => p.User)
                .WithMany(u => u.Purchases)
                .HasForeignKey(p => p.UserId);
        }

        private static void Library(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Library>()
                .HasKey(l => new { l.UserId, l.GameId });

            modelBuilder.Entity<Library>()
                .HasOne(l => l.Game)
                .WithMany(g => g.Libraries)
                .HasForeignKey(l => l.GameId);

            modelBuilder.Entity<Library>()
                .HasOne(l => l.User)
                .WithMany(u => u.Libraries)
                .HasForeignKey(l => l.UserId);
        }

        private static void GameTag(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GameTag>()
                .HasKey(gt => new { gt.GameId, gt.TagId });

            modelBuilder.Entity<GameTag>()
                .HasOne(gt => gt.Game)
                .WithMany(g => g.GameTags)
                .HasForeignKey(gt => gt.GameId);

            modelBuilder.Entity<GameTag>()
                .HasOne(gt => gt.Tag)
                .WithMany(t => t.GameTags)
                .HasForeignKey(gt => gt.TagId);
        }
    }
}

