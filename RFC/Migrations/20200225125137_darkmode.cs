using Microsoft.EntityFrameworkCore.Migrations;

namespace RFC.Migrations
{
    public partial class darkmode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDarkMode",
                table: "User",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDarkMode",
                table: "User");
        }
    }
}
