﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NotSteam.DB;

namespace NotSteam.Migrations
{
    [DbContext(typeof(NotSteamContext))]
    [Migration("20190724103738_Temp3")]
    partial class Temp3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NotSteam.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<string>("HomepageUri");

                    b.Property<DateTime>("LastModifiedAt");

                    b.Property<string>("LogoImageUri");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2019, 7, 24, 10, 37, 38, 115, DateTimeKind.Utc).AddTicks(8513),
                            Description = "We make really cool games!",
                            HomepageUri = "https://www.methesda-softworks.com",
                            LastModifiedAt = new DateTime(2019, 7, 24, 10, 37, 38, 115, DateTimeKind.Utc).AddTicks(8515),
                            LogoImageUri = "https://cdn.notsteam.com/images/101",
                            Name = "Methesda Softworks Inc."
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2019, 7, 24, 10, 37, 38, 116, DateTimeKind.Utc).AddTicks(613),
                            Description = "We make tech demos!",
                            HomepageUri = "https://www.crymearivertek.com",
                            LastModifiedAt = new DateTime(2019, 7, 24, 10, 37, 38, 116, DateTimeKind.Utc).AddTicks(614),
                            LogoImageUri = "https://cdn.notsteam.com/images/102",
                            Name = "CryMeARiverTek GmbH"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2019, 7, 24, 10, 37, 38, 116, DateTimeKind.Utc).AddTicks(640),
                            Description = "We make great action-adventure, role-playing games!",
                            HomepageUri = "https://www.dvd-projekt-blue.com",
                            LastModifiedAt = new DateTime(2019, 7, 24, 10, 37, 38, 116, DateTimeKind.Utc).AddTicks(641),
                            LogoImageUri = "https://cdn.notsteam.com/images/103",
                            Name = "DVD Projekt Blue"
                        });
                });

            modelBuilder.Entity("NotSteam.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("BasePrice")
                        .HasColumnType("decimal(19,4)");

                    b.Property<int>("CompanyId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<DateTime>("LastModifiedAt");

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BasePrice = 59.99m,
                            CompanyId = 3,
                            CreatedAt = new DateTime(2019, 7, 24, 10, 37, 38, 116, DateTimeKind.Utc).AddTicks(5460),
                            Description = "New year, new game!",
                            LastModifiedAt = new DateTime(2019, 7, 24, 10, 37, 38, 116, DateTimeKind.Utc).AddTicks(5461),
                            ReleaseDate = new DateTime(2019, 6, 22, 0, 0, 0, 0, DateTimeKind.Utc),
                            Title = "C4ll of $$$$: Covert Ops"
                        },
                        new
                        {
                            Id = 2,
                            BasePrice = 79.99m,
                            CompanyId = 1,
                            CreatedAt = new DateTime(2019, 7, 24, 10, 37, 38, 116, DateTimeKind.Utc).AddTicks(7612),
                            Description = "What we really want from EA.",
                            LastModifiedAt = new DateTime(2019, 7, 24, 10, 37, 38, 116, DateTimeKind.Utc).AddTicks(7614),
                            ReleaseDate = new DateTime(2018, 12, 12, 0, 0, 0, 0, DateTimeKind.Utc),
                            Title = "Need for Speed: Underground 3"
                        },
                        new
                        {
                            Id = 3,
                            BasePrice = 69.69m,
                            CompanyId = 2,
                            CreatedAt = new DateTime(2019, 7, 24, 10, 37, 38, 116, DateTimeKind.Utc).AddTicks(7641),
                            Description = "One of these days…",
                            LastModifiedAt = new DateTime(2019, 7, 24, 10, 37, 38, 116, DateTimeKind.Utc).AddTicks(7642),
                            ReleaseDate = new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc),
                            Title = "Age of Empires 4"
                        });
                });

            modelBuilder.Entity("NotSteam.Models.GameTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("GameId");

                    b.Property<DateTime>("LastModifiedAt");

                    b.Property<int>("TagId");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("TagId");

                    b.ToTable("GameTags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2019, 7, 24, 10, 37, 38, 116, DateTimeKind.Utc).AddTicks(9052),
                            GameId = 1,
                            LastModifiedAt = new DateTime(2019, 7, 24, 10, 37, 38, 116, DateTimeKind.Utc).AddTicks(9054),
                            TagId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(815),
                            GameId = 1,
                            LastModifiedAt = new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(816),
                            TagId = 2
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(841),
                            GameId = 2,
                            LastModifiedAt = new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(842),
                            TagId = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(843),
                            GameId = 2,
                            LastModifiedAt = new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(844),
                            TagId = 2
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(845),
                            GameId = 2,
                            LastModifiedAt = new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(846),
                            TagId = 3
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(847),
                            GameId = 3,
                            LastModifiedAt = new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(848),
                            TagId = 1
                        });
                });

            modelBuilder.Entity("NotSteam.Models.Library", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("DateAcquired");

                    b.Property<int>("GameId");

                    b.Property<DateTime>("LastModifiedAt");

                    b.Property<DateTime>("LastPlayedDate");

                    b.Property<int>("TotalPlayTimeHours");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("UserId");

                    b.ToTable("Libraries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(2251),
                            DateAcquired = new DateTime(2019, 7, 20, 0, 0, 0, 0, DateTimeKind.Utc),
                            GameId = 1,
                            LastModifiedAt = new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(2252),
                            LastPlayedDate = new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(2250),
                            TotalPlayTimeHours = 20,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(4129),
                            DateAcquired = new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(4127),
                            GameId = 2,
                            LastModifiedAt = new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(4129),
                            LastPlayedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalPlayTimeHours = 0,
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(4163),
                            DateAcquired = new DateTime(2019, 7, 18, 0, 0, 0, 0, DateTimeKind.Utc),
                            GameId = 1,
                            LastModifiedAt = new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(4163),
                            LastPlayedDate = new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(4162),
                            TotalPlayTimeHours = 130,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("NotSteam.Models.Purchase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("DateOfPurchase");

                    b.Property<int>("GameId");

                    b.Property<DateTime>("LastModifiedAt");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(19,4)");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("UserId");

                    b.ToTable("Purchases");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(5667),
                            DateOfPurchase = new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            GameId = 1,
                            LastModifiedAt = new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(5669),
                            TotalPrice = 59.99m,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(7525),
                            DateOfPurchase = new DateTime(2019, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc),
                            GameId = 2,
                            LastModifiedAt = new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(7526),
                            TotalPrice = 64.99m,
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(7553),
                            DateOfPurchase = new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            GameId = 1,
                            LastModifiedAt = new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(7554),
                            TotalPrice = 24.99m,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("NotSteam.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<int>("GameId");

                    b.Property<DateTime>("LastModifiedAt");

                    b.Property<int>("Rating");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(8873),
                            Description = "This is a really good game! You should get it too!",
                            GameId = 1,
                            LastModifiedAt = new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(8873),
                            Rating = 8,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2019, 7, 24, 10, 37, 38, 118, DateTimeKind.Utc).AddTicks(774),
                            Description = "It's a good game, but I don't like \"surprise mechanics\".",
                            GameId = 1,
                            LastModifiedAt = new DateTime(2019, 7, 24, 10, 37, 38, 118, DateTimeKind.Utc).AddTicks(775),
                            Rating = 6,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("NotSteam.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<DateTime>("LastModifiedAt");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(48);

                    b.HasKey("Id");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2019, 7, 24, 10, 37, 38, 116, DateTimeKind.Utc).AddTicks(2350),
                            Description = "This item contains single-player content (e.g. campaign, story mode, etc.)",
                            LastModifiedAt = new DateTime(2019, 7, 24, 10, 37, 38, 116, DateTimeKind.Utc).AddTicks(2352),
                            Name = "Single-Player"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2019, 7, 24, 10, 37, 38, 116, DateTimeKind.Utc).AddTicks(4066),
                            Description = "This item contains multi-player content. Requires an internet connection.",
                            LastModifiedAt = new DateTime(2019, 7, 24, 10, 37, 38, 116, DateTimeKind.Utc).AddTicks(4067),
                            Name = "Multi-Player"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2019, 7, 24, 10, 37, 38, 116, DateTimeKind.Utc).AddTicks(4092),
                            Description = "This item contains ce-op content. Requires an internet connection. A limited amount of players can group up and play!",
                            LastModifiedAt = new DateTime(2019, 7, 24, 10, 37, 38, 116, DateTimeKind.Utc).AddTicks(4092),
                            Name = "Co-Op"
                        });
                });

            modelBuilder.Entity("NotSteam.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<DateTime>("LastModifiedAt");

                    b.Property<string>("Nickname");

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("ProfileImageUri");

                    b.Property<string>("Username")
                        .IsRequired();

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
                            CreatedAt = new DateTime(2019, 7, 24, 10, 37, 38, 115, DateTimeKind.Utc).AddTicks(144),
                            DateOfBirth = new DateTime(1996, 4, 23, 0, 0, 0, 0, DateTimeKind.Utc),
                            Email = "Player123@gmail.com",
                            LastModifiedAt = new DateTime(2019, 7, 24, 10, 37, 38, 115, DateTimeKind.Utc).AddTicks(146),
                            Nickname = "xXSlayerXx",
                            Password = "ReallySecurePlaintextStorage",
                            ProfileImageUri = "https://cdn.notsteam.com/images/1",
                            Username = "Player123"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2019, 7, 24, 10, 37, 38, 115, DateTimeKind.Utc).AddTicks(2999),
                            DateOfBirth = new DateTime(1992, 2, 12, 0, 0, 0, 0, DateTimeKind.Utc),
                            Email = "NobodyReally@outlook.com",
                            LastModifiedAt = new DateTime(2019, 7, 24, 10, 37, 38, 115, DateTimeKind.Utc).AddTicks(3001),
                            Nickname = "Sgt. Harry",
                            Password = "super_secure_pass123",
                            ProfileImageUri = "https://cdn.notsteam.com/images/2",
                            Username = "cool_username2"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2019, 7, 24, 10, 37, 38, 115, DateTimeKind.Utc).AddTicks(3031),
                            DateOfBirth = new DateTime(1989, 8, 30, 0, 0, 0, 0, DateTimeKind.Utc),
                            Email = "SampleText@gmail.com",
                            LastModifiedAt = new DateTime(2019, 7, 24, 10, 37, 38, 115, DateTimeKind.Utc).AddTicks(3031),
                            Nickname = "Mr.Boom",
                            Password = "no1C4nGU3sSm3",
                            ProfileImageUri = "https://cdn.notsteam.com/images/3",
                            Username = "tru_41iam"
                        });
                });

            modelBuilder.Entity("NotSteam.Models.Game", b =>
                {
                    b.HasOne("NotSteam.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NotSteam.Models.GameTag", b =>
                {
                    b.HasOne("NotSteam.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NotSteam.Models.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NotSteam.Models.Library", b =>
                {
                    b.HasOne("NotSteam.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NotSteam.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NotSteam.Models.Purchase", b =>
                {
                    b.HasOne("NotSteam.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NotSteam.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NotSteam.Models.Review", b =>
                {
                    b.HasOne("NotSteam.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NotSteam.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
