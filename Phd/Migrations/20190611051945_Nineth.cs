using Microsoft.EntityFrameworkCore.Migrations;

namespace Phd.Migrations
{
    public partial class Nineth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vote_PhdStudent_PhdStudentId",
                table: "Vote");

            migrationBuilder.AlterColumn<int>(
                name: "PhdStudentId",
                table: "Vote",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Vote_PhdStudent_PhdStudentId",
                table: "Vote",
                column: "PhdStudentId",
                principalTable: "PhdStudent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vote_PhdStudent_PhdStudentId",
                table: "Vote");

            migrationBuilder.AlterColumn<int>(
                name: "PhdStudentId",
                table: "Vote",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Vote_PhdStudent_PhdStudentId",
                table: "Vote",
                column: "PhdStudentId",
                principalTable: "PhdStudent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
