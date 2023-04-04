using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorAppointment.Migrations
{
    public partial class IntialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblWeekDays");

            migrationBuilder.DropColumn(
                name: "Friday",
                table: "tblDoctor");

            migrationBuilder.DropColumn(
                name: "Monday",
                table: "tblDoctor");

            migrationBuilder.DropColumn(
                name: "Saturday",
                table: "tblDoctor");

            migrationBuilder.DropColumn(
                name: "Sunday",
                table: "tblDoctor");

            migrationBuilder.DropColumn(
                name: "Thursday",
                table: "tblDoctor");

            migrationBuilder.DropColumn(
                name: "Tuesday",
                table: "tblDoctor");

            migrationBuilder.DropColumn(
                name: "Wednesday",
                table: "tblDoctor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Friday",
                table: "tblDoctor",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Monday",
                table: "tblDoctor",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Saturday",
                table: "tblDoctor",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Sunday",
                table: "tblDoctor",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Thursday",
                table: "tblDoctor",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Tuesday",
                table: "tblDoctor",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Wednesday",
                table: "tblDoctor",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "tblWeekDays",
                columns: table => new
                {
                    WeekdaysId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblWeekDays", x => x.WeekdaysId);
                });
        }
    }
}
