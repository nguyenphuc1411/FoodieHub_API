using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodieHub_API.Data.Migrations
{
    /// <inheritdoc />
    public partial class initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "RecipeReports",
                type: "varchar(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1111111-bbbb-cccc-dddd-eeeeeeeeeeee",
                columns: new[] { "ConcurrencyStamp", "Created_At", "PasswordHash", "SecurityStamp", "Updated_At" },
                values: new object[] { "7e32aa3f-c1fa-4f4b-97e0-db2ca3b8ae9a", new DateTime(2024, 10, 4, 21, 35, 24, 841, DateTimeKind.Local).AddTicks(9242), "AQAAAAIAAYagAAAAECspmmyeU3rQWDbxhHsK8IPDWGqurd2tTnjWLhbKCEUO83QGosLJ58UmqTU+UaKKJw==", "336936ce-223c-4e7e-9a72-7495f6173d39", new DateTime(2024, 10, 4, 21, 35, 24, 841, DateTimeKind.Local).AddTicks(9232) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "RecipeReports",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1111111-bbbb-cccc-dddd-eeeeeeeeeeee",
                columns: new[] { "ConcurrencyStamp", "Created_At", "PasswordHash", "SecurityStamp", "Updated_At" },
                values: new object[] { "c712e1c3-2d12-469a-a398-389339b61d98", new DateTime(2024, 10, 4, 21, 33, 59, 920, DateTimeKind.Local).AddTicks(2018), "AQAAAAIAAYagAAAAEPsOs0auG5OSetc8Kralvavpn6CLKqJFX9P118r6STtEm+O+04bEJaprXgq3RXQIHg==", "2dfa7669-392f-4443-b8c2-0d9320298239", new DateTime(2024, 10, 4, 21, 33, 59, 920, DateTimeKind.Local).AddTicks(2007) });
        }
    }
}
