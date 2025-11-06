using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRoleWithSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "34d93a69-3dfe-4feb-850c-5d989154af7d", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEIw/Aq7c0kV24XjGQQEUcgqvrRC1dd5/QNnaQ0qroU4lAKCJjgJh5zlSxMeqla8m/g==", null, false, "7e9a1d21-60c2-4a35-bc88-0d35a4e87a6d", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 7, 2, 23, 0, 217, DateTimeKind.Local).AddTicks(9218), new DateTime(2025, 11, 7, 2, 23, 0, 217, DateTimeKind.Local).AddTicks(9230) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 7, 2, 23, 0, 217, DateTimeKind.Local).AddTicks(9232), new DateTime(2025, 11, 7, 2, 23, 0, 217, DateTimeKind.Local).AddTicks(9233) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 7, 2, 23, 0, 217, DateTimeKind.Local).AddTicks(9411), new DateTime(2025, 11, 7, 2, 23, 0, 217, DateTimeKind.Local).AddTicks(9412) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 7, 2, 23, 0, 217, DateTimeKind.Local).AddTicks(9413), new DateTime(2025, 11, 7, 2, 23, 0, 217, DateTimeKind.Local).AddTicks(9413) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 7, 2, 23, 0, 217, DateTimeKind.Local).AddTicks(9509), new DateTime(2025, 11, 7, 2, 23, 0, 217, DateTimeKind.Local).AddTicks(9509) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 7, 2, 23, 0, 217, DateTimeKind.Local).AddTicks(9511), new DateTime(2025, 11, 7, 2, 23, 0, 217, DateTimeKind.Local).AddTicks(9511) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 7, 2, 23, 0, 217, DateTimeKind.Local).AddTicks(9512), new DateTime(2025, 11, 7, 2, 23, 0, 217, DateTimeKind.Local).AddTicks(9512) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 7, 2, 23, 0, 217, DateTimeKind.Local).AddTicks(9513), new DateTime(2025, 11, 7, 2, 23, 0, 217, DateTimeKind.Local).AddTicks(9514) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

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
    }
}
