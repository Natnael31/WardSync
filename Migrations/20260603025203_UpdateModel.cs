using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WardSync.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DueDate",
                value: new DateTime(2026, 5, 31, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DueDate",
                value: new DateTime(2026, 6, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CompletionDate", "DueDate" },
                values: new object[] { new DateTime(2026, 5, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2026, 5, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FollowUpItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DueDate", "MeetingDate" },
                values: new object[] { new DateTime(2026, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2026, 5, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FollowUpItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DueDate", "MeetingDate" },
                values: new object[] { new DateTime(2026, 6, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2026, 5, 20, 0, 0, 0, 0, DateTimeKind.Local) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DueDate",
                value: new DateTime(2026, 5, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DueDate",
                value: new DateTime(2026, 6, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CompletionDate", "DueDate" },
                values: new object[] { new DateTime(2026, 5, 19, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2026, 5, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FollowUpItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DueDate", "MeetingDate" },
                values: new object[] { new DateTime(2026, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2026, 5, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FollowUpItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DueDate", "MeetingDate" },
                values: new object[] { new DateTime(2026, 5, 28, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2026, 5, 16, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
