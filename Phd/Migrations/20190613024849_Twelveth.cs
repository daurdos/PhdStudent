using Microsoft.EntityFrameworkCore.Migrations;

namespace Phd.Migrations
{
    public partial class Twelveth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vote_PhdStudent_PhdStudentId1",
                table: "Vote");

            migrationBuilder.DropIndex(
                name: "IX_Vote_PhdStudentId1",
                table: "Vote");

            migrationBuilder.DropColumn(
                name: "PhdStudentId1",
                table: "Vote");

            migrationBuilder.AlterColumn<int>(
                name: "PhdStudentId",
                table: "Vote",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vote_PhdStudentId",
                table: "Vote",
                column: "PhdStudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vote_PhdStudent_PhdStudentId",
                table: "Vote",
                column: "PhdStudentId",
                principalTable: "PhdStudent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vote_PhdStudent_PhdStudentId",
                table: "Vote");

            migrationBuilder.DropIndex(
                name: "IX_Vote_PhdStudentId",
                table: "Vote");

            migrationBuilder.AlterColumn<string>(
                name: "PhdStudentId",
                table: "Vote",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PhdStudentId1",
                table: "Vote",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vote_PhdStudentId1",
                table: "Vote",
                column: "PhdStudentId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Vote_PhdStudent_PhdStudentId1",
                table: "Vote",
                column: "PhdStudentId1",
                principalTable: "PhdStudent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
