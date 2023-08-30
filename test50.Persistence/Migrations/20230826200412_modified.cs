using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace test50.Persistence.Migrations
{
    public partial class modified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdRoles",
                table: "UsersInRoles");

            migrationBuilder.DropColumn(
                name: "IdUsers",
                table: "UsersInRoles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "IdRoles",
                table: "UsersInRoles",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "IdUsers",
                table: "UsersInRoles",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
