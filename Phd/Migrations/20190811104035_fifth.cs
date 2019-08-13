using Microsoft.EntityFrameworkCore.Migrations;

namespace Phd.Migrations
{
    public partial class fifth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_DisCouncil_DisCouncilId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_PhdStudent_DisCouncil_DisCouncilId",
                table: "PhdStudent");

            migrationBuilder.DropIndex(
                name: "IX_PhdStudent_DisCouncilId",
                table: "PhdStudent");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_DisCouncilId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DisCouncilId",
                table: "PhdStudent");

            migrationBuilder.DropColumn(
                name: "DisCouncilId",
                table: "AspNetUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DisCouncilId",
                table: "PhdStudent",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DisCouncilId",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PhdStudent_DisCouncilId",
                table: "PhdStudent",
                column: "DisCouncilId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DisCouncilId",
                table: "AspNetUsers",
                column: "DisCouncilId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_DisCouncil_DisCouncilId",
                table: "AspNetUsers",
                column: "DisCouncilId",
                principalTable: "DisCouncil",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhdStudent_DisCouncil_DisCouncilId",
                table: "PhdStudent",
                column: "DisCouncilId",
                principalTable: "DisCouncil",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
