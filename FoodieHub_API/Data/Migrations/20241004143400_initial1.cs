using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodieHub_API.Data.Migrations
{
    /// <inheritdoc />
    public partial class initial1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "RecipeReports",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1111111-bbbb-cccc-dddd-eeeeeeeeeeee",
                columns: new[] { "ConcurrencyStamp", "Created_At", "PasswordHash", "SecurityStamp", "Updated_At" },
                values: new object[] { "c712e1c3-2d12-469a-a398-389339b61d98", new DateTime(2024, 10, 4, 21, 33, 59, 920, DateTimeKind.Local).AddTicks(2018), "AQAAAAIAAYagAAAAEPsOs0auG5OSetc8Kralvavpn6CLKqJFX9P118r6STtEm+O+04bEJaprXgq3RXQIHg==", "2dfa7669-392f-4443-b8c2-0d9320298239", new DateTime(2024, 10, 4, 21, 33, 59, 920, DateTimeKind.Local).AddTicks(2007) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "RecipeReports");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1111111-bbbb-cccc-dddd-eeeeeeeeeeee",
                columns: new[] { "ConcurrencyStamp", "Created_At", "PasswordHash", "SecurityStamp", "Updated_At" },
                values: new object[] { "7b284bf6-6baf-45c2-82e3-781bc49dfb6a", new DateTime(2024, 10, 4, 21, 9, 5, 431, DateTimeKind.Local).AddTicks(9185), "AQAAAAIAAYagAAAAED0qK8G0iDxb477HD5+qmphOwerDdl/anDAAOuMlSV6I+8z+e3njyfrFSxYVnrxVDA==", "9b75db0d-80c2-427d-88dc-9ee0228baa47", new DateTime(2024, 10, 4, 21, 9, 5, 431, DateTimeKind.Local).AddTicks(9173) });
        }
    }
}
