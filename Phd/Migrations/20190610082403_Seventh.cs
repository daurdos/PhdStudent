using Microsoft.EntityFrameworkCore.Migrations;

namespace Phd.Migrations
{
    public partial class Seventh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Voice",
                table: "PhdStudent");

            migrationBuilder.AlterColumn<string>(
                name: "Voice",
                table: "Vote",
                nullable: true,
                oldClrType: typeof(bool));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Voice",
                table: "Vote",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Voice",
                table: "PhdStudent",
                nullable: true);
        }
    }
}
