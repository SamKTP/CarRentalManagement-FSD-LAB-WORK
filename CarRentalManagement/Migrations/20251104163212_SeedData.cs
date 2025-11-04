using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 5, 0, 32, 12, 24, DateTimeKind.Local).AddTicks(4014), new DateTime(2025, 11, 5, 0, 32, 12, 24, DateTimeKind.Local).AddTicks(4029), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 5, 0, 32, 12, 24, DateTimeKind.Local).AddTicks(4032), new DateTime(2025, 11, 5, 0, 32, 12, 24, DateTimeKind.Local).AddTicks(4032), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 5, 0, 32, 12, 24, DateTimeKind.Local).AddTicks(4237), new DateTime(2025, 11, 5, 0, 32, 12, 24, DateTimeKind.Local).AddTicks(4238), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 5, 0, 32, 12, 24, DateTimeKind.Local).AddTicks(4239), new DateTime(2025, 11, 5, 0, 32, 12, 24, DateTimeKind.Local).AddTicks(4240), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 5, 0, 32, 12, 24, DateTimeKind.Local).AddTicks(4374), new DateTime(2025, 11, 5, 0, 32, 12, 24, DateTimeKind.Local).AddTicks(4374), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 5, 0, 32, 12, 24, DateTimeKind.Local).AddTicks(4376), new DateTime(2025, 11, 5, 0, 32, 12, 24, DateTimeKind.Local).AddTicks(4377), "X5", "System" },
                    { 3, "System", new DateTime(2025, 11, 5, 0, 32, 12, 24, DateTimeKind.Local).AddTicks(4378), new DateTime(2025, 11, 5, 0, 32, 12, 24, DateTimeKind.Local).AddTicks(4378), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 5, 0, 32, 12, 24, DateTimeKind.Local).AddTicks(4379), new DateTime(2025, 11, 5, 0, 32, 12, 24, DateTimeKind.Local).AddTicks(4380), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
