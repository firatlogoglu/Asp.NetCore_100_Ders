using Microsoft.EntityFrameworkCore.Migrations;

namespace WA_04_CoreDepartman.Migrations
{
    public partial class Test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmanID",
                table: "Personels",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personels_DepartmanID",
                table: "Personels",
                column: "DepartmanID");

            migrationBuilder.AddForeignKey(
                name: "FK_Personels_Departmen_DepartmanID",
                table: "Personels",
                column: "DepartmanID",
                principalTable: "Departmen",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personels_Departmen_DepartmanID",
                table: "Personels");

            migrationBuilder.DropIndex(
                name: "IX_Personels_DepartmanID",
                table: "Personels");

            migrationBuilder.DropColumn(
                name: "DepartmanID",
                table: "Personels");
        }
    }
}
