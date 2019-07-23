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

            base.OnModelCreating(builder);

            // Initialize db with fake data
            {
                builder.Entity<User>().HasData(
                    new { Id = 1, Username = "Player123", Password = "ReallySecurePlaintextStorage", Email = "Player123@gmail.com", DateOfBirth = DateTime.SpecifyKind(new DateTime(1996, 4, 23), DateTimeKind.Utc), Nickname = "xXSlayerXx", ProfileImageUri = "https://cdn.notsteam.com/images/1" },
                    new { Id = 2, Username = "cool_username2", Password = "super_secure_pass123", Email = "NobodyReally@outlook.com", DateOfBirth = DateTime.SpecifyKind(new DateTime(1992, 2, 12), DateTimeKind.Utc), Nickname = "Sgt. Harry", ProfileImageUri = "https://cdn.notsteam.com/images/2" },
                    new { Id = 3, Username = "tru_41iam", Password = "no1C4nGU3sSm3", Email = "SampleText@gmail.com", DateOfBirth = DateTime.SpecifyKind(new DateTime(1989, 8, 30), DateTimeKind.Utc), Nickname = "Mr.Boom", ProfileImageUri = "https://cdn.notsteam.com/images/3" });
            }
        }
    }
}