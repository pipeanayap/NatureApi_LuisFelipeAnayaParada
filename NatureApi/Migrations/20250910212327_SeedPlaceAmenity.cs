using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NatureApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedPlaceAmenity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PlaceAmenity",
                columns: new[] { "AmenityId", "PlaceId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 3, 1 },
                    { 4, 1 },
                    { 5, 1 },
                    { 6, 1 },
                    { 7, 1 },
                    { 10, 1 },
                    { 14, 1 },
                    { 15, 1 },
                    { 1, 2 },
                    { 3, 2 },
                    { 5, 2 },
                    { 6, 2 },
                    { 7, 2 },
                    { 9, 2 },
                    { 13, 2 },
                    { 14, 2 },
                    { 15, 2 },
                    { 1, 3 },
                    { 2, 3 },
                    { 4, 3 },
                    { 5, 3 },
                    { 6, 3 },
                    { 7, 3 },
                    { 9, 3 },
                    { 12, 3 },
                    { 14, 3 },
                    { 15, 3 },
                    { 1, 4 },
                    { 3, 4 },
                    { 7, 4 },
                    { 8, 4 },
                    { 11, 4 },
                    { 12, 4 },
                    { 14, 4 },
                    { 15, 4 },
                    { 1, 5 },
                    { 3, 5 },
                    { 5, 5 },
                    { 6, 5 },
                    { 7, 5 },
                    { 9, 5 },
                    { 14, 5 },
                    { 15, 5 },
                    { 1, 6 },
                    { 3, 6 },
                    { 4, 6 },
                    { 7, 6 },
                    { 14, 6 },
                    { 15, 6 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 15, 1 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 13, 2 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 14, 2 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 15, 2 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 12, 3 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 14, 3 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 15, 3 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 11, 4 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 12, 4 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 14, 4 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 15, 4 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 9, 5 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 14, 5 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 15, 5 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 14, 6 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 15, 6 });
        }
    }
}
