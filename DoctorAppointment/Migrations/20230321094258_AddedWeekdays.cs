using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorAppointment.Migrations
{
    public partial class AddedWeekdays : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WeekdaysId",
                table: "tblDoctor",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "tblWeekDays",
                columns: table => new
                {
                    WeekdaysId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Monday = table.Column<bool>(nullable: false),
                    Tuesday = table.Column<bool>(nullable: false),
                    Wednesday = table.Column<bool>(nullable: false),
                    Thursday = table.Column<bool>(nullable: false),
                    Friday = table.Column<bool>(nullable: false),
                    Saturday = table.Column<bool>(nullable: false),
                    Sunday = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblWeekDays", x => x.WeekdaysId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblWeekDays");

            migrationBuilder.DropColumn(
                name: "WeekdaysId",
                table: "tblDoctor");
        }
    }
}
