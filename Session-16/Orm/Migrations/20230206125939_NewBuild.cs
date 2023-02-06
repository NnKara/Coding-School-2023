using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Orm.Migrations
{
    /// <inheritdoc />
    public partial class NewBuild : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    CustomerSurname = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TIN = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    EmployeeSurname = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SallaryPerMonth = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    EmployeeType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeID);
                });

            migrationBuilder.CreateTable(
                name: "MonthlyLedger",
                columns: table => new
                {
                    MonthlyLedgerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    Income = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    Expenses = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    Total = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonthlyLedger", x => x.MonthlyLedgerID);
                });

            migrationBuilder.CreateTable(
                name: "Pet",
                columns: table => new
                {
                    PetID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Breed = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AnimalType = table.Column<int>(type: "int", nullable: false),
                    PetStatus = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pet", x => x.PetID);
                });

            migrationBuilder.CreateTable(
                name: "PetFood",
                columns: table => new
                {
                    PetFoodID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AnimalType = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetFood", x => x.PetFoodID);
                });

            migrationBuilder.CreateTable(
                name: "PetReport",
                columns: table => new
                {
                    PetReportID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PetReportYear = table.Column<int>(type: "int", nullable: false),
                    PetReportMonth = table.Column<int>(type: "int", nullable: false),
                    AnimalType = table.Column<int>(type: "int", nullable: false),
                    PetReportTotalSold = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetReport", x => x.PetReportID);
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    TransactionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", maxLength: 20, nullable: false),
                    PetPrice = table.Column<decimal>(type: "decimal(10,5)", precision: 10, scale: 5, nullable: false),
                    PetFoodQty = table.Column<int>(type: "int", nullable: false),
                    PetFoodPrice = table.Column<decimal>(type: "decimal(10,5)", precision: 10, scale: 5, nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(10,5)", precision: 10, scale: 5, nullable: false),
                    PetID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PetFoodID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.TransactionID);
                    table.ForeignKey(
                        name: "FK_Transaction_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transaction_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transaction_PetFood_PetFoodID",
                        column: x => x.PetFoodID,
                        principalTable: "PetFood",
                        principalColumn: "PetFoodID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transaction_Pet_PetID",
                        column: x => x.PetID,
                        principalTable: "Pet",
                        principalColumn: "PetID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_CustomerID",
                table: "Transaction",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_EmployeeID",
                table: "Transaction",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_PetFoodID",
                table: "Transaction",
                column: "PetFoodID");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_PetID",
                table: "Transaction",
                column: "PetID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MonthlyLedger");

            migrationBuilder.DropTable(
                name: "PetReport");

            migrationBuilder.DropTable(
                name: "Transaction");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "PetFood");

            migrationBuilder.DropTable(
                name: "Pet");
        }
    }
}
