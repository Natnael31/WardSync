using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WardSync.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDatabaseModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DueDate",
                value: new DateTime(2026, 5, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DueDate",
                value: new DateTime(2026, 6, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CompletionDate", "DueDate" },
                values: new object[] { new DateTime(2026, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2026, 5, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FollowUpItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DueDate", "MeetingDate" },
                values: new object[] { new DateTime(2026, 6, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2026, 5, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FollowUpItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DueDate", "MeetingDate" },
                values: new object[] { new DateTime(2026, 5, 24, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2026, 5, 12, 0, 0, 0, 0, DateTimeKind.Local) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DueDate",
                value: new DateTime(2026, 5, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DueDate",
                value: new DateTime(2026, 6, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CompletionDate", "DueDate" },
                values: new object[] { new DateTime(2026, 5, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2026, 5, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FollowUpItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DueDate", "MeetingDate" },
                values: new object[] { new DateTime(2026, 6, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2026, 5, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FollowUpItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DueDate", "MeetingDate" },
                values: new object[] { new DateTime(2026, 5, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2026, 5, 11, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
