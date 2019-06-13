using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Phd.Migrations
{
    public partial class fifteenth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vote_PhdStudent_PhdStudentId1",
                table: "Vote");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vote",
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
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Vote",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vote",
                table: "Vote",
                column: "PhdStudentId");

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

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vote",
                table: "Vote");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Vote",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "PhdStudentId",
                table: "Vote",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "PhdStudentId1",
                table: "Vote",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vote",
                table: "Vote",
                column: "Id");

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
