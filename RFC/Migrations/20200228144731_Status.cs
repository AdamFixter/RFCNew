using Microsoft.EntityFrameworkCore.Migrations;

namespace RFC.Migrations
{
    public partial class Status : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Approved",
                table: "CreateNew",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Approved",
                table: "CreateNew",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
