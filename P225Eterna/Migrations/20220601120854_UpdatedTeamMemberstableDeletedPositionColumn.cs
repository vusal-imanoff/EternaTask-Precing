using Microsoft.EntityFrameworkCore.Migrations;

namespace P225Eterna.Migrations
{
    public partial class UpdatedTeamMemberstableDeletedPositionColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Position",
                table: "TeamMembers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "TeamMembers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
