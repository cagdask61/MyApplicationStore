using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyApplicationStore.Persistence.Migrations
{
    public partial class migration_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VersionNumber",
                table: "Apps",
                type: "nvarchar(20)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VersionNumber",
                table: "Apps");
        }
    }
}
