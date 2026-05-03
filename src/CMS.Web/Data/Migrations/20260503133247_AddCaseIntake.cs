using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMS.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddCaseIntake : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Case",
                columns: table => new
                {
                    CaseId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AutoCaseNo = table.Column<int>(type: "int", nullable: true),
                    CaseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CaseStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Case", x => x.CaseId);
                });

            migrationBuilder.CreateTable(
                name: "CaseIntakes",
                columns: table => new
                {
                    CaseIntakeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AutoCaseIntakeNo = table.Column<int>(type: "int", nullable: true),
                    CaseId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CaseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAnonymous = table.Column<bool>(type: "bit", nullable: false),
                    ComplainantName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComplainantPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComplainantDepartment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComplainantDesignation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComplaintCategoryId = table.Column<int>(type: "int", nullable: false),
                    ComplaintName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComplaintDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComplaintLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrgencyId = table.Column<int>(type: "int", nullable: true),
                    DateOfOccurrence = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseIntakes", x => x.CaseIntakeId);
                    table.ForeignKey(
                        name: "FK_CaseIntakes_Case_CaseId",
                        column: x => x.CaseId,
                        principalTable: "Case",
                        principalColumn: "CaseId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CaseIntakes_CaseId",
                table: "CaseIntakes",
                column: "CaseId",
                unique: true,
                filter: "[CaseId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CaseIntakes");

            migrationBuilder.DropTable(
                name: "Case");
        }
    }
}
