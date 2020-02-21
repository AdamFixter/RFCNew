using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RFC.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CreateNew",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Priority = table.Column<int>(nullable: false),
                    ChangeDescription = table.Column<string>(nullable: false),
                    ReasonForChange = table.Column<string>(nullable: false),
                    Product = table.Column<int>(nullable: false),
                    SystemAffected = table.Column<string>(nullable: false),
                    customers = table.Column<string>(nullable: false),
                    CustomersAffected = table.Column<int>(nullable: false),
                    ServiceImpact = table.Column<bool>(nullable: false),
                    RiskOfChange = table.Column<string>(nullable: false),
                    RiskNoChange = table.Column<string>(nullable: false),
                    VerifyAfter = table.Column<string>(nullable: false),
                    RollBackPlan = table.Column<string>(nullable: false),
                    DueDate = table.Column<DateTime>(nullable: false),
                    WhyDueDate = table.Column<string>(nullable: false),
                    WhoPerforming = table.Column<string>(nullable: false),
                    Approved = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreateNew", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Role = table.Column<int>(nullable: false),
                    DomainUser = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CreateNew");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
