using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pharmacy.Migrations
{
    /// <inheritdoc />
    public partial class Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Drugs_Manufacturers_ManufacturerId",
                table: "Drugs");

            migrationBuilder.DropForeignKey(
                name: "FK_DrugTypes_Drugs_DrugId",
                table: "DrugTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_DrugTypes_Pharmacies_PharmacyId",
                table: "DrugTypes");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Pharmacists",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 13);

            migrationBuilder.AlterColumn<int>(
                name: "PharmacyId",
                table: "DrugTypes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DrugId",
                table: "DrugTypes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ManufacturerId",
                table: "Drugs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Customers",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 13);

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Customer_id", "Age", "Email", "Gender", "Phone", "First_name", "Last_name" },
                values: new object[,]
                {
                    { 1, 19, "AndOl@gmail.com", true, "+380993702050", "Andrew", "Oliynik" },
                    { 2, 19, "OlOst@gmail.com", true, "+380993702051", "Oleksii", "Ostapchenko" },
                    { 3, 19, "ArSh@gmail.com", false, "+380993702052", "Ariana", "Shamsha" },
                    { 4, 19, "OlBil@gmail.com", true, "+380993702053", "Oleg", "Bilyk" }
                });

            migrationBuilder.InsertData(
                table: "DrugTypes",
                columns: new[] { "DrugType_id", "Amount", "DrugId", "PharmacyId" },
                values: new object[,]
                {
                    { 1, 1, null, null },
                    { 2, 1, null, null },
                    { 3, 4, null, null }
                });

            migrationBuilder.InsertData(
                table: "Drugs",
                columns: new[] { "Drug_id", "ManufacturerId", "Name", "Price", "Type" },
                values: new object[,]
                {
                    { 1, null, "Візин", 20m, "Краплі" },
                    { 2, null, "Синупрет", 75m, "Настоянка" },
                    { 3, null, "Колдрекс", 40m, "Розчинний порошок" }
                });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Manufacturer_id", "Address", "License", "Name" },
                values: new object[,]
                {
                    { 1, "Balzaka, 15", false, "Yassen" },
                    { 2, "Balzaka, 16", false, "Bionorica" },
                    { 3, "Balzaka, 17", false, "Coldrex" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Order_id", "Amount", "Created", "DrugId", "ManufacturerId", "PharmacistId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null },
                    { 2, 3, new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null },
                    { 3, 2, new DateTime(2022, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Pharmacies",
                columns: new[] { "Pharmacy_id", "Address" },
                values: new object[,]
                {
                    { 1, "Bandery, 4" },
                    { 2, "Bandery, 5" },
                    { 3, "Bandery, 6" }
                });

            migrationBuilder.InsertData(
                table: "Pharmacists",
                columns: new[] { "Pharmacist_id", "Age", "Email", "Gender", "Password", "Phone", "First_name", "Last_name" },
                values: new object[,]
                {
                    { 1, 20, "W1@gmail.com", true, "123451", "+380959873454", "Olexander", "Marchenko" },
                    { 2, 23, "W2@gmail.com", true, "123452", "+380959873454", "Valerii", "Grozny" },
                    { 3, 30, "W3@gmail.com", true, "123453", "+380959873454", "Olexiy", "Pavlenko" }
                });

            migrationBuilder.InsertData(
                table: "Reciepts",
                columns: new[] { "Reciept_id", "Amount", "Created", "CustomerId", "DrugId" },
                values: new object[,]
                {
                    { 1, 3, new DateTime(2022, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null },
                    { 2, 1, new DateTime(2022, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null },
                    { 3, 1, new DateTime(2022, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Drugs_Manufacturers_ManufacturerId",
                table: "Drugs",
                column: "ManufacturerId",
                principalTable: "Manufacturers",
                principalColumn: "Manufacturer_id");

            migrationBuilder.AddForeignKey(
                name: "FK_DrugTypes_Drugs_DrugId",
                table: "DrugTypes",
                column: "DrugId",
                principalTable: "Drugs",
                principalColumn: "Drug_id");

            migrationBuilder.AddForeignKey(
                name: "FK_DrugTypes_Pharmacies_PharmacyId",
                table: "DrugTypes",
                column: "PharmacyId",
                principalTable: "Pharmacies",
                principalColumn: "Pharmacy_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Drugs_Manufacturers_ManufacturerId",
                table: "Drugs");

            migrationBuilder.DropForeignKey(
                name: "FK_DrugTypes_Drugs_DrugId",
                table: "DrugTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_DrugTypes_Pharmacies_PharmacyId",
                table: "DrugTypes");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Customer_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Customer_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Customer_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Customer_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DrugTypes",
                keyColumn: "DrugType_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DrugTypes",
                keyColumn: "DrugType_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DrugTypes",
                keyColumn: "DrugType_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Drug_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Drug_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Drug_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Manufacturer_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Manufacturer_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Manufacturer_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Order_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Order_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Order_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pharmacies",
                keyColumn: "Pharmacy_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pharmacies",
                keyColumn: "Pharmacy_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pharmacies",
                keyColumn: "Pharmacy_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pharmacists",
                keyColumn: "Pharmacist_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pharmacists",
                keyColumn: "Pharmacist_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pharmacists",
                keyColumn: "Pharmacist_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reciepts",
                keyColumn: "Reciept_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reciepts",
                keyColumn: "Reciept_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reciepts",
                keyColumn: "Reciept_id",
                keyValue: 3);

            migrationBuilder.AlterColumn<int>(
                name: "Phone",
                table: "Pharmacists",
                type: "int",
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(13)",
                oldMaxLength: 13);

            migrationBuilder.AlterColumn<int>(
                name: "PharmacyId",
                table: "DrugTypes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DrugId",
                table: "DrugTypes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ManufacturerId",
                table: "Drugs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Phone",
                table: "Customers",
                type: "int",
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(13)",
                oldMaxLength: 13);

            migrationBuilder.AddForeignKey(
                name: "FK_Drugs_Manufacturers_ManufacturerId",
                table: "Drugs",
                column: "ManufacturerId",
                principalTable: "Manufacturers",
                principalColumn: "Manufacturer_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DrugTypes_Drugs_DrugId",
                table: "DrugTypes",
                column: "DrugId",
                principalTable: "Drugs",
                principalColumn: "Drug_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DrugTypes_Pharmacies_PharmacyId",
                table: "DrugTypes",
                column: "PharmacyId",
                principalTable: "Pharmacies",
                principalColumn: "Pharmacy_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
