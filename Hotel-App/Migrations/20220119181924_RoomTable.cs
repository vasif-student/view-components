using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_App.Migrations
{
    public partial class RoomTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Badge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BedIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfPeople = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SquareIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Square = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoomType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PerNight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookmarkIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reservation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rooms");
        }
    }
}
