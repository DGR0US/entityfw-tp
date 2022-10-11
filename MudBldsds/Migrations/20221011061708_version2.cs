using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MudBldsds.Migrations
{
    public partial class version2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Lastname1",
                table: "Students",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Lastname2",
                table: "Students",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Lastname1",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Lastname2",
                table: "Students");
        }
    }
}
