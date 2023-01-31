using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Orm.Migrations
{
    /// <inheritdoc />
    public partial class LastMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PetReport",
                table: "PetReport");

            migrationBuilder.RenameTable(
                name: "PetReport",
                newName: "PetReports");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PetReports",
                table: "PetReports",
                column: "PetReportID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PetReports",
                table: "PetReports");

            migrationBuilder.RenameTable(
                name: "PetReports",
                newName: "PetReport");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PetReport",
                table: "PetReport",
                column: "PetReportID");
        }
    }
}
