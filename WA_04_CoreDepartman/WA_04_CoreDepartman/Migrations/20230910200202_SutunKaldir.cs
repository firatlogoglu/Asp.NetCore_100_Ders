using Microsoft.EntityFrameworkCore.Migrations;

namespace WA_04_CoreDepartman.Migrations
{
    public partial class SutunKaldir : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Detay",
                table: "Departmen");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Detay",
                table: "Departmen",
                nullable: true);
        }
    }
}
