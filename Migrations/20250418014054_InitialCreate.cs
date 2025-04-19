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
                name: "Organizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PaymentTypeName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTypes", x => x.Id);
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
                name: "OrganizationUser",
                columns: table => new
                {
                    OrganizationsId = table.Column<int>(type: "integer", nullable: false),
                    UsersId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationUser", x => new { x.OrganizationsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_OrganizationUser_Organizations_OrganizationsId",
                        column: x => x.OrganizationsId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrganizationUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    OrganizationId = table.Column<int>(type: "integer", nullable: false),
                    Subscribed_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    PaymentType = table.Column<string>(type: "text", nullable: true),
                    PaymentAmount = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subscriptions_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Subscriptions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Description", "Email", "Image", "Title", "UserId" },
                values: new object[,]
                {
                    { 101, "Brings smiles and solar-powered radios to remote villages one playlist at a time.", "DWBtest.gmail.com", "test.png", "HopeHarvest International", 1 },
                    { 102, "Delivers enchanted storybooks to children in magical lands (and a few underfunded libraries).", "BFBtest.gmail.com", "test.png", "Books for Beyond", 2 },
                    { 103, "Knits invisible scarves for people experiencing metaphorical winters.", "WOWtest.gmail.com", "test.png", "Wings of Warmth", 3 },
                    { 104, "Sends love letters and biodegradable glitter to lonely sea creatures.", "OHPtest.gmail.com", "test.png", "Ocean Hug Project", 4 },
                    { 105, "Helps vertically challenged animals reach their dreams (and the top shelf).", "TGLFtest.gmail.com", "test.png", "The Giraffe Ladder Fund", 5 }
                });

            migrationBuilder.InsertData(
                table: "PaymentTypes",
                columns: new[] { "Id", "PaymentTypeName" },
                values: new object[,]
                {
                    { 1, "Mastercard" },
                    { 2, "PayPal" },
                    { 3, "Visa" },
                    { 4, "Cryptocurrency" },
                    { 5, "Debit" }
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

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "Id", "OrganizationId", "PaymentAmount", "PaymentType", "Subscribed_at", "UserId" },
                values: new object[,]
                {
                    { 1, 101, 10.00m, "paypal", new DateTime(2025, 4, 17, 20, 40, 53, 767, DateTimeKind.Local).AddTicks(3153), 1 },
                    { 2, 102, 10.00m, "debit", new DateTime(2025, 4, 17, 20, 40, 53, 770, DateTimeKind.Local).AddTicks(1146), 2 },
                    { 3, 103, 10.00m, "mastercard", new DateTime(2025, 4, 17, 20, 40, 53, 770, DateTimeKind.Local).AddTicks(1178), 3 },
                    { 4, 104, 10.00m, "cryptocurrency", new DateTime(2025, 4, 17, 20, 40, 53, 770, DateTimeKind.Local).AddTicks(1183), 4 },
                    { 5, 105, 10.00m, "visa", new DateTime(2025, 4, 17, 20, 40, 53, 770, DateTimeKind.Local).AddTicks(1186), 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationUser_UsersId",
                table: "OrganizationUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_OrganizationId",
                table: "Subscriptions",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_UserId",
                table: "Subscriptions",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrganizationUser");

            migrationBuilder.DropTable(
                name: "PaymentTypes");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
