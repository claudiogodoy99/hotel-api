using Microsoft.EntityFrameworkCore.Migrations;

namespace hotelAPI.Migrations
{
    public partial class ChangingProName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Reserva",
                newName: "ReservaId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Quarto",
                newName: "QuartoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReservaId",
                table: "Reserva",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "QuartoId",
                table: "Quarto",
                newName: "Id");
        }
    }
}
