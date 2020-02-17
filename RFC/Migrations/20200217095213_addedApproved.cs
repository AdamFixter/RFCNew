using Microsoft.EntityFrameworkCore.Migrations;

namespace RFC.Migrations
{
    public partial class addedApproved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Approved",
                table: "CreateNew",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Approved",
                table: "CreateNew");
        }
    }
}
