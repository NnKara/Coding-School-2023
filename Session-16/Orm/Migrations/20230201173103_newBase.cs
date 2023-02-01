using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Orm.Migrations
{
    /// <inheritdoc />
    public partial class newBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Customer_CustomerID",
                table: "Transaction");

            migrationBuilder.DropIndex(
                name: "IX_Transaction_CustomerID",
                table: "Transaction");

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
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "TransactionID",
                table: "Customer");

            migrationBuilder.RenameColumn(
                name: "TransactionID",
                table: "Pet",
                newName: "PetFoodID");

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

            migrationBuilder.CreateIndex(
                name: "IX_Pet_PetFoodID",
                table: "Pet",
                column: "PetFoodID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pet_PetFood_PetFoodID",
                table: "Pet",
                column: "PetFoodID",
                principalTable: "PetFood",
                principalColumn: "PetFoodID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Customer_CustomerID",
                table: "Transaction",
                column: "CustomerID",
                principalTable: "Customer",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Employee_EmployeeID",
                table: "Transaction",
                column: "EmployeeID",
                principalTable: "Employee",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_PetFood_PetFoodID",
                table: "Transaction",
                column: "PetFoodID",
                principalTable: "PetFood",
                principalColumn: "PetFoodID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Pet_PetID",
                table: "Transaction",
                column: "PetID",
                principalTable: "Pet",
                principalColumn: "PetID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pet_PetFood_PetFoodID",
                table: "Pet");

            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Customer_CustomerID",
                table: "Transaction");

            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Employee_EmployeeID",
                table: "Transaction");

            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_PetFood_PetFoodID",
                table: "Transaction");

            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Pet_PetID",
                table: "Transaction");

            migrationBuilder.DropIndex(
                name: "IX_Transaction_CustomerID",
                table: "Transaction");

            migrationBuilder.DropIndex(
                name: "IX_Transaction_EmployeeID",
                table: "Transaction");

            migrationBuilder.DropIndex(
                name: "IX_Transaction_PetFoodID",
                table: "Transaction");

            migrationBuilder.DropIndex(
                name: "IX_Transaction_PetID",
                table: "Transaction");

            migrationBuilder.DropIndex(
                name: "IX_Pet_PetFoodID",
                table: "Pet");

            migrationBuilder.RenameColumn(
                name: "PetFoodID",
                table: "Pet",
                newName: "TransactionID");

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

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_CustomerID",
                table: "Transaction",
                column: "CustomerID",
                unique: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Customer_CustomerID",
                table: "Transaction",
                column: "CustomerID",
                principalTable: "Customer",
                principalColumn: "CustomerID");
        }
    }
}
