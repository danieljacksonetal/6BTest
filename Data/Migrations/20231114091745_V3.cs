using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SixBeeAppointments.Data.Migrations
{
    public partial class V3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IApproved",
                table: "Appointments",
                newName: "IsApproved");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsApproved",
                table: "Appointments",
                newName: "IApproved");
        }
    }
}
