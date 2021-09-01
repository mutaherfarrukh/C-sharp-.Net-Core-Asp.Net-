using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeddingPlanner.Migrations
{
    public partial class FirstMigration123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    SpiritAnimal = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "WedUsers",
                columns: table => new
                {
                    WeddingUserId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WedCoupleName1 = table.Column<string>(nullable: false),
                    WedCoupleName2 = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    WeddingAddress = table.Column<string>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    RegUserDataUserId = table.Column<int>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WedUsers", x => x.WeddingUserId);
                    table.ForeignKey(
                        name: "FK_WedUsers_Users_RegUserDataUserId",
                        column: x => x.RegUserDataUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RSVPUsers",
                columns: table => new
                {
                    RSVPId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WeddingId = table.Column<int>(nullable: false),
                    WeddingRSVPWeddingUserId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    RegUserUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RSVPUsers", x => x.RSVPId);
                    table.ForeignKey(
                        name: "FK_RSVPUsers_Users_RegUserUserId",
                        column: x => x.RegUserUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RSVPUsers_WedUsers_WeddingRSVPWeddingUserId",
                        column: x => x.WeddingRSVPWeddingUserId,
                        principalTable: "WedUsers",
                        principalColumn: "WeddingUserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RSVPUsers_RegUserUserId",
                table: "RSVPUsers",
                column: "RegUserUserId");

            migrationBuilder.CreateIndex(
                name: "IX_RSVPUsers_WeddingRSVPWeddingUserId",
                table: "RSVPUsers",
                column: "WeddingRSVPWeddingUserId");

            migrationBuilder.CreateIndex(
                name: "IX_WedUsers_RegUserDataUserId",
                table: "WedUsers",
                column: "RegUserDataUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RSVPUsers");

            migrationBuilder.DropTable(
                name: "WedUsers");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
