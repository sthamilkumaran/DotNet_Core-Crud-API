using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqtf", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "test", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "gdsyghsabhsvbhhsb", "https://tk-resume.000webhostapp.com/assets/img/profile1.jpeg", "Tamil", 5, 100.0, 100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "test", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "gdsyghsabhsvbhhsb", "https://tk-resume.000webhostapp.com/assets/img/profile1.jpeg", "Tamilk", 5, 100.0, 100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "test", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "gdsyghsabhsvbhhsb", "https://tk-resume.000webhostapp.com/assets/img/profile1.jpeg", "Tamill", 5, 100.0, 100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "test", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "gdsyghsabhsvbhhsb", "https://tk-resume.000webhostapp.com/assets/img/profile1.jpeg", "Kumaran", 5, 100.0, 100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
