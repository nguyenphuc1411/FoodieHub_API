using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodieHub_API.Data.Migrations
{
    /// <inheritdoc />
    public partial class mg2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "Admin", "ADMIN" },
                    { "2", null, "User", "USER" },
                    { "3", null, "Moderator", "MODERATOR" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1111111-bbbb-cccc-dddd-eeeeeeeeeeee",
                columns: new[] { "ConcurrencyStamp", "Created_At", "Email", "NormalizedUserName", "PasswordHash", "SecurityStamp", "Updated_At", "UserName" },
                values: new object[] { "4c141ad3-745f-44f6-b255-3ee05bdcda2b", new DateTime(2024, 10, 4, 18, 23, 43, 478, DateTimeKind.Local).AddTicks(4069), "admin@example.com", "ADMIN123", "AQAAAAIAAYagAAAAEIuOVksylKXHqYAqLcF4oJRfIG02im9iaU+UUGHNrwdK7O1YyjIqN6iqgeBrb4bC8g==", "ac179356-8720-4c8e-bd06-e980bd60f9bf", new DateTime(2024, 10, 4, 18, 23, 43, 478, DateTimeKind.Local).AddTicks(4038), "Admin123" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "a1111111-bbbb-cccc-dddd-eeeeeeeeeeee" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "a1111111-bbbb-cccc-dddd-eeeeeeeeeeee" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1111111-bbbb-cccc-dddd-eeeeeeeeeeee",
                columns: new[] { "ConcurrencyStamp", "Created_At", "Email", "NormalizedUserName", "PasswordHash", "SecurityStamp", "Updated_At", "UserName" },
                values: new object[] { "ee499860-d536-4bc6-ae80-4dd6c7f1e65d", new DateTime(2024, 10, 4, 9, 32, 22, 259, DateTimeKind.Local).AddTicks(4885), "admin@gmail.com", "ADMIN", "AQAAAAIAAYagAAAAEKHG9lnEW/QwMn736cavFLSj+ab3SUU2OdbQdNLA9YSLL6bV2VXi6Oz3elCP8z86VA==", "11fbd3da-2c36-4afb-a5c0-386d25bc67d3", new DateTime(2024, 10, 4, 9, 32, 22, 259, DateTimeKind.Local).AddTicks(4822), "Admin" });
        }
    }
}
