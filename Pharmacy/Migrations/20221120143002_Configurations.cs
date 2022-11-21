using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pharmacy.Migrations
{
    /// <inheritdoc />
    public partial class Configurations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Drugs_Manufacturer_ManufacturerId",
                table: "Drugs");

            migrationBuilder.DropForeignKey(
                name: "FK_DrugType_Drugs_DrugId",
                table: "DrugType");

            migrationBuilder.DropForeignKey(
                name: "FK_DrugType_Pharmacy_PharmacyId",
                table: "DrugType");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Drugs_DrugId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Manufacturer_ManufacturerId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Pharmacist_PharmacistId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Reciept_Customer_CustomerId",
                table: "Reciept");

            migrationBuilder.DropForeignKey(
                name: "FK_Reciept_Drugs_DrugId",
                table: "Reciept");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reciept",
                table: "Reciept");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pharmacy",
                table: "Pharmacy");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pharmacist",
                table: "Pharmacist");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Manufacturer",
                table: "Manufacturer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DrugType",
                table: "DrugType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.RenameTable(
                name: "Reciept",
                newName: "Reciepts");

            migrationBuilder.RenameTable(
                name: "Pharmacy",
                newName: "Pharmacies");

            migrationBuilder.RenameTable(
                name: "Pharmacist",
                newName: "Pharmacists");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "Manufacturer",
                newName: "Manufacturers");

            migrationBuilder.RenameTable(
                name: "DrugType",
                newName: "DrugTypes");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "Customers");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Drugs",
                newName: "Drug_id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Reciepts",
                newName: "Reciept_id");

            migrationBuilder.RenameIndex(
                name: "IX_Reciept_DrugId",
                table: "Reciepts",
                newName: "IX_Reciepts_DrugId");

            migrationBuilder.RenameIndex(
                name: "IX_Reciept_CustomerId",
                table: "Reciepts",
                newName: "IX_Reciepts_CustomerId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Pharmacies",
                newName: "Pharmacy_id");

            migrationBuilder.RenameColumn(
                name: "lName",
                table: "Pharmacists",
                newName: "Last_name");

            migrationBuilder.RenameColumn(
                name: "fName",
                table: "Pharmacists",
                newName: "First_name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Pharmacists",
                newName: "Pharmacist_id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Orders",
                newName: "Order_id");

            migrationBuilder.RenameIndex(
                name: "IX_Order_PharmacistId",
                table: "Orders",
                newName: "IX_Orders_PharmacistId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_ManufacturerId",
                table: "Orders",
                newName: "IX_Orders_ManufacturerId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_DrugId",
                table: "Orders",
                newName: "IX_Orders_DrugId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Manufacturers",
                newName: "Manufacturer_id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "DrugTypes",
                newName: "DrugType_id");

            migrationBuilder.RenameIndex(
                name: "IX_DrugType_PharmacyId",
                table: "DrugTypes",
                newName: "IX_DrugTypes_PharmacyId");

            migrationBuilder.RenameIndex(
                name: "IX_DrugType_DrugId",
                table: "DrugTypes",
                newName: "IX_DrugTypes_DrugId");

            migrationBuilder.RenameColumn(
                name: "lName",
                table: "Customers",
                newName: "Last_name");

            migrationBuilder.RenameColumn(
                name: "fName",
                table: "Customers",
                newName: "First_name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Customers",
                newName: "Customer_id");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Drugs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Drugs",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Reciepts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Pharmacies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Pharmacists",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Pharmacists",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Last_name",
                table: "Pharmacists",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "First_name",
                table: "Pharmacists",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Manufacturers",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Manufacturers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Customers",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Last_name",
                table: "Customers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "First_name",
                table: "Customers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reciepts",
                table: "Reciepts",
                column: "Reciept_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pharmacies",
                table: "Pharmacies",
                column: "Pharmacy_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pharmacists",
                table: "Pharmacists",
                column: "Pharmacist_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Order_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Manufacturers",
                table: "Manufacturers",
                column: "Manufacturer_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DrugTypes",
                table: "DrugTypes",
                column: "DrugType_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "Customer_id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Drugs_DrugId",
                table: "Orders",
                column: "DrugId",
                principalTable: "Drugs",
                principalColumn: "Drug_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Manufacturers_ManufacturerId",
                table: "Orders",
                column: "ManufacturerId",
                principalTable: "Manufacturers",
                principalColumn: "Manufacturer_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Pharmacists_PharmacistId",
                table: "Orders",
                column: "PharmacistId",
                principalTable: "Pharmacists",
                principalColumn: "Pharmacist_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reciepts_Customers_CustomerId",
                table: "Reciepts",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Customer_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reciepts_Drugs_DrugId",
                table: "Reciepts",
                column: "DrugId",
                principalTable: "Drugs",
                principalColumn: "Drug_id");
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

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Drugs_DrugId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Manufacturers_ManufacturerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Pharmacists_PharmacistId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Reciepts_Customers_CustomerId",
                table: "Reciepts");

            migrationBuilder.DropForeignKey(
                name: "FK_Reciepts_Drugs_DrugId",
                table: "Reciepts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reciepts",
                table: "Reciepts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pharmacists",
                table: "Pharmacists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pharmacies",
                table: "Pharmacies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Manufacturers",
                table: "Manufacturers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DrugTypes",
                table: "DrugTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "Reciepts",
                newName: "Reciept");

            migrationBuilder.RenameTable(
                name: "Pharmacists",
                newName: "Pharmacist");

            migrationBuilder.RenameTable(
                name: "Pharmacies",
                newName: "Pharmacy");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order");

            migrationBuilder.RenameTable(
                name: "Manufacturers",
                newName: "Manufacturer");

            migrationBuilder.RenameTable(
                name: "DrugTypes",
                newName: "DrugType");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Customer");

            migrationBuilder.RenameColumn(
                name: "Drug_id",
                table: "Drugs",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Reciept_id",
                table: "Reciept",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Reciepts_DrugId",
                table: "Reciept",
                newName: "IX_Reciept_DrugId");

            migrationBuilder.RenameIndex(
                name: "IX_Reciepts_CustomerId",
                table: "Reciept",
                newName: "IX_Reciept_CustomerId");

            migrationBuilder.RenameColumn(
                name: "Last_name",
                table: "Pharmacist",
                newName: "lName");

            migrationBuilder.RenameColumn(
                name: "First_name",
                table: "Pharmacist",
                newName: "fName");

            migrationBuilder.RenameColumn(
                name: "Pharmacist_id",
                table: "Pharmacist",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Pharmacy_id",
                table: "Pharmacy",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Order_id",
                table: "Order",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_PharmacistId",
                table: "Order",
                newName: "IX_Order_PharmacistId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_ManufacturerId",
                table: "Order",
                newName: "IX_Order_ManufacturerId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_DrugId",
                table: "Order",
                newName: "IX_Order_DrugId");

            migrationBuilder.RenameColumn(
                name: "Manufacturer_id",
                table: "Manufacturer",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DrugType_id",
                table: "DrugType",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_DrugTypes_PharmacyId",
                table: "DrugType",
                newName: "IX_DrugType_PharmacyId");

            migrationBuilder.RenameIndex(
                name: "IX_DrugTypes_DrugId",
                table: "DrugType",
                newName: "IX_DrugType_DrugId");

            migrationBuilder.RenameColumn(
                name: "Last_name",
                table: "Customer",
                newName: "lName");

            migrationBuilder.RenameColumn(
                name: "First_name",
                table: "Customer",
                newName: "fName");

            migrationBuilder.RenameColumn(
                name: "Customer_id",
                table: "Customer",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Drugs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Drugs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Reciept",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Pharmacist",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Pharmacist",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "lName",
                table: "Pharmacist",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "fName",
                table: "Pharmacist",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Pharmacy",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Manufacturer",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Manufacturer",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "lName",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "fName",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reciept",
                table: "Reciept",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pharmacist",
                table: "Pharmacist",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pharmacy",
                table: "Pharmacy",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Manufacturer",
                table: "Manufacturer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DrugType",
                table: "DrugType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Drugs_Manufacturer_ManufacturerId",
                table: "Drugs",
                column: "ManufacturerId",
                principalTable: "Manufacturer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DrugType_Drugs_DrugId",
                table: "DrugType",
                column: "DrugId",
                principalTable: "Drugs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DrugType_Pharmacy_PharmacyId",
                table: "DrugType",
                column: "PharmacyId",
                principalTable: "Pharmacy",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Drugs_DrugId",
                table: "Order",
                column: "DrugId",
                principalTable: "Drugs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Manufacturer_ManufacturerId",
                table: "Order",
                column: "ManufacturerId",
                principalTable: "Manufacturer",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Pharmacist_PharmacistId",
                table: "Order",
                column: "PharmacistId",
                principalTable: "Pharmacist",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reciept_Customer_CustomerId",
                table: "Reciept",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reciept_Drugs_DrugId",
                table: "Reciept",
                column: "DrugId",
                principalTable: "Drugs",
                principalColumn: "Id");
        }
    }
}
