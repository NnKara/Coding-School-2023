﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Orm.Context;

#nullable disable

namespace Orm.Migrations
{
    [DbContext(typeof(PetShopContext))]
    [Migration("20230206125939_NewBuild")]
    partial class NewBuild
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Model.Customer", b =>
                {
                    b.Property<Guid>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("CustomerSurname")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("TIN")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customer", (string)null);
                });

            modelBuilder.Entity("Model.Employee", b =>
                {
                    b.Property<Guid>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("EmployeeSurname")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("EmployeeType")
                        .HasColumnType("int");

                    b.Property<decimal>("SallaryPerMonth")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employee", (string)null);
                });

            modelBuilder.Entity("Model.MonthlyLedger", b =>
                {
                    b.Property<Guid>("MonthlyLedgerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Expenses")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("Income")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("Month")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("MonthlyLedgerID");

                    b.ToTable("MonthlyLedger", (string)null);
                });

            modelBuilder.Entity("Model.Pet", b =>
                {
                    b.Property<Guid>("PetID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AnimalType")
                        .HasColumnType("int");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Cost")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("PetStatus")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("PetID");

                    b.ToTable("Pet", (string)null);
                });

            modelBuilder.Entity("Model.PetFood", b =>
                {
                    b.Property<Guid>("PetFoodID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AnimalType")
                        .HasColumnType("int");

                    b.Property<decimal>("Cost")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("Price")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("PetFoodID");

                    b.ToTable("PetFood", (string)null);
                });

            modelBuilder.Entity("Model.PetReport", b =>
                {
                    b.Property<Guid>("PetReportID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AnimalType")
                        .HasColumnType("int");

                    b.Property<int>("PetReportMonth")
                        .HasColumnType("int");

                    b.Property<int>("PetReportTotalSold")
                        .HasColumnType("int");

                    b.Property<int>("PetReportYear")
                        .HasColumnType("int");

                    b.HasKey("PetReportID");

                    b.ToTable("PetReport", (string)null);
                });

            modelBuilder.Entity("Model.Transaction", b =>
                {
                    b.Property<Guid>("TransactionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EmployeeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PetFoodID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("PetFoodPrice")
                        .HasPrecision(10, 5)
                        .HasColumnType("decimal(10,5)");

                    b.Property<int>("PetFoodQty")
                        .HasColumnType("int");

                    b.Property<Guid>("PetID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("PetPrice")
                        .HasPrecision(10, 5)
                        .HasColumnType("decimal(10,5)");

                    b.Property<decimal>("TotalPrice")
                        .HasPrecision(10, 5)
                        .HasColumnType("decimal(10,5)");

                    b.Property<DateTime>("TransactionDate")
                        .HasMaxLength(20)
                        .HasColumnType("datetime2");

                    b.HasKey("TransactionID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("PetFoodID");

                    b.HasIndex("PetID");

                    b.ToTable("Transaction", (string)null);
                });

            modelBuilder.Entity("Model.Transaction", b =>
                {
                    b.HasOne("Model.Customer", "Customer")
                        .WithMany("Transactions")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Employee", "Employee")
                        .WithMany("Transactions")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.PetFood", "PetFood")
                        .WithMany("Transactions")
                        .HasForeignKey("PetFoodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Pet", "Pet")
                        .WithMany("Transactions")
                        .HasForeignKey("PetID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Employee");

                    b.Navigation("Pet");

                    b.Navigation("PetFood");
                });

            modelBuilder.Entity("Model.Customer", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("Model.Employee", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("Model.Pet", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("Model.PetFood", b =>
                {
                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}