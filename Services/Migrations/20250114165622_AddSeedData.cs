using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Services.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDateTime", "Description", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 14, 19, 56, 22, 357, DateTimeKind.Local).AddTicks(9001), "Sport Sport", "Sport" },
                    { 2, new DateTime(2025, 1, 14, 19, 56, 22, 357, DateTimeKind.Local).AddTicks(9003), "Child Child", "Child" }
                });

            migrationBuilder.InsertData(
                table: "Countries",  
                column: "CreatedDateTime",
                value: new DateTime(2025, 1, 14, 19, 56, 22, 357, DateTimeKind.Local).AddTicks(8880));

            migrationBuilder.InsertData(
                table: "Countries", 
                column: "CreatedDateTime",
                value: new DateTime(2025, 1, 14, 19, 56, 22, 357, DateTimeKind.Local).AddTicks(8882));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2025, 1, 14, 19, 51, 7, 458, DateTimeKind.Local).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2025, 1, 14, 19, 51, 7, 458, DateTimeKind.Local).AddTicks(3636));
        }
    }
}
