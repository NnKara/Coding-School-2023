using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Orm.Migrations
{
    /// <inheritdoc />
    public partial class ThirdInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "PetFood",
                type: "decimal(10,5)",
                precision: 10,
                scale: 5,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Cost",
                table: "PetFood",
                type: "decimal(10,5)",
                precision: 10,
                scale: 5,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<Guid>(
                name: "PetID",
                table: "PetFood",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "TransactionID",
                table: "PetFood",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Pet",
                type: "decimal(10,5)",
                precision: 10,
                scale: 5,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Cost",
                table: "Pet",
                type: "decimal(10,5)",
                precision: 10,
                scale: 5,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<Guid>(
                name: "TransactionID",
                table: "Pet",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<decimal>(
                name: "SallaryPerMonth",
                table: "Employee",
                type: "decimal(10,5)",
                precision: 10,
                scale: 5,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<Guid>(
                name: "TransactionID",
                table: "Employee",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "TransactionID",
                table: "Customer",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "MonthlyLedger",
                columns: table => new
                {
                    MonthlyLedgerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    Income = table.Column<decimal>(type: "decimal(10,5)", precision: 10, scale: 5, nullable: false),
                    Expenses = table.Column<decimal>(type: "decimal(10,5)", precision: 10, scale: 5, nullable: false),
                    Total = table.Column<decimal>(type: "decimal(10,5)", precision: 10, scale: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonthlyLedger", x => x.MonthlyLedgerID);
                });

            migrationBuilder.CreateTable(
                name: "PetReport",
                columns: table => new
                {
                    PetReportID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PetReportYear = table.Column<int>(type: "int", nullable: false),
                    PetReportMonth = table.Column<int>(type: "int", nullable: false),
                    AnimalType = table.Column<int>(type: "int", nullable: false),
                    PetReportTotalSold = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
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
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PetID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PetFoodID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PetPrice = table.Column<decimal>(type: "decimal(10,5)", precision: 10, scale: 5, nullable: false),
                    PetFoodQty = table.Column<int>(type: "int", nullable: false),
                    PetFoodPrice = table.Column<decimal>(type: "decimal(10,5)", precision: 10, scale: 5, nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(10,5)", precision: 10, scale: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.TransactionID);
                    table.ForeignKey(
                        name: "FK_Transaction_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PetFood_PetID",
                table: "PetFood",
                column: "PetID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PetFood_TransactionID",
                table: "PetFood",
                column: "TransactionID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pet_TransactionID",
                table: "Pet",
                column: "TransactionID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_TransactionID",
                table: "Employee",
                column: "TransactionID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_CustomerID",
                table: "Transaction",
                column: "CustomerID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Transaction_TransactionID",
                table: "Employee",
                column: "TransactionID",
                principalTable: "Transaction",
                principalColumn: "TransactionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pet_Transaction_TransactionID",
                table: "Pet",
                column: "TransactionID",
                principalTable: "Transaction",
                principalColumn: "TransactionID");

            migrationBuilder.AddForeignKey(
                name: "FK_PetFood_Pet_PetID",
                table: "PetFood",
                column: "PetID",
                principalTable: "Pet",
                principalColumn: "PetID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PetFood_Transaction_TransactionID",
                table: "PetFood",
                column: "TransactionID",
                principalTable: "Transaction",
                principalColumn: "TransactionID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Transaction_TransactionID",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Pet_Transaction_TransactionID",
                table: "Pet");

            migrationBuilder.DropForeignKey(
                name: "FK_PetFood_Pet_PetID",
                table: "PetFood");

            migrationBuilder.DropForeignKey(
                name: "FK_PetFood_Transaction_TransactionID",
                table: "PetFood");

            migrationBuilder.DropTable(
                name: "MonthlyLedger");

            migrationBuilder.DropTable(
                name: "PetReport");

            migrationBuilder.DropTable(
                name: "Transaction");

            migrationBuilder.DropIndex(
                name: "IX_PetFood_PetID",
                table: "PetFood");

            migrationBuilder.DropIndex(
                name: "IX_PetFood_TransactionID",
                table: "PetFood");

            migrationBuilder.DropIndex(
                name: "IX_Pet_TransactionID",
                table: "Pet");

            migrationBuilder.DropIndex(
                name: "IX_Employee_TransactionID",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "PetID",
                table: "PetFood");

            migrationBuilder.DropColumn(
                name: "TransactionID",
                table: "PetFood");

            migrationBuilder.DropColumn(
                name: "TransactionID",
                table: "Pet");

            migrationBuilder.DropColumn(
                name: "TransactionID",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "TransactionID",
                table: "Customer");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "PetFood",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,5)",
                oldPrecision: 10,
                oldScale: 5);

            migrationBuilder.AlterColumn<decimal>(
                name: "Cost",
                table: "PetFood",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,5)",
                oldPrecision: 10,
                oldScale: 5);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Pet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,5)",
                oldPrecision: 10,
                oldScale: 5);

            migrationBuilder.AlterColumn<decimal>(
                name: "Cost",
                table: "Pet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,5)",
                oldPrecision: 10,
                oldScale: 5);

            migrationBuilder.AlterColumn<decimal>(
                name: "SallaryPerMonth",
                table: "Employee",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,5)",
                oldPrecision: 10,
                oldScale: 5);
        }
    }
}
