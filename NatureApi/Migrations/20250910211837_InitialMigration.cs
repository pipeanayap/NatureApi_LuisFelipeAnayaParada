using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NatureApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Amenity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amenity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Place",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    ElevationMeters = table.Column<int>(type: "int", nullable: false),
                    Accessible = table.Column<bool>(type: "bit", nullable: false),
                    EntryFee = table.Column<double>(type: "float", nullable: false),
                    OpeningHours = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Place", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Photo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlaceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photo_Place_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Place",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlaceAmenity",
                columns: table => new
                {
                    PlaceId = table.Column<int>(type: "int", nullable: false),
                    AmenityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaceAmenity", x => new { x.PlaceId, x.AmenityId });
                    table.ForeignKey(
                        name: "FK_PlaceAmenity_Amenity_AmenityId",
                        column: x => x.AmenityId,
                        principalTable: "Amenity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlaceAmenity_Place_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Place",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlaceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Review_Place_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Place",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DistanceKm = table.Column<double>(type: "float", nullable: false),
                    EstimatedTimeMinutes = table.Column<int>(type: "int", nullable: false),
                    Difficulty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsLoop = table.Column<bool>(type: "bit", nullable: false),
                    PlaceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trail_Place_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Place",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Amenity",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "WiFi Gratuito" },
                    { 2, "Estacionamiento" },
                    { 3, "Acceso para Discapacitados" },
                    { 4, "Cafetería" },
                    { 5, "Tienda de Recuerdos" },
                    { 6, "Audioguía" },
                    { 7, "Baños Públicos" },
                    { 8, "Área de Picnic" },
                    { 9, "Tours Guiados" },
                    { 10, "Taquillas" },
                    { 11, "Área Infantil" },
                    { 12, "Jardines" },
                    { 13, "Ascensor" },
                    { 14, "Seguridad 24h" },
                    { 15, "Información Turística" }
                });

            migrationBuilder.InsertData(
                table: "Place",
                columns: new[] { "Id", "Accessible", "Category", "CreatedAt", "Description", "ElevationMeters", "EntryFee", "Latitude", "Longitude", "Name", "OpeningHours" },
                values: new object[,]
                {
                    { 1, true, "Museo", new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Una de las pinacotecas más importantes del mundo, alberga obras maestras de Velázquez, Goya y El Greco", 655, 15.0, 40.413800000000002, -3.6920999999999999, "Museo del Prado", "Lunes a sábado 10:00-20:00, Domingos 10:00-19:00" },
                    { 2, true, "Arquitectura", new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Basílica diseñada por Antoni Gaudí, obra maestra del modernismo catalán aún en construcción", 152, 26.0, 41.403599999999997, 2.1743999999999999, "La Sagrada Familia", "Abril-septiembre 9:00-20:00, Octubre-marzo 9:00-18:00" },
                    { 3, false, "Patrimonio Histórico", new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Complejo palaciego y fortaleza nazarí que refleja el arte andalusí en su máximo esplendor", 738, 19.09, 37.177300000000002, -3.5985999999999998, "Alhambra", "Octubre-marzo 8:30-18:00, Abril-septiembre 8:30-20:00" },
                    { 4, true, "Parque", new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Histórico parque público de Madrid, perfecto para pasear y relajarse en el corazón de la ciudad", 650, 0.0, 40.415300000000002, -3.6844000000000001, "Parque del Retiro", "Octubre-marzo 6:00-22:00, Abril-septiembre 6:00-24:00" },
                    { 5, true, "Arquitectura Religiosa", new DateTime(2023, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "La catedral gótica más grande del mundo, alberga la tumba de Cristóbal Colón", 11, 12.0, 37.385899999999999, -5.9932999999999996, "Catedral de Sevilla", "Lunes a sábado 11:00-17:00, Domingos 14:30-18:00" },
                    { 6, true, "Plaza Histórica", new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Plaza barroca considerada una de las más bellas de España, centro neurálgico de Salamanca", 802, 0.0, 40.970100000000002, -5.6635, "Plaza Mayor", "24 horas" }
                });

            migrationBuilder.InsertData(
                table: "Photo",
                columns: new[] { "Id", "PlaceId", "Url" },
                values: new object[,]
                {
                    { 1, 1, "https://images.unsplash.com/photo-1578662996442-48f60103fc96" },
                    { 2, 1, "https://images.unsplash.com/photo-1571678264022-e97ed89a33b4" },
                    { 3, 1, "https://images.unsplash.com/photo-1594736797933-d0601ba19be5" },
                    { 4, 2, "https://images.unsplash.com/photo-1583422409516-2895a77efded" },
                    { 5, 2, "https://images.unsplash.com/photo-1539650116574-75c0c6d00f2f" },
                    { 6, 2, "https://images.unsplash.com/photo-1511527844068-006b95d162c2" },
                    { 7, 3, "https://images.unsplash.com/photo-1558642452-9d2a7deb7f62" },
                    { 8, 3, "https://images.unsplash.com/photo-1605282003441-4828c8b69cd3" },
                    { 9, 3, "https://images.unsplash.com/photo-1571663852432-bb0f4e7db0b2" },
                    { 10, 4, "https://images.unsplash.com/photo-1584464491033-06628f3a6b7b" },
                    { 11, 4, "https://images.unsplash.com/photo-1590075865b93-5b81e33c1321" },
                    { 12, 4, "https://images.unsplash.com/photo-1557804506-669a67965ba0" },
                    { 13, 5, "https://images.unsplash.com/photo-1571663818459-0bcc3c55a49b" },
                    { 14, 5, "https://images.unsplash.com/photo-1633888080670-7c5ad7e6b28d" },
                    { 15, 5, "https://images.unsplash.com/photo-1589900670714-25370142cd17" },
                    { 16, 6, "https://images.unsplash.com/photo-1546600799-4d0a5d5a158a" },
                    { 17, 6, "https://images.unsplash.com/photo-1571663870103-2dd96e4b9c63" },
                    { 18, 6, "https://images.unsplash.com/photo-1506905925346-21bda4d32df4" }
                });

            migrationBuilder.InsertData(
                table: "Trail",
                columns: new[] { "Id", "Difficulty", "DistanceKm", "EstimatedTimeMinutes", "IsLoop", "Name", "Path", "PlaceId" },
                values: new object[,]
                {
                    { 1, "Moderada", 2.5, 180, false, "Ruta de los Palacios Nazaríes", "Entrada → Alcazaba → Palacios Nazaríes → Generalife", 3 },
                    { 2, "Fácil", 3.2000000000000002, 90, true, "Sendero del Estanque", "Puerta de Alcalá → Estanque → Palacio de Cristal → Rosaleda", 4 },
                    { 3, "Fácil", 1.8, 120, false, "Ruta de las Obras Maestras", "Velázquez → Goya → El Greco → Rubens", 1 },
                    { 4, "Moderada", 0.80000000000000004, 75, false, "Tour de las Torres", "Entrada → Nave → Torres → Museo", 2 },
                    { 5, "Moderada", 1.2, 60, false, "Ruta de la Giralda", "Catedral → Capilla Mayor → Giralda → Patio de los Naranjos", 5 },
                    { 6, "Fácil", 2.7999999999999998, 45, true, "Recorrido Histórico", "Plaza Mayor → Casa de las Conchas → Universidad → Catedral Vieja", 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Photo_PlaceId",
                table: "Photo",
                column: "PlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_PlaceAmenity_AmenityId",
                table: "PlaceAmenity",
                column: "AmenityId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_PlaceId",
                table: "Review",
                column: "PlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Trail_PlaceId",
                table: "Trail",
                column: "PlaceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photo");

            migrationBuilder.DropTable(
                name: "PlaceAmenity");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "Trail");

            migrationBuilder.DropTable(
                name: "Amenity");

            migrationBuilder.DropTable(
                name: "Place");
        }
    }
}
