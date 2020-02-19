using Microsoft.EntityFrameworkCore.Migrations;

namespace RFC.Migrations
{
    public partial class CustomerAffected : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomersAffected",
                table: "CreateNew",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomersAffected",
                table: "CreateNew");
        }
    }
}
