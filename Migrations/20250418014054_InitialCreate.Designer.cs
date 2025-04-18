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
    [Migration("20250418014054_InitialCreate")]
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

            modelBuilder.Entity("GivingGardenBE.Models.Organization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Organizations");

                    b.HasData(
                        new
                        {
                            Id = 101,
                            Description = "Brings smiles and solar-powered radios to remote villages one playlist at a time.",
                            Email = "DWBtest.gmail.com",
                            Image = "test.png",
                            Title = "HopeHarvest International",
                            UserId = 1
                        },
                        new
                        {
                            Id = 102,
                            Description = "Delivers enchanted storybooks to children in magical lands (and a few underfunded libraries).",
                            Email = "BFBtest.gmail.com",
                            Image = "test.png",
                            Title = "Books for Beyond",
                            UserId = 2
                        },
                        new
                        {
                            Id = 103,
                            Description = "Knits invisible scarves for people experiencing metaphorical winters.",
                            Email = "WOWtest.gmail.com",
                            Image = "test.png",
                            Title = "Wings of Warmth",
                            UserId = 3
                        },
                        new
                        {
                            Id = 104,
                            Description = "Sends love letters and biodegradable glitter to lonely sea creatures.",
                            Email = "OHPtest.gmail.com",
                            Image = "test.png",
                            Title = "Ocean Hug Project",
                            UserId = 4
                        },
                        new
                        {
                            Id = 105,
                            Description = "Helps vertically challenged animals reach their dreams (and the top shelf).",
                            Email = "TGLFtest.gmail.com",
                            Image = "test.png",
                            Title = "The Giraffe Ladder Fund",
                            UserId = 5
                        });
                });

            modelBuilder.Entity("GivingGardenBE.Models.PaymentTypes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("PaymentTypeName")
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

                    b.Property<int>("OrganizationId")
                        .HasColumnType("integer");

                    b.Property<decimal>("PaymentAmount")
                        .HasColumnType("numeric");

                    b.Property<string>("PaymentType")
                        .HasColumnType("text");

                    b.Property<DateTime>("Subscribed_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.HasIndex("UserId");

                    b.ToTable("Subscriptions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            OrganizationId = 101,
                            PaymentAmount = 10.00m,
                            PaymentType = "paypal",
                            Subscribed_at = new DateTime(2025, 4, 17, 20, 40, 53, 767, DateTimeKind.Local).AddTicks(3153),
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            OrganizationId = 102,
                            PaymentAmount = 10.00m,
                            PaymentType = "debit",
                            Subscribed_at = new DateTime(2025, 4, 17, 20, 40, 53, 770, DateTimeKind.Local).AddTicks(1146),
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            OrganizationId = 103,
                            PaymentAmount = 10.00m,
                            PaymentType = "mastercard",
                            Subscribed_at = new DateTime(2025, 4, 17, 20, 40, 53, 770, DateTimeKind.Local).AddTicks(1178),
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            OrganizationId = 104,
                            PaymentAmount = 10.00m,
                            PaymentType = "cryptocurrency",
                            Subscribed_at = new DateTime(2025, 4, 17, 20, 40, 53, 770, DateTimeKind.Local).AddTicks(1183),
                            UserId = 4
                        },
                        new
                        {
                            Id = 5,
                            OrganizationId = 105,
                            PaymentAmount = 10.00m,
                            PaymentType = "visa",
                            Subscribed_at = new DateTime(2025, 4, 17, 20, 40, 53, 770, DateTimeKind.Local).AddTicks(1186),
                            UserId = 5
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
                            Image = "test.png",
                            Name = "Casey Cunningham"
                        },
                        new
                        {
                            Id = 2,
                            Email = "NoAllenTest@gmail.com",
                            Image = "test.png",
                            Name = "Noah Allen"
                        },
                        new
                        {
                            Id = 3,
                            Email = "MonesTest@gmail.com",
                            Image = "test.png",
                            Name = "Max Jones"
                        },
                        new
                        {
                            Id = 4,
                            Email = "TormusTest@gmail.com",
                            Image = "test.png",
                            Name = "Toren DeRamus"
                        },
                        new
                        {
                            Id = 5,
                            Email = "BSuttleTest@gmail.com",
                            Image = "test.png",
                            Name = "Biran Shuttles"
                        });
                });

            modelBuilder.Entity("OrganizationUser", b =>
                {
                    b.Property<int>("OrganizationsId")
                        .HasColumnType("integer");

                    b.Property<int>("UsersId")
                        .HasColumnType("integer");

                    b.HasKey("OrganizationsId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("OrganizationUser");
                });

            modelBuilder.Entity("GivingGardenBE.Models.Subscription", b =>
                {
                    b.HasOne("GivingGardenBE.Models.Organization", null)
                        .WithMany("Subscriptions")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GivingGardenBE.Models.User", null)
                        .WithMany("Subscriptions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OrganizationUser", b =>
                {
                    b.HasOne("GivingGardenBE.Models.Organization", null)
                        .WithMany()
                        .HasForeignKey("OrganizationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GivingGardenBE.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GivingGardenBE.Models.Organization", b =>
                {
                    b.Navigation("Subscriptions");
                });

            modelBuilder.Entity("GivingGardenBE.Models.User", b =>
                {
                    b.Navigation("Subscriptions");
                });
#pragma warning restore 612, 618
        }
    }
}
