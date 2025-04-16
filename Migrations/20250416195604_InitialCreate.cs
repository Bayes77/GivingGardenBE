using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GivingGardenBE.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    OrganizationId = table.Column<int>(type: "integer", nullable: false),
                    Subscribed_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    PaymentType = table.Column<string>(type: "text", nullable: true),
                    PaymentAmount = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    SubscriptionId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Organizations_Subscriptions_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "Subscriptions",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Description", "Email", "Image", "SubscriptionId", "Title", "UserId" },
                values: new object[,]
                {
                    { 101, "Brings smiles and solar-powered radios to remote villages one playlist at a time.", "DWBtest.gmail.com", "test.png", null, "HopeHarvest International", 1 },
                    { 102, "Delivers enchanted storybooks to children in magical lands (and a few underfunded libraries).", "BFBtest.gmail.com", "test.png", null, "Books for Beyond", 2 },
                    { 103, "Knits invisible scarves for people experiencing metaphorical winters.", "WOWtest.gmail.com", "test.png", null, "Wings of Warmth", 3 },
                    { 104, "Sends love letters and biodegradable glitter to lonely sea creatures.", "OHPtest.gmail.com", "test.png", null, "Ocean Hug Project", 4 },
                    { 105, "Helps vertically challenged animals reach their dreams (and the top shelf).", "TGLFtest.gmail.com", "test.png", null, "The Giraffe Ladder Fund", 5 }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "Id", "OrganizationId", "PaymentAmount", "PaymentType", "Subscribed_at", "UserId" },
                values: new object[,]
                {
                    { 1, 101, 10.00m, "paypal", new DateTime(2025, 4, 16, 14, 56, 3, 812, DateTimeKind.Local).AddTicks(1712), 1 },
                    { 2, 102, 10.00m, "debit", new DateTime(2025, 4, 16, 14, 56, 3, 815, DateTimeKind.Local).AddTicks(114), 2 },
                    { 3, 103, 10.00m, "mastercard", new DateTime(2025, 4, 16, 14, 56, 3, 815, DateTimeKind.Local).AddTicks(141), 3 },
                    { 4, 104, 10.00m, "paypal", new DateTime(2025, 4, 16, 14, 56, 3, 815, DateTimeKind.Local).AddTicks(145), 4 },
                    { 5, 105, 10.00m, "visa", new DateTime(2025, 4, 16, 14, 56, 3, 815, DateTimeKind.Local).AddTicks(148), 5 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Image", "Name" },
                values: new object[,]
                {
                    { 1, "CaseCunnTest@gmail.com", "test.png", "Casey Cunningham" },
                    { 2, "NoAllenTest@gmail.com", "test.png", "Noah Allen" },
                    { 3, "MonesTest@gmail.com", "test.png", "Max Jones" },
                    { 4, "TormusTest@gmail.com", "test.png", "Toren DeRamus" },
                    { 5, "BSuttleTest@gmail.com", "test.png", "Biran Shuttles" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_SubscriptionId",
                table: "Organizations",
                column: "SubscriptionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Subscriptions");
        }
    }
}
