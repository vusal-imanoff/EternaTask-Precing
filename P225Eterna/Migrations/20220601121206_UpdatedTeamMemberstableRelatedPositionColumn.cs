using Microsoft.EntityFrameworkCore.Migrations;

namespace P225Eterna.Migrations
{
    public partial class UpdatedTeamMemberstableRelatedPositionColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PositionId",
                table: "TeamMembers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TeamMembers_PositionId",
                table: "TeamMembers",
                column: "PositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamMembers_Positions_PositionId",
                table: "TeamMembers",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeamMembers_Positions_PositionId",
                table: "TeamMembers");

            migrationBuilder.DropIndex(
                name: "IX_TeamMembers_PositionId",
                table: "TeamMembers");

            migrationBuilder.DropColumn(
                name: "PositionId",
                table: "TeamMembers");
        }
    }
}
