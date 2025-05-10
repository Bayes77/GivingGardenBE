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
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CategoryName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PaymentTypeName = table.Column<string>(type: "text", nullable: false)
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
                    FirebaseUid = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.UniqueConstraint("AK_Users_FirebaseUid", x => x.FirebaseUid);
                });

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Mission = table.Column<string>(type: "text", nullable: true),
                    Website = table.Column<string>(type: "text", nullable: true),
                    CategoryName = table.Column<string>(type: "text", nullable: false),
                    Created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Organizations_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "FirebaseUid");
                });

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    OrganizationId = table.Column<int>(type: "integer", nullable: true),
                    Subscribed_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    PaymentType = table.Column<string>(type: "text", nullable: true),
                    PayFrequency = table.Column<string>(type: "text", nullable: true),
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
                        principalColumn: "FirebaseUid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Education" },
                    { 2, "Environment" },
                    { 3, "Animal Welfare" },
                    { 4, "Humanitaraian Aid" },
                    { 5, "Community Development" }
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
                columns: new[] { "Id", "Email", "FirebaseUid", "Image", "Name" },
                values: new object[,]
                {
                    { 1, "CaseCunnTest@gmail.com", "9wNJQC9hfrMhjpdOUPD1wxjqLjE2", "https://ca.slack-edge.com/T03F2SDTJ-U078T3MSH0U-57f35b70c0e6-512", "Casey Cunningham" },
                    { 2, "NoAllenTest@gmail.com", "Pdi1E8scqodl78kPX57bcidHSzq2", "https://ca.slack-edge.com/T03F2SDTJ-U05MUF4KMNY-e42ee592a708-192", "Noah Allen" },
                    { 3, "MonesTest@gmail.com", "XdynYdPxtmTU4VghjX2paBdQC9b2", "https://ca.slack-edge.com/T03F2SDTJ-U078T3N3URJ-1d11def4d536-72", "Max Jones" },
                    { 4, "TormusTest@gmail.com", "AbCdefGhIJKlmnOPQRstUVwxYZ01", "https://ca.slack-edge.com/T03F2SDTJ-U078J0FDSES-82600e02198b-72", "Toren DeRamus" },
                    { 5, "BSuttleTest@gmail.com", "mNopQRstUVwxYZ0123ABCdefGhIJ", "https://ca.slack-edge.com/T03F2SDTJ-U078QJZUQ3U-8bc62e1cae81-512", "Biran Shuttles" },
                    { 6, "christopherpack17@gmail.com", "ZyxWVUTsrqponMLKJihgFEDCba98", "https://ca.slack-edge.com/T03F2SDTJ-U086UKR68LT-e9228b208df1-512", "Christopher Pack" },
                    { 7, "brocbuhler@gmail.com", "a1B2c3D4e5F6g7H8i9J0kLmNoPqR", "https://ca.slack-edge.com/T03F2SDTJ-U086UKR0JRZ-5292d6df3113-512", "Broc Buhler" }
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "CategoryName", "Created_at", "Description", "Email", "Image", "Mission", "Title", "UserId", "Website" },
                values: new object[,]
                {
                    { 101, "Community Development", new DateTime(2025, 5, 10, 10, 26, 20, 901, DateTimeKind.Local).AddTicks(7819), "Brings smiles and solar-powered radios to remote villages one playlist at a time.", "DWBtest.gmail.com", "https://images.openai.com/thumbnails/39a8828844b53eb51453e3cd9e306ec8.png", "Cultivating hope and sustainable futures through global community development, education, and agricultural empowerment.", "HopeHarvest International", "XdynYdPxtmTU4VghjX2paBdQC9b2", "HarvestInter@test.com" },
                    { 102, "Education", new DateTime(2025, 5, 10, 10, 26, 20, 901, DateTimeKind.Local).AddTicks(8030), "Delivers enchanted storybooks to children in magical lands (and a few underfunded libraries).", "BFBtest.gmail.com", "https://m.media-amazon.com/images/I/81ukSP5PrJL._AC_UF1000%2C1000_QL80_.jpg", "Expanding minds and opportunities by delivering books and educational resources to underserved communities around the world.", "Books for Beyond", "XdynYdPxtmTU4VghjX2paBdQC9b2", "Beyond@test.com" },
                    { 103, "Humanitarian Aid", new DateTime(2025, 5, 10, 10, 26, 20, 901, DateTimeKind.Local).AddTicks(8035), "Knits invisible scarves for people experiencing metaphorical winters.", "WOWtest.gmail.com", "https://www.shutterstock.com/image-photo/flock-white-pelicans-soars-gracefully-over-2603037941", "To deliver warmth, comfort, and hope to vulnerable individuals through seasonal support programs, emergency aid, and community-driven outreach initiatives.", "Wings of Warmth", "XdynYdPxtmTU4VghjX2paBdQC9b2", "WarmWing@test.com" },
                    { 104, "Environment", new DateTime(2025, 5, 10, 10, 26, 20, 901, DateTimeKind.Local).AddTicks(8037), "Sends love letters and biodegradable glitter to lonely sea creatures.", "OHPtest.gmail.com", "https://i0.wp.com/oceanblueproject.org/wp-content/uploads/2023/05/happy-world-ocean-day-activities-ocean-blue-project-cleanup.webp?fit=2048%2C1367&ssl=1", "To protect and nurture our oceans through grassroots conservation efforts, education, and community engagement, inspiring a global embrace of marine stewardship.", "Ocean Hug Project", "XdynYdPxtmTU4VghjX2paBdQC9b2", "OHP@test.com" },
                    { 105, "Animal Welfare", new DateTime(2025, 5, 10, 10, 26, 20, 901, DateTimeKind.Local).AddTicks(8040), "Helps vertically challenged animals reach their dreams (and the top shelf).", "TGLFtest.gmail.com", "https://media.istockphoto.com/id/543346734/photo/giraffe-in-the-library.jpg?s=2048x2048&w=is&k=20&c=PgjqCSR3ad0uzcPHpnR9ji6oAmuTJFAHhp0JDL8rpas=", "To elevate opportunities for conservation, education, and leadership through projects that help communities—and endangered giraffes—rise to new heights.", "The Giraffe Ladder Fund", "XdynYdPxtmTU4VghjX2paBdQC9b2", "GLF@test.com" },
                    { 106, "Humanitarian Aid", new DateTime(2025, 5, 10, 10, 26, 20, 901, DateTimeKind.Local).AddTicks(8046), "Helps friendless goobers get all the companions they need.", "goobers@example.com", "https://i1.sndcdn.com/avatars-000127116014-hqzcna-t240x240.jpg", "Bring all goobers together", "Visiting Goobers", "9wNJQC9hfrMhjpdOUPD1wxjqLjE2", "Goob@test.com" },
                    { 107, "Humanitarian Aid", new DateTime(2025, 5, 10, 10, 26, 20, 901, DateTimeKind.Local).AddTicks(8048), "Red shorts initiative, everyone deserves a pair. Polka dots are also allowed.", "theRedShorts@example.com", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQAyHT6BTbA-AKsM_-FIwE382ec-uIYKOE-Vg&s", "Shorts for days", "American Red Shorts", "9wNJQC9hfrMhjpdOUPD1wxjqLjE2", "shorts@test.com" },
                    { 108, "Humanitarian Aid", new DateTime(2025, 5, 10, 10, 26, 20, 901, DateTimeKind.Local).AddTicks(8051), "Help the salvation army by adding to my bank account.", "johnelmo@example.com", "https://st2.depositphotos.com/3758943/6040/i/450/depositphotos_60400957-stock-photo-the-man-in-the-office.jpg", "We shall support the cause", "The Salvation Army’s biggest supporter", "9wNJQC9hfrMhjpdOUPD1wxjqLjE2", "Broc@test.com" },
                    { 109, "Education", new DateTime(2025, 5, 10, 10, 26, 20, 901, DateTimeKind.Local).AddTicks(8053), "One of the orgs yeah yeah", "brocbuhler@gmail.com", "https://i.ytimg.com/vi/k9KAc23W48s/sddefault.jpg", "Brocs Retirment", "Broc's Bank Account", "9wNJQC9hfrMhjpdOUPD1wxjqLjE2", "Broc@test.com" },
                    { 110, "Animal Welfare", new DateTime(2025, 5, 10, 10, 26, 20, 901, DateTimeKind.Local).AddTicks(8056), "Give me money for cat NOW.", "givecat@gmail.com", "https://media.npr.org/assets/img/2023/12/12/gettyimages-1054147940-627235e01fb63b4644bec84204c259f0a343e35b.jpg", "Rescue all felines", "Cat", "9wNJQC9hfrMhjpdOUPD1wxjqLjE2", "cat@test.com" },
                    { 111, "Environment", new DateTime(2025, 5, 10, 10, 26, 20, 901, DateTimeKind.Local).AddTicks(8058), "We are like super dark and edgy bro look at our spiky ghost king crowns and our exploding orc birth sacs.", "cuteSaronPIcs@mordor.com", "https://i.redd.it/the-two-towers-vs-return-of-the-king-mordor-v0-b352b0r01tyb1.jpg?width=3816&format=pjpg&auto=webp&s=c3f5494c21e1ccfc774b3bb8649fcfc8a2670ea3", "Bring about the rise of mordor", "The Dark Organization", "9wNJQC9hfrMhjpdOUPD1wxjqLjE2", "mordor@test.com" }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "Id", "OrganizationId", "PayFrequency", "PaymentAmount", "PaymentType", "Subscribed_at", "UserId" },
                values: new object[,]
                {
                    { 1, 108, "Monthly", 10.00m, "paypal", new DateTime(2025, 5, 10, 10, 26, 20, 898, DateTimeKind.Local).AddTicks(2195), "9wNJQC9hfrMhjpdOUPD1wxjqLjE2" },
                    { 2, 102, "Quarterly", 10.00m, "debit", new DateTime(2025, 5, 10, 10, 26, 20, 900, DateTimeKind.Local).AddTicks(9237), "9wNJQC9hfrMhjpdOUPD1wxjqLjE2" },
                    { 3, 106, "Monthly", 10.00m, "mastercard", new DateTime(2025, 5, 10, 10, 26, 20, 900, DateTimeKind.Local).AddTicks(9278), "9wNJQC9hfrMhjpdOUPD1wxjqLjE2" },
                    { 4, 104, "Weekly", 10.00m, "cryptocurrency", new DateTime(2025, 5, 10, 10, 26, 20, 900, DateTimeKind.Local).AddTicks(9281), "XdynYdPxtmTU4VghjX2paBdQC9b2" },
                    { 5, 105, "Yearly", 10.00m, "visa", new DateTime(2025, 5, 10, 10, 26, 20, 900, DateTimeKind.Local).AddTicks(9283), "XdynYdPxtmTU4VghjX2paBdQC9b2" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_UserId",
                table: "Organizations",
                column: "UserId");

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
                name: "Categories");

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
