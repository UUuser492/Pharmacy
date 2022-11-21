using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pharmacy.Migrations
{
    /// <inheritdoc />
    public partial class NoDelCasc : Migration
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
                name: "FK_DrugTypes_Pharmacies_Pharmacy_mId",
                table: "DrugTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Drugs_DrugId",
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

            migrationBuilder.AlterColumn<int>(
                name: "DrugId",
                table: "Reciepts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Reciepts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PharmacistId",
                table: "Orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DrugId",
                table: "Orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Pharmacy_mId",
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

            migrationBuilder.UpdateData(
                table: "DrugTypes",
                keyColumn: "DrugType_id",
                keyValue: 1,
                column: "Pharmacy_mId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DrugTypes",
                keyColumn: "DrugType_id",
                keyValue: 2,
                column: "Pharmacy_mId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "DrugTypes",
                keyColumn: "DrugType_id",
                keyValue: 3,
                column: "Pharmacy_mId",
                value: 3);

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
                name: "FK_DrugTypes_Pharmacies_Pharmacy_mId",
                table: "DrugTypes",
                column: "Pharmacy_mId",
                principalTable: "Pharmacies",
                principalColumn: "Pharmacy_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Drugs_DrugId",
                table: "Orders",
                column: "DrugId",
                principalTable: "Drugs",
                principalColumn: "Drug_id");

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
                name: "FK_DrugTypes_Pharmacies_Pharmacy_mId",
                table: "DrugTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Drugs_DrugId",
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

            migrationBuilder.AlterColumn<int>(
                name: "DrugId",
                table: "Reciepts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Reciepts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PharmacistId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DrugId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Pharmacy_mId",
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

            migrationBuilder.UpdateData(
                table: "DrugTypes",
                keyColumn: "DrugType_id",
                keyValue: 1,
                column: "Pharmacy_mId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DrugTypes",
                keyColumn: "DrugType_id",
                keyValue: 2,
                column: "Pharmacy_mId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DrugTypes",
                keyColumn: "DrugType_id",
                keyValue: 3,
                column: "Pharmacy_mId",
                value: 0);

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
                name: "FK_DrugTypes_Pharmacies_Pharmacy_mId",
                table: "DrugTypes",
                column: "Pharmacy_mId",
                principalTable: "Pharmacies",
                principalColumn: "Pharmacy_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Drugs_DrugId",
                table: "Orders",
                column: "DrugId",
                principalTable: "Drugs",
                principalColumn: "Drug_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Pharmacists_PharmacistId",
                table: "Orders",
                column: "PharmacistId",
                principalTable: "Pharmacists",
                principalColumn: "Pharmacist_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reciepts_Customers_CustomerId",
                table: "Reciepts",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Customer_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reciepts_Drugs_DrugId",
                table: "Reciepts",
                column: "DrugId",
                principalTable: "Drugs",
                principalColumn: "Drug_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
