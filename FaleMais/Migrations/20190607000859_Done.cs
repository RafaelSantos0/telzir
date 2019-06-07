using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FaleMais.Migrations
{
    public partial class Done : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Plane",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Origin = table.Column<string>(nullable: true),
                    Destiny = table.Column<string>(nullable: true),
                    PricePerMinute = table.Column<double>(nullable: false),
                    Time = table.Column<TimeSpan>(nullable: false),
                    SpeakMorePlane = table.Column<int>(nullable: false),
                    CallValue = table.Column<double>(nullable: false),
                    PlaneCallValue = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plane", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Plane");
        }
    }
}
