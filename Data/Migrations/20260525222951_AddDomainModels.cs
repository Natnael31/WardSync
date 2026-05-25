using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WardSync.Migrations
{
    /// <inheritdoc />
    public partial class AddDomainModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Assignments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    AssignedLeader = table.Column<string>(type: "TEXT", nullable: false),
                    Organization = table.Column<string>(type: "TEXT", nullable: false),
                    DueDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Priority = table.Column<string>(type: "TEXT", nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: false),
                    Notes = table.Column<string>(type: "TEXT", nullable: false),
                    CompletionDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Callings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Organization = table.Column<string>(type: "TEXT", nullable: false),
                    MemberAssigned = table.Column<string>(type: "TEXT", nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: false),
                    NeedsFollowUp = table.Column<bool>(type: "INTEGER", nullable: false),
                    DateExtended = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DateSustained = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DateReleased = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Notes = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Callings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FollowUpItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MeetingDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FollowUpItemTitle = table.Column<string>(type: "TEXT", nullable: false),
                    AssignedLeader = table.Column<string>(type: "TEXT", nullable: false),
                    RelatedFamily = table.Column<string>(type: "TEXT", nullable: false),
                    DueDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: false),
                    PrivacyFlag = table.Column<bool>(type: "INTEGER", nullable: false),
                    CompletionNotes = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FollowUpItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: false),
                    Organization = table.Column<string>(type: "TEXT", nullable: false),
                    CurrentCalling = table.Column<string>(type: "TEXT", nullable: false),
                    AvailabilityNotes = table.Column<string>(type: "TEXT", nullable: false),
                    ActiveStatus = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "Id", "AssignedLeader", "CompletionDate", "Description", "DueDate", "Notes", "Organization", "Priority", "Status", "Title" },
                values: new object[,]
                {
                    { 1, "James Carter", null, "Plan transport and refreshments for youth activity.", new DateTime(2026, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), "Confirm van availability.", "Young Men", "High", "Open", "Youth Activity Planning" },
                    { 2, "Sarah Johnson", null, "Follow up with sisters who haven't been contacted.", new DateTime(2026, 6, 1, 0, 0, 0, 0, DateTimeKind.Local), "", "Relief Society", "Medium", "Open", "Ministering Interview Follow-Up" },
                    { 3, "Tom Rivera", new DateTime(2026, 5, 14, 0, 0, 0, 0, DateTimeKind.Local), "Update weekly bulletin with new announcements.", new DateTime(2026, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), "", "Bishopric", "Low", "Completed", "Bulletin Update" }
                });

            migrationBuilder.InsertData(
                table: "Callings",
                columns: new[] { "Id", "DateExtended", "DateReleased", "DateSustained", "MemberAssigned", "NeedsFollowUp", "Notes", "Organization", "Status", "Title" },
                values: new object[,]
                {
                    { 1, null, null, null, "Sarah Johnson", true, "Needs to be filled before next month.", "Primary", "Open", "Primary Teacher" },
                    { 2, null, null, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "James Carter", false, "", "Elders Quorum", "Filled", "Elders Quorum President" },
                    { 3, null, null, null, "", true, "", "Relief Society", "Open", "Relief Society Secretary" }
                });

            migrationBuilder.InsertData(
                table: "FollowUpItems",
                columns: new[] { "Id", "AssignedLeader", "CompletionNotes", "DueDate", "FollowUpItemTitle", "MeetingDate", "PrivacyFlag", "RelatedFamily", "Status" },
                values: new object[,]
                {
                    { 1, "James Carter", "", new DateTime(2026, 6, 1, 0, 0, 0, 0, DateTimeKind.Local), "Ward Council Action Item", new DateTime(2026, 5, 18, 0, 0, 0, 0, DateTimeKind.Local), false, "Sample Family", "Open" },
                    { 2, "Sarah Johnson", "", new DateTime(2026, 5, 23, 0, 0, 0, 0, DateTimeKind.Local), "Service Coordination", new DateTime(2026, 5, 11, 0, 0, 0, 0, DateTimeKind.Local), true, "Sample Family B", "Open" }
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "ActiveStatus", "AvailabilityNotes", "CurrentCalling", "Email", "FirstName", "LastName", "Organization", "Phone" },
                values: new object[,]
                {
                    { 1, true, "Evenings preferred", "Relief Society President", "sarah@example.com", "Sarah", "Johnson", "Relief Society", "555-1111" },
                    { 2, true, "Available weekends", "Elders Quorum President", "james@example.com", "James", "Carter", "Elders Quorum", "555-2222" },
                    { 3, true, "", "First Counselor", "tom@example.com", "Tom", "Rivera", "Bishopric", "555-3333" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assignments");

            migrationBuilder.DropTable(
                name: "Callings");

            migrationBuilder.DropTable(
                name: "FollowUpItems");

            migrationBuilder.DropTable(
                name: "Members");
        }
    }
}
