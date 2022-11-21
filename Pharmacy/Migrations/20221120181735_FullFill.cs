using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pharmacy.Migrations
{
    /// <inheritdoc />
    public partial class FullFill : Migration
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

            migrationBuilder.DropIndex(
                name: "IX_Orders_ManufacturerId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_DrugTypes_PharmacyId",
                table: "DrugTypes");

            migrationBuilder.DropColumn(
                name: "ManufacturerId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PharmacyId",
                table: "DrugTypes");

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
                name: "DrugId",
                table: "DrugTypes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Pharmacy_mId",
                table: "DrugTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "DrugId", "Pharmacy_mId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "DrugTypes",
                keyColumn: "DrugType_id",
                keyValue: 2,
                columns: new[] { "DrugId", "Pharmacy_mId" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "DrugTypes",
                keyColumn: "DrugType_id",
                keyValue: 3,
                columns: new[] { "DrugId", "Pharmacy_mId" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Drug_id",
                keyValue: 1,
                column: "ManufacturerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Drug_id",
                keyValue: 2,
                column: "ManufacturerId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Drug_id",
                keyValue: 3,
                column: "ManufacturerId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Order_id",
                keyValue: 1,
                columns: new[] { "DrugId", "PharmacistId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Order_id",
                keyValue: 2,
                columns: new[] { "DrugId", "PharmacistId" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Order_id",
                keyValue: 3,
                columns: new[] { "DrugId", "PharmacistId" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "Reciepts",
                keyColumn: "Reciept_id",
                keyValue: 1,
                columns: new[] { "CustomerId", "DrugId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Reciepts",
                keyColumn: "Reciept_id",
                keyValue: 2,
                columns: new[] { "CustomerId", "DrugId" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "Reciepts",
                keyColumn: "Reciept_id",
                keyValue: 3,
                columns: new[] { "CustomerId", "DrugId" },
                values: new object[] { 3, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_DrugTypes_Pharmacy_mId",
                table: "DrugTypes",
                column: "Pharmacy_mId");

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

            migrationBuilder.DropIndex(
                name: "IX_DrugTypes_Pharmacy_mId",
                table: "DrugTypes");

            migrationBuilder.DropColumn(
                name: "Pharmacy_mId",
                table: "DrugTypes");

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

            migrationBuilder.AddColumn<int>(
                name: "ManufacturerId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DrugId",
                table: "DrugTypes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "PharmacyId",
                table: "DrugTypes",
                type: "int",
                nullable: true);

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
                columns: new[] { "DrugId", "PharmacyId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "DrugTypes",
                keyColumn: "DrugType_id",
                keyValue: 2,
                columns: new[] { "DrugId", "PharmacyId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "DrugTypes",
                keyColumn: "DrugType_id",
                keyValue: 3,
                columns: new[] { "DrugId", "PharmacyId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Drug_id",
                keyValue: 1,
                column: "ManufacturerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Drug_id",
                keyValue: 2,
                column: "ManufacturerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Drug_id",
                keyValue: 3,
                column: "ManufacturerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Order_id",
                keyValue: 1,
                columns: new[] { "DrugId", "ManufacturerId", "PharmacistId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Order_id",
                keyValue: 2,
                columns: new[] { "DrugId", "ManufacturerId", "PharmacistId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Order_id",
                keyValue: 3,
                columns: new[] { "DrugId", "ManufacturerId", "PharmacistId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Reciepts",
                keyColumn: "Reciept_id",
                keyValue: 1,
                columns: new[] { "CustomerId", "DrugId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Reciepts",
                keyColumn: "Reciept_id",
                keyValue: 2,
                columns: new[] { "CustomerId", "DrugId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Reciepts",
                keyColumn: "Reciept_id",
                keyValue: 3,
                columns: new[] { "CustomerId", "DrugId" },
                values: new object[] { null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ManufacturerId",
                table: "Orders",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_DrugTypes_PharmacyId",
                table: "DrugTypes",
                column: "PharmacyId");

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
    }
}
