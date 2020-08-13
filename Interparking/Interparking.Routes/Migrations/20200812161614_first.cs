using Microsoft.EntityFrameworkCore.Migrations;

namespace Interparking.Routes.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parkings",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parkings", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdClient = table.Column<string>(nullable: false),
                    Distance = table.Column<double>(type: "float", nullable: false),
                    Fuel = table.Column<double>(type: "float", nullable: false),
                    ParkingDeparture_Longitude = table.Column<string>(nullable: true),
                    ParkingDeparture_Lattitude = table.Column<string>(nullable: true),
                    Departure = table.Column<string>(nullable: true),
                    ParkingDestination_Longitude = table.Column<string>(nullable: true),
                    ParkingDestination_Lattitude = table.Column<string>(nullable: true),
                    Destination = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Parkings",
                columns: new[] { "ID", "Address", "Name" },
                values: new object[,]
                {
                    { 1, "Sparrendreef 103, 8300 Knokke-Heist", "Minigolf (Knokke-Heist)" },
                    { 2, "Place d'Armes, 5000 Namur", "Beffroi (Namur)" },
                    { 3, "Quai de la Batte, 4000 Liège", "Saint Georges (Liège)" },
                    { 4, "Rue du Progrès 80, 1000 Bruxelles", "CCN (Bruxelles)" },
                    { 5, "Boulevard de la Woluwe, 70 bte 127, 1200 Bruxelles", "Woluwe Shopping Center (Bruxelles)" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parkings");

            migrationBuilder.DropTable(
                name: "Routes");
        }
    }
}
