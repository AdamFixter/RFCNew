using Microsoft.EntityFrameworkCore.Migrations;

namespace RFC.Migrations
{
    public partial class customerField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "user",
                table: "CreateNew");

            migrationBuilder.AddColumn<string>(
                name: "customers",
                table: "CreateNew",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "customers",
                table: "CreateNew");

            migrationBuilder.AddColumn<string>(
                name: "user",
                table: "CreateNew",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
