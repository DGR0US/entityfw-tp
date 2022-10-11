using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MudBldsds.Migrations
{
    public partial class versiorg5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Lastname1",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Lastname2",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Students");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<byte[]>(
                name: "Photo",
                table: "Students",
                type: "bytea",
                nullable: false,
                defaultValue: new byte[0]);
        }
    }
}
