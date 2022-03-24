using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieAppCore.DAL.Migrations
{
    public partial class createdtheatremodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "theatre",
                columns: table => new
                {
                    ThatereId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_theatre", x => x.ThatereId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "theatre");
        }
    }
}
