using Microsoft.EntityFrameworkCore.Migrations;

namespace Phd.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MajCode",
                table: "PhdStudent");

            migrationBuilder.AddColumn<string>(
                name: "MajorCode",
                table: "PhdStudent",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MajorCode",
                table: "PhdStudent");

            migrationBuilder.AddColumn<int>(
                name: "MajCode",
                table: "PhdStudent",
                nullable: false,
                defaultValue: 0);
        }
    }
}
