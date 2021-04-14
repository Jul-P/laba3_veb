using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Storege.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    Number = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Hobbies",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    hobby = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbies", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Prepods",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    Lastname = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prepods", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    Result = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Stependias",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    Kek = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stependias", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Predmets",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    Nazvanie = table.Column<string>(nullable: false),
                    gPrepodId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Predmets", x => x.id);
                    table.ForeignKey(
                        name: "FK_Predmets_Prepods_gPrepodId",
                        column: x => x.gPrepodId,
                        principalTable: "Prepods",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Predmets_gPrepodId",
                table: "Predmets",
                column: "gPrepodId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Hobbies");

            migrationBuilder.DropTable(
                name: "Predmets");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "Stependias");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Prepods");
        }
    }
}
