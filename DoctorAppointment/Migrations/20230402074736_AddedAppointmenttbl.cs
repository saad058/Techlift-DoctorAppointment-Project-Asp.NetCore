using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorAppointment.Migrations
{
    public partial class AddedAppointmenttbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblAppointment",
                columns: table => new
                {
                    AppointmentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppointmentDate = table.Column<string>(nullable: true),
                    PatID = table.Column<int>(nullable: false),
                    DocID = table.Column<int>(nullable: false),
                    AppointmentDay = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAppointment", x => x.AppointmentID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblAppointment");
        }
    }
}
