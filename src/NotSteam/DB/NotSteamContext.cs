using System;
using Microsoft.EntityFrameworkCore;
using NotSteam.Models;

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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            builder.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();

            // Seed db
            {
                builder.Entity<User>().HasData(
                    new { Id = 1, Username = "Player123", Password = "ReallySecurePlaintextStorage", Email = "Player123@gmail.com", DateOfBirth = DateTime.SpecifyKind(new DateTime(1996, 4, 23), DateTimeKind.Utc), Nickname = "xXSlayerXx", ProfileImageUri = "https://cdn.notsteam.com/images/1" },
                    new { Id = 2, Username = "cool_username2", Password = "super_secure_pass123", Email = "NobodyReally@outlook.com", DateOfBirth = DateTime.SpecifyKind(new DateTime(1992, 2, 12), DateTimeKind.Utc), Nickname = "Sgt. Harry", ProfileImageUri = "https://cdn.notsteam.com/images/2" },
                    new { Id = 3, Username = "tru_41iam", Password = "no1C4nGU3sSm3", Email = "SampleText@gmail.com", DateOfBirth = DateTime.SpecifyKind(new DateTime(1989, 8, 30), DateTimeKind.Utc), Nickname = "Mr.Boom", ProfileImageUri = "https://cdn.notsteam.com/images/3" }
                );

                builder.Entity<Company>().HasData(
                    new { Id = 1, Name = "Methesda Softworks Inc.", HomepageUri = "https://www.methesda-softworks.com", Description = "We make really cool games!", LogoImageUri = "https://cdn.notsteam.com/images/101" },
                    new { Id = 2, Name = "CryMeARiverTek GmbH", HomepageUri = "https://www.crymearivertek.com", Description = "We make tech demos!", LogoImageUri = "https://cdn.notsteam.com/images/102" },
                    new { Id = 3, Name = "DVD Projekt Blue", HomepageUri = "https://www.dvd-projekt-blue.com", Description = "We make great action-adventure, role-playing games!", LogoImageUri = "https://cdn.notsteam.com/images/103" }
                );

                builder.Entity<Tag>().HasData(
                    new { Id = 1, Name = "Single-Player", Description = "This item contains single-player content (e.g. campaign, story mode, etc.)" },
                    new { Id = 2, Name = "Multi-Player", Description = "This item contains multi-player content. Requires an internet connection." },
                    new { Id = 3, Name = "Co-Op", Description = "This item contains ce-op content. Requires an internet connection. A limited amount of players can group up and play!" }
                );

                builder.Entity<Game>().HasData(
                    new { Id = 1, Title = "C4ll of $$$$: Covert Ops", Description = "New year, new game!", ReleaseDate = DateTime.SpecifyKind(new DateTime(2019, 6, 22), DateTimeKind.Utc), BasePrice = 59.99M, CompanyId = 3 },
                    new { Id = 2, Title = "Need for Speed: Underground 3", Description = "What we really want from EA.", ReleaseDate = DateTime.SpecifyKind(new DateTime(2018, 12, 12), DateTimeKind.Utc), BasePrice = 79.99M, CompanyId = 1 },
                    new { Id = 3, Title = "Age of Empires 4", Description = "One of these days…", ReleaseDate = DateTime.SpecifyKind(new DateTime(2022, 10, 10), DateTimeKind.Utc), BasePrice = 69.69M, CompanyId = 2 }
                );

                builder.Entity<GameTag>().HasData(
                    new { Id = 1, GameId = 1, TagId = 1 },
                    new { Id = 2, GameId = 1, TagId = 2 },
                    new { Id = 3, GameId = 2, TagId = 1 },
                    new { Id = 4, GameId = 2, TagId = 2 },
                    new { Id = 5, GameId = 2, TagId = 3 },
                    new { Id = 6, GameId = 3, TagId = 1 }
                );

                builder.Entity<Library>().HasData(
                    new { Id = 1, UserId = 1, GameId = 1, DateAcquired = DateTime.SpecifyKind(new DateTime(2019, 7, 20), DateTimeKind.Utc), TotalPlayTimeHours = 20, LastPlayedDate = DateTime.UtcNow },
                    new { Id = 2, UserId = 1, GameId = 2, DateAcquired = DateTime.UtcNow, TotalPlayTimeHours = 0, LastPlayedDate = new DateTime() },
                    new { Id = 3, UserId = 2, GameId = 1, DateAcquired = DateTime.SpecifyKind(new DateTime(2019, 7, 18), DateTimeKind.Utc), TotalPlayTimeHours = (int)((DateTime.UtcNow - DateTime.SpecifyKind(new DateTime(2019, 7, 19), DateTimeKind.Utc)).TotalHours), LastPlayedDate = DateTime.UtcNow }
                );

                builder.Entity<Purchase>().HasData(
                    new { Id = 1, UserId = 1, GameId = 1, DateOfPurchase = DateTime.SpecifyKind(new DateTime(2019, 7, 19), DateTimeKind.Utc), TotalPrice = 59.99M },
                    new { Id = 2, UserId = 1, GameId = 2, DateOfPurchase = DateTime.SpecifyKind(new DateTime(2019, 7, 10), DateTimeKind.Utc), TotalPrice = 64.99M },
                    new { Id = 3, UserId = 2, GameId = 1, DateOfPurchase = DateTime.SpecifyKind(new DateTime(2019, 7, 1), DateTimeKind.Utc), TotalPrice = 24.99M }
                );

                builder.Entity<Review>().HasData(
                    new { Id = 1, UserId = 1, GameId = 1, Rating = 8, Description = "This is a really good game! You should get it too!", DateCreated = DateTime.UtcNow },
                    new { Id = 2, UserId = 2, GameId = 1, Rating = 6, Description = "It's a good game, but I don't like \"surprise mechanics\".", DateCreated = DateTime.SpecifyKind(new DateTime(2019, 7, 20), DateTimeKind.Utc) }
                );
            }
        }
    }
}