﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NotSteam.Infrastructure.DB;

namespace NotSteam.Infrastructure.Migrations
{
    [DbContext(typeof(NotSteamContext))]
    partial class NotSteamContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NotSteam.Model.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description")
                        .HasMaxLength(1500);

                    b.Property<string>("HomepageUri");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LogoImageUri");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2019, 8, 18, 10, 49, 23, 327, DateTimeKind.Utc).AddTicks(4570),
                            Description = "We make really cool games!",
                            HomepageUri = "https://www.methesda-softworks.com",
                            IsDeleted = false,
                            LogoImageUri = "https://cdn.notsteam.com/images/101",
                            Name = "Methesda Softworks Inc."
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2019, 8, 18, 10, 49, 23, 327, DateTimeKind.Utc).AddTicks(5606),
                            Description = "We make tech demos!",
                            HomepageUri = "https://www.crymearivertek.com",
                            IsDeleted = false,
                            LogoImageUri = "https://cdn.notsteam.com/images/102",
                            Name = "CryMeARiverTek GmbH"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2019, 8, 18, 10, 49, 23, 327, DateTimeKind.Utc).AddTicks(5617),
                            Description = "We make great action-adventure, role-playing games!",
                            HomepageUri = "https://www.dvd-projekt-blue.com",
                            IsDeleted = false,
                            LogoImageUri = "https://cdn.notsteam.com/images/103",
                            Name = "DVD Projekt Blue"
                        });
                });

            modelBuilder.Entity("NotSteam.Model.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("BasePrice")
                        .HasColumnType("decimal(19,4)");

                    b.Property<int>("CompanyId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description")
                        .HasMaxLength(1500);

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BasePrice = 59.99m,
                            CompanyId = 3,
                            CreatedAt = new DateTime(2019, 8, 18, 10, 49, 23, 328, DateTimeKind.Utc).AddTicks(4833),
                            Description = "New year, new game!",
                            IsDeleted = false,
                            ReleaseDate = new DateTime(2019, 6, 22, 0, 0, 0, 0, DateTimeKind.Utc),
                            Title = "C4ll of $$$$: Covert Ops"
                        },
                        new
                        {
                            Id = 2,
                            BasePrice = 79.99m,
                            CompanyId = 1,
                            CreatedAt = new DateTime(2019, 8, 18, 10, 49, 23, 328, DateTimeKind.Utc).AddTicks(5796),
                            Description = "What we really want from EA.",
                            IsDeleted = false,
                            ReleaseDate = new DateTime(2018, 12, 12, 0, 0, 0, 0, DateTimeKind.Utc),
                            Title = "Need for Speed: Underground 3"
                        },
                        new
                        {
                            Id = 3,
                            BasePrice = 69.69m,
                            CompanyId = 2,
                            CreatedAt = new DateTime(2019, 8, 18, 10, 49, 23, 328, DateTimeKind.Utc).AddTicks(5807),
                            Description = "One of these days…",
                            IsDeleted = false,
                            ReleaseDate = new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc),
                            Title = "Age of Empires 4"
                        });
                });

            modelBuilder.Entity("NotSteam.Model.Models.GameTag", b =>
                {
                    b.Property<int>("GameId");

                    b.Property<int>("TagId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("GameId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("GameTags");

                    b.HasData(
                        new
                        {
                            GameId = 1,
                            TagId = 1,
                            CreatedAt = new DateTime(2019, 8, 18, 10, 49, 23, 328, DateTimeKind.Utc).AddTicks(9877),
                            IsDeleted = false
                        },
                        new
                        {
                            GameId = 1,
                            TagId = 2,
                            CreatedAt = new DateTime(2019, 8, 18, 10, 49, 23, 329, DateTimeKind.Utc).AddTicks(511),
                            IsDeleted = false
                        },
                        new
                        {
                            GameId = 2,
                            TagId = 1,
                            CreatedAt = new DateTime(2019, 8, 18, 10, 49, 23, 329, DateTimeKind.Utc).AddTicks(521),
                            IsDeleted = false
                        },
                        new
                        {
                            GameId = 2,
                            TagId = 2,
                            CreatedAt = new DateTime(2019, 8, 18, 10, 49, 23, 329, DateTimeKind.Utc).AddTicks(521),
                            IsDeleted = false
                        },
                        new
                        {
                            GameId = 2,
                            TagId = 3,
                            CreatedAt = new DateTime(2019, 8, 18, 10, 49, 23, 329, DateTimeKind.Utc).AddTicks(522),
                            IsDeleted = false
                        },
                        new
                        {
                            GameId = 3,
                            TagId = 1,
                            CreatedAt = new DateTime(2019, 8, 18, 10, 49, 23, 329, DateTimeKind.Utc).AddTicks(523),
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("NotSteam.Model.Models.Library", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("GameId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("DateAcquired");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("LastPlayedDate");

                    b.Property<int>("TotalPlayTimeHours");

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("UserId", "GameId");

                    b.HasIndex("GameId");

                    b.ToTable("Libraries");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            GameId = 1,
                            CreatedAt = new DateTime(2019, 8, 18, 10, 49, 23, 329, DateTimeKind.Utc).AddTicks(5394),
                            DateAcquired = new DateTime(2019, 7, 20, 0, 0, 0, 0, DateTimeKind.Utc),
                            IsDeleted = false,
                            LastPlayedDate = new DateTime(2019, 8, 18, 10, 49, 23, 329, DateTimeKind.Utc).AddTicks(5394),
                            TotalPlayTimeHours = 20
                        },
                        new
                        {
                            UserId = 1,
                            GameId = 2,
                            CreatedAt = new DateTime(2019, 8, 18, 10, 49, 23, 329, DateTimeKind.Utc).AddTicks(6181),
                            DateAcquired = new DateTime(2019, 8, 18, 10, 49, 23, 329, DateTimeKind.Utc).AddTicks(6180),
                            IsDeleted = false,
                            LastPlayedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalPlayTimeHours = 0
                        },
                        new
                        {
                            UserId = 2,
                            GameId = 1,
                            CreatedAt = new DateTime(2019, 8, 18, 10, 49, 23, 329, DateTimeKind.Utc).AddTicks(6265),
                            DateAcquired = new DateTime(2019, 7, 18, 0, 0, 0, 0, DateTimeKind.Utc),
                            IsDeleted = false,
                            LastPlayedDate = new DateTime(2019, 8, 18, 10, 49, 23, 329, DateTimeKind.Utc).AddTicks(6264),
                            TotalPlayTimeHours = 730
                        });
                });

            modelBuilder.Entity("NotSteam.Model.Models.Purchase", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("GameId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("DateOfPurchase");

                    b.Property<bool>("IsDeleted");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(19,4)");

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("UserId", "GameId");

                    b.HasIndex("GameId");

                    b.ToTable("Purchases");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            GameId = 1,
                            CreatedAt = new DateTime(2019, 8, 18, 10, 49, 23, 330, DateTimeKind.Utc).AddTicks(830),
                            DateOfPurchase = new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            IsDeleted = false,
                            TotalPrice = 59.99m
                        },
                        new
                        {
                            UserId = 1,
                            GameId = 2,
                            CreatedAt = new DateTime(2019, 8, 18, 10, 49, 23, 330, DateTimeKind.Utc).AddTicks(1633),
                            DateOfPurchase = new DateTime(2019, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc),
                            IsDeleted = false,
                            TotalPrice = 64.99m
                        },
                        new
                        {
                            UserId = 2,
                            GameId = 1,
                            CreatedAt = new DateTime(2019, 8, 18, 10, 49, 23, 330, DateTimeKind.Utc).AddTicks(1645),
                            DateOfPurchase = new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            IsDeleted = false,
                            TotalPrice = 24.99m
                        });
                });

            modelBuilder.Entity("NotSteam.Model.Models.Review", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("GameId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description")
                        .HasMaxLength(1500);

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("Rating");

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("UserId", "GameId");

                    b.HasIndex("GameId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            GameId = 1,
                            CreatedAt = new DateTime(2019, 8, 18, 10, 49, 23, 330, DateTimeKind.Utc).AddTicks(4448),
                            Description = "This is a really good game! You should get it too!",
                            IsDeleted = false,
                            Rating = 8
                        },
                        new
                        {
                            UserId = 2,
                            GameId = 1,
                            CreatedAt = new DateTime(2019, 8, 18, 10, 49, 23, 330, DateTimeKind.Utc).AddTicks(5217),
                            Description = "It's a good game, but I don't like \"surprise mechanics\".",
                            IsDeleted = false,
                            Rating = 6
                        });
                });

            modelBuilder.Entity("NotSteam.Model.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description")
                        .HasMaxLength(250);

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(48);

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2019, 8, 18, 10, 49, 23, 327, DateTimeKind.Utc).AddTicks(8718),
                            Description = "This item contains single-player content (e.g. campaign, story mode, etc.)",
                            IsDeleted = false,
                            Name = "Single-Player"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2019, 8, 18, 10, 49, 23, 327, DateTimeKind.Utc).AddTicks(9568),
                            Description = "This item contains multi-player content. Requires an internet connection.",
                            IsDeleted = false,
                            Name = "Multi-Player"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2019, 8, 18, 10, 49, 23, 327, DateTimeKind.Utc).AddTicks(9579),
                            Description = "This item contains ce-op content. Requires an internet connection. A limited amount of players can group up and play!",
                            IsDeleted = false,
                            Name = "Co-Op"
                        });
                });

            modelBuilder.Entity("NotSteam.Model.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(254);

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Nickname")
                        .HasMaxLength(32);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<string>("ProfileImageUri");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2019, 8, 18, 10, 49, 23, 326, DateTimeKind.Utc).AddTicks(8710),
                            DateOfBirth = new DateTime(1996, 4, 23, 0, 0, 0, 0, DateTimeKind.Utc),
                            Email = "Player123@gmail.com",
                            IsDeleted = false,
                            Nickname = "xXSlayerXx",
                            Password = "ReallySecurePlaintextStorage",
                            ProfileImageUri = "https://cdn.notsteam.com/images/1",
                            Username = "Player123"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2019, 8, 18, 10, 49, 23, 326, DateTimeKind.Utc).AddTicks(9968),
                            DateOfBirth = new DateTime(1992, 2, 12, 0, 0, 0, 0, DateTimeKind.Utc),
                            Email = "NobodyReally@outlook.com",
                            IsDeleted = false,
                            Nickname = "Sgt. Harry",
                            Password = "super_secure_pass123",
                            ProfileImageUri = "https://cdn.notsteam.com/images/2",
                            Username = "cool_username2"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2019, 8, 18, 10, 49, 23, 326, DateTimeKind.Utc).AddTicks(9979),
                            DateOfBirth = new DateTime(1989, 8, 30, 0, 0, 0, 0, DateTimeKind.Utc),
                            Email = "SampleText@gmail.com",
                            IsDeleted = false,
                            Nickname = "Mr.Boom",
                            Password = "no1C4nGU3sSm3",
                            ProfileImageUri = "https://cdn.notsteam.com/images/3",
                            Username = "tru_41iam"
                        });
                });

            modelBuilder.Entity("NotSteam.Model.Models.Game", b =>
                {
                    b.HasOne("NotSteam.Model.Models.Company", "Company")
                        .WithMany("Games")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NotSteam.Model.Models.GameTag", b =>
                {
                    b.HasOne("NotSteam.Model.Models.Game", "Game")
                        .WithMany("GameTags")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NotSteam.Model.Models.Tag", "Tag")
                        .WithMany("GameTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NotSteam.Model.Models.Library", b =>
                {
                    b.HasOne("NotSteam.Model.Models.Game", "Game")
                        .WithMany("Libraries")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NotSteam.Model.Models.User", "User")
                        .WithMany("Libraries")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NotSteam.Model.Models.Purchase", b =>
                {
                    b.HasOne("NotSteam.Model.Models.Game", "Game")
                        .WithMany("Purchases")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NotSteam.Model.Models.User", "User")
                        .WithMany("Purchases")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NotSteam.Model.Models.Review", b =>
                {
                    b.HasOne("NotSteam.Model.Models.Game", "Game")
                        .WithMany("Reviews")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NotSteam.Model.Models.User", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
