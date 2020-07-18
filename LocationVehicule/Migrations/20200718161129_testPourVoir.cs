using Microsoft.EntityFrameworkCore.Migrations;

namespace LocationVehicule.Migrations
{
    public partial class testPourVoir : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Voiture",
                table: "Voiture");

            migrationBuilder.RenameTable(
                name: "Voiture",
                newName: "Voiture1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Voiture1",
                table: "Voiture1",
                column: "VoitureId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Voiture1",
                table: "Voiture1");

            migrationBuilder.RenameTable(
                name: "Voiture1",
                newName: "Voiture");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Voiture",
                table: "Voiture",
                column: "VoitureId");
        }
    }
}
