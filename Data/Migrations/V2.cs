using Microsoft.EntityFrameworkCore.Migrations;

namespace SixBeeAppointments.Data.Migrations
{
    public class V2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Appointments",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentMethodPresent",
                table: "Appointments");
        }
    }
}
