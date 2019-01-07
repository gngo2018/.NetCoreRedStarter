using Microsoft.EntityFrameworkCore.Migrations;

namespace RedStarter.Database.Migrations
{
    public partial class owneridtonote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "NoteTableAccess",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "NoteTableAccess");
        }
    }
}
