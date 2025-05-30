﻿// <auto-generated />
using System;
using GivingGardenBE.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GivingGardenBE.Migrations
{
    [DbContext(typeof(GivingGardenBEDbContext))]
    [Migration("20250510152621_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("GivingGardenBE.Models.Categories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Education"
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Environment"
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Animal Welfare"
                        },
                        new
                        {
                            Id = 4,
                            CategoryName = "Humanitaraian Aid"
                        },
                        new
                        {
                            Id = 5,
                            CategoryName = "Community Development"
                        });
                });

            modelBuilder.Entity("GivingGardenBE.Models.Organization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("Created_at")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("Mission")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("Website")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Organizations");

                    b.HasData(
                        new
                        {
                            Id = 101,
                            CategoryName = "Community Development",
                            Created_at = new DateTime(2025, 5, 10, 10, 26, 20, 901, DateTimeKind.Local).AddTicks(7819),
                            Description = "Brings smiles and solar-powered radios to remote villages one playlist at a time.",
                            Email = "DWBtest.gmail.com",
                            Image = "https://images.openai.com/thumbnails/39a8828844b53eb51453e3cd9e306ec8.png",
                            Mission = "Cultivating hope and sustainable futures through global community development, education, and agricultural empowerment.",
                            Title = "HopeHarvest International",
                            UserId = "XdynYdPxtmTU4VghjX2paBdQC9b2",
                            Website = "HarvestInter@test.com"
                        },
                        new
                        {
                            Id = 102,
                            CategoryName = "Education",
                            Created_at = new DateTime(2025, 5, 10, 10, 26, 20, 901, DateTimeKind.Local).AddTicks(8030),
                            Description = "Delivers enchanted storybooks to children in magical lands (and a few underfunded libraries).",
                            Email = "BFBtest.gmail.com",
                            Image = "https://m.media-amazon.com/images/I/81ukSP5PrJL._AC_UF1000%2C1000_QL80_.jpg",
                            Mission = "Expanding minds and opportunities by delivering books and educational resources to underserved communities around the world.",
                            Title = "Books for Beyond",
                            UserId = "XdynYdPxtmTU4VghjX2paBdQC9b2",
                            Website = "Beyond@test.com"
                        },
                        new
                        {
                            Id = 103,
                            CategoryName = "Humanitarian Aid",
                            Created_at = new DateTime(2025, 5, 10, 10, 26, 20, 901, DateTimeKind.Local).AddTicks(8035),
                            Description = "Knits invisible scarves for people experiencing metaphorical winters.",
                            Email = "WOWtest.gmail.com",
                            Image = "https://www.shutterstock.com/image-photo/flock-white-pelicans-soars-gracefully-over-2603037941",
                            Mission = "To deliver warmth, comfort, and hope to vulnerable individuals through seasonal support programs, emergency aid, and community-driven outreach initiatives.",
                            Title = "Wings of Warmth",
                            UserId = "XdynYdPxtmTU4VghjX2paBdQC9b2",
                            Website = "WarmWing@test.com"
                        },
                        new
                        {
                            Id = 104,
                            CategoryName = "Environment",
                            Created_at = new DateTime(2025, 5, 10, 10, 26, 20, 901, DateTimeKind.Local).AddTicks(8037),
                            Description = "Sends love letters and biodegradable glitter to lonely sea creatures.",
                            Email = "OHPtest.gmail.com",
                            Image = "https://i0.wp.com/oceanblueproject.org/wp-content/uploads/2023/05/happy-world-ocean-day-activities-ocean-blue-project-cleanup.webp?fit=2048%2C1367&ssl=1",
                            Mission = "To protect and nurture our oceans through grassroots conservation efforts, education, and community engagement, inspiring a global embrace of marine stewardship.",
                            Title = "Ocean Hug Project",
                            UserId = "XdynYdPxtmTU4VghjX2paBdQC9b2",
                            Website = "OHP@test.com"
                        },
                        new
                        {
                            Id = 105,
                            CategoryName = "Animal Welfare",
                            Created_at = new DateTime(2025, 5, 10, 10, 26, 20, 901, DateTimeKind.Local).AddTicks(8040),
                            Description = "Helps vertically challenged animals reach their dreams (and the top shelf).",
                            Email = "TGLFtest.gmail.com",
                            Image = "https://media.istockphoto.com/id/543346734/photo/giraffe-in-the-library.jpg?s=2048x2048&w=is&k=20&c=PgjqCSR3ad0uzcPHpnR9ji6oAmuTJFAHhp0JDL8rpas=",
                            Mission = "To elevate opportunities for conservation, education, and leadership through projects that help communities—and endangered giraffes—rise to new heights.",
                            Title = "The Giraffe Ladder Fund",
                            UserId = "XdynYdPxtmTU4VghjX2paBdQC9b2",
                            Website = "GLF@test.com"
                        },
                        new
                        {
                            Id = 106,
                            CategoryName = "Humanitarian Aid",
                            Created_at = new DateTime(2025, 5, 10, 10, 26, 20, 901, DateTimeKind.Local).AddTicks(8046),
                            Description = "Helps friendless goobers get all the companions they need.",
                            Email = "goobers@example.com",
                            Image = "https://i1.sndcdn.com/avatars-000127116014-hqzcna-t240x240.jpg",
                            Mission = "Bring all goobers together",
                            Title = "Visiting Goobers",
                            UserId = "9wNJQC9hfrMhjpdOUPD1wxjqLjE2",
                            Website = "Goob@test.com"
                        },
                        new
                        {
                            Id = 107,
                            CategoryName = "Humanitarian Aid",
                            Created_at = new DateTime(2025, 5, 10, 10, 26, 20, 901, DateTimeKind.Local).AddTicks(8048),
                            Description = "Red shorts initiative, everyone deserves a pair. Polka dots are also allowed.",
                            Email = "theRedShorts@example.com",
                            Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQAyHT6BTbA-AKsM_-FIwE382ec-uIYKOE-Vg&s",
                            Mission = "Shorts for days",
                            Title = "American Red Shorts",
                            UserId = "9wNJQC9hfrMhjpdOUPD1wxjqLjE2",
                            Website = "shorts@test.com"
                        },
                        new
                        {
                            Id = 108,
                            CategoryName = "Humanitarian Aid",
                            Created_at = new DateTime(2025, 5, 10, 10, 26, 20, 901, DateTimeKind.Local).AddTicks(8051),
                            Description = "Help the salvation army by adding to my bank account.",
                            Email = "johnelmo@example.com",
                            Image = "https://st2.depositphotos.com/3758943/6040/i/450/depositphotos_60400957-stock-photo-the-man-in-the-office.jpg",
                            Mission = "We shall support the cause",
                            Title = "The Salvation Army’s biggest supporter",
                            UserId = "9wNJQC9hfrMhjpdOUPD1wxjqLjE2",
                            Website = "Broc@test.com"
                        },
                        new
                        {
                            Id = 109,
                            CategoryName = "Education",
                            Created_at = new DateTime(2025, 5, 10, 10, 26, 20, 901, DateTimeKind.Local).AddTicks(8053),
                            Description = "One of the orgs yeah yeah",
                            Email = "brocbuhler@gmail.com",
                            Image = "https://i.ytimg.com/vi/k9KAc23W48s/sddefault.jpg",
                            Mission = "Brocs Retirment",
                            Title = "Broc's Bank Account",
                            UserId = "9wNJQC9hfrMhjpdOUPD1wxjqLjE2",
                            Website = "Broc@test.com"
                        },
                        new
                        {
                            Id = 110,
                            CategoryName = "Animal Welfare",
                            Created_at = new DateTime(2025, 5, 10, 10, 26, 20, 901, DateTimeKind.Local).AddTicks(8056),
                            Description = "Give me money for cat NOW.",
                            Email = "givecat@gmail.com",
                            Image = "https://media.npr.org/assets/img/2023/12/12/gettyimages-1054147940-627235e01fb63b4644bec84204c259f0a343e35b.jpg",
                            Mission = "Rescue all felines",
                            Title = "Cat",
                            UserId = "9wNJQC9hfrMhjpdOUPD1wxjqLjE2",
                            Website = "cat@test.com"
                        },
                        new
                        {
                            Id = 111,
                            CategoryName = "Environment",
                            Created_at = new DateTime(2025, 5, 10, 10, 26, 20, 901, DateTimeKind.Local).AddTicks(8058),
                            Description = "We are like super dark and edgy bro look at our spiky ghost king crowns and our exploding orc birth sacs.",
                            Email = "cuteSaronPIcs@mordor.com",
                            Image = "https://i.redd.it/the-two-towers-vs-return-of-the-king-mordor-v0-b352b0r01tyb1.jpg?width=3816&format=pjpg&auto=webp&s=c3f5494c21e1ccfc774b3bb8649fcfc8a2670ea3",
                            Mission = "Bring about the rise of mordor",
                            Title = "The Dark Organization",
                            UserId = "9wNJQC9hfrMhjpdOUPD1wxjqLjE2",
                            Website = "mordor@test.com"
                        });
                });

            modelBuilder.Entity("GivingGardenBE.Models.PaymentTypes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("PaymentTypeName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("PaymentTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PaymentTypeName = "Mastercard"
                        },
                        new
                        {
                            Id = 2,
                            PaymentTypeName = "PayPal"
                        },
                        new
                        {
                            Id = 3,
                            PaymentTypeName = "Visa"
                        },
                        new
                        {
                            Id = 4,
                            PaymentTypeName = "Cryptocurrency"
                        },
                        new
                        {
                            Id = 5,
                            PaymentTypeName = "Debit"
                        });
                });

            modelBuilder.Entity("GivingGardenBE.Models.Subscription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("OrganizationId")
                        .HasColumnType("integer");

                    b.Property<string>("PayFrequency")
                        .HasColumnType("text");

                    b.Property<decimal>("PaymentAmount")
                        .HasColumnType("numeric");

                    b.Property<string>("PaymentType")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Subscribed_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.HasIndex("UserId");

                    b.ToTable("Subscriptions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            OrganizationId = 108,
                            PayFrequency = "Monthly",
                            PaymentAmount = 10.00m,
                            PaymentType = "paypal",
                            Subscribed_at = new DateTime(2025, 5, 10, 10, 26, 20, 898, DateTimeKind.Local).AddTicks(2195),
                            UserId = "9wNJQC9hfrMhjpdOUPD1wxjqLjE2"
                        },
                        new
                        {
                            Id = 2,
                            OrganizationId = 102,
                            PayFrequency = "Quarterly",
                            PaymentAmount = 10.00m,
                            PaymentType = "debit",
                            Subscribed_at = new DateTime(2025, 5, 10, 10, 26, 20, 900, DateTimeKind.Local).AddTicks(9237),
                            UserId = "9wNJQC9hfrMhjpdOUPD1wxjqLjE2"
                        },
                        new
                        {
                            Id = 3,
                            OrganizationId = 106,
                            PayFrequency = "Monthly",
                            PaymentAmount = 10.00m,
                            PaymentType = "mastercard",
                            Subscribed_at = new DateTime(2025, 5, 10, 10, 26, 20, 900, DateTimeKind.Local).AddTicks(9278),
                            UserId = "9wNJQC9hfrMhjpdOUPD1wxjqLjE2"
                        },
                        new
                        {
                            Id = 4,
                            OrganizationId = 104,
                            PayFrequency = "Weekly",
                            PaymentAmount = 10.00m,
                            PaymentType = "cryptocurrency",
                            Subscribed_at = new DateTime(2025, 5, 10, 10, 26, 20, 900, DateTimeKind.Local).AddTicks(9281),
                            UserId = "XdynYdPxtmTU4VghjX2paBdQC9b2"
                        },
                        new
                        {
                            Id = 5,
                            OrganizationId = 105,
                            PayFrequency = "Yearly",
                            PaymentAmount = 10.00m,
                            PaymentType = "visa",
                            Subscribed_at = new DateTime(2025, 5, 10, 10, 26, 20, 900, DateTimeKind.Local).AddTicks(9283),
                            UserId = "XdynYdPxtmTU4VghjX2paBdQC9b2"
                        });
                });

            modelBuilder.Entity("GivingGardenBE.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirebaseUid")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "CaseCunnTest@gmail.com",
                            FirebaseUid = "9wNJQC9hfrMhjpdOUPD1wxjqLjE2",
                            Image = "https://ca.slack-edge.com/T03F2SDTJ-U078T3MSH0U-57f35b70c0e6-512",
                            Name = "Casey Cunningham"
                        },
                        new
                        {
                            Id = 2,
                            Email = "NoAllenTest@gmail.com",
                            FirebaseUid = "Pdi1E8scqodl78kPX57bcidHSzq2",
                            Image = "https://ca.slack-edge.com/T03F2SDTJ-U05MUF4KMNY-e42ee592a708-192",
                            Name = "Noah Allen"
                        },
                        new
                        {
                            Id = 3,
                            Email = "MonesTest@gmail.com",
                            FirebaseUid = "XdynYdPxtmTU4VghjX2paBdQC9b2",
                            Image = "https://ca.slack-edge.com/T03F2SDTJ-U078T3N3URJ-1d11def4d536-72",
                            Name = "Max Jones"
                        },
                        new
                        {
                            Id = 4,
                            Email = "TormusTest@gmail.com",
                            FirebaseUid = "AbCdefGhIJKlmnOPQRstUVwxYZ01",
                            Image = "https://ca.slack-edge.com/T03F2SDTJ-U078J0FDSES-82600e02198b-72",
                            Name = "Toren DeRamus"
                        },
                        new
                        {
                            Id = 5,
                            Email = "BSuttleTest@gmail.com",
                            FirebaseUid = "mNopQRstUVwxYZ0123ABCdefGhIJ",
                            Image = "https://ca.slack-edge.com/T03F2SDTJ-U078QJZUQ3U-8bc62e1cae81-512",
                            Name = "Biran Shuttles"
                        },
                        new
                        {
                            Id = 6,
                            Email = "christopherpack17@gmail.com",
                            FirebaseUid = "ZyxWVUTsrqponMLKJihgFEDCba98",
                            Image = "https://ca.slack-edge.com/T03F2SDTJ-U086UKR68LT-e9228b208df1-512",
                            Name = "Christopher Pack"
                        },
                        new
                        {
                            Id = 7,
                            Email = "brocbuhler@gmail.com",
                            FirebaseUid = "a1B2c3D4e5F6g7H8i9J0kLmNoPqR",
                            Image = "https://ca.slack-edge.com/T03F2SDTJ-U086UKR0JRZ-5292d6df3113-512",
                            Name = "Broc Buhler"
                        });
                });

            modelBuilder.Entity("GivingGardenBE.Models.Organization", b =>
                {
                    b.HasOne("GivingGardenBE.Models.User", "User")
                        .WithMany("Organizations")
                        .HasForeignKey("UserId")
                        .HasPrincipalKey("FirebaseUid");

                    b.Navigation("User");
                });

            modelBuilder.Entity("GivingGardenBE.Models.Subscription", b =>
                {
                    b.HasOne("GivingGardenBE.Models.Organization", "Organization")
                        .WithMany("Subscriptions")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GivingGardenBE.Models.User", "User")
                        .WithMany("Subscriptions")
                        .HasForeignKey("UserId")
                        .HasPrincipalKey("FirebaseUid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Organization");

                    b.Navigation("User");
                });

            modelBuilder.Entity("GivingGardenBE.Models.Organization", b =>
                {
                    b.Navigation("Subscriptions");
                });

            modelBuilder.Entity("GivingGardenBE.Models.User", b =>
                {
                    b.Navigation("Organizations");

                    b.Navigation("Subscriptions");
                });
#pragma warning restore 612, 618
        }
    }
}
