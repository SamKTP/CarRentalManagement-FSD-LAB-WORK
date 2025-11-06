using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 7, 2, 18, 53, 904, DateTimeKind.Local).AddTicks(6762), new DateTime(2025, 11, 7, 2, 18, 53, 904, DateTimeKind.Local).AddTicks(6774) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 7, 2, 18, 53, 904, DateTimeKind.Local).AddTicks(6777), new DateTime(2025, 11, 7, 2, 18, 53, 904, DateTimeKind.Local).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 7, 2, 18, 53, 904, DateTimeKind.Local).AddTicks(6974), new DateTime(2025, 11, 7, 2, 18, 53, 904, DateTimeKind.Local).AddTicks(6974) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 7, 2, 18, 53, 904, DateTimeKind.Local).AddTicks(6975), new DateTime(2025, 11, 7, 2, 18, 53, 904, DateTimeKind.Local).AddTicks(6976) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 7, 2, 18, 53, 904, DateTimeKind.Local).AddTicks(7069), new DateTime(2025, 11, 7, 2, 18, 53, 904, DateTimeKind.Local).AddTicks(7069) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 7, 2, 18, 53, 904, DateTimeKind.Local).AddTicks(7070), new DateTime(2025, 11, 7, 2, 18, 53, 904, DateTimeKind.Local).AddTicks(7071) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 7, 2, 18, 53, 904, DateTimeKind.Local).AddTicks(7072), new DateTime(2025, 11, 7, 2, 18, 53, 904, DateTimeKind.Local).AddTicks(7072) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 7, 2, 18, 53, 904, DateTimeKind.Local).AddTicks(7073), new DateTime(2025, 11, 7, 2, 18, 53, 904, DateTimeKind.Local).AddTicks(7074) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 7, 1, 48, 57, 269, DateTimeKind.Local).AddTicks(5031), new DateTime(2025, 11, 7, 1, 48, 57, 269, DateTimeKind.Local).AddTicks(5044) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 7, 1, 48, 57, 269, DateTimeKind.Local).AddTicks(5047), new DateTime(2025, 11, 7, 1, 48, 57, 269, DateTimeKind.Local).AddTicks(5048) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 7, 1, 48, 57, 269, DateTimeKind.Local).AddTicks(5249), new DateTime(2025, 11, 7, 1, 48, 57, 269, DateTimeKind.Local).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 7, 1, 48, 57, 269, DateTimeKind.Local).AddTicks(5251), new DateTime(2025, 11, 7, 1, 48, 57, 269, DateTimeKind.Local).AddTicks(5252) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 7, 1, 48, 57, 269, DateTimeKind.Local).AddTicks(5337), new DateTime(2025, 11, 7, 1, 48, 57, 269, DateTimeKind.Local).AddTicks(5337) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 7, 1, 48, 57, 269, DateTimeKind.Local).AddTicks(5338), new DateTime(2025, 11, 7, 1, 48, 57, 269, DateTimeKind.Local).AddTicks(5339) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 7, 1, 48, 57, 269, DateTimeKind.Local).AddTicks(5340), new DateTime(2025, 11, 7, 1, 48, 57, 269, DateTimeKind.Local).AddTicks(5340) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 7, 1, 48, 57, 269, DateTimeKind.Local).AddTicks(5341), new DateTime(2025, 11, 7, 1, 48, 57, 269, DateTimeKind.Local).AddTicks(5342) });
        }
    }
}
