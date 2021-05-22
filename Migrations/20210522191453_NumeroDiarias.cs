using Microsoft.EntityFrameworkCore.Migrations;

namespace hotelAPI.Migrations
{
    public partial class NumeroDiarias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumeroDiarias",
                table: "Reserva",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumeroDiarias",
                table: "Reserva");
        }
    }
}
