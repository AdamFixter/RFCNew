using Microsoft.EntityFrameworkCore.Migrations;

namespace RFC.Migrations
{
    public partial class withoutDarkMode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDarkMode",
                table: "User");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDarkMode",
                table: "User",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
