using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pharmacy.Migrations
{
    /// <inheritdoc />
    public partial class t2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Drugs_Reciepts_RecieptId",
                table: "Drugs");

            migrationBuilder.DropIndex(
                name: "IX_Drugs_RecieptId",
                table: "Drugs");

            migrationBuilder.DropColumn(
                name: "RecieptId",
                table: "Drugs");

            migrationBuilder.AddColumn<int>(
                name: "DrugId",
                table: "Reciepts",
                type: "int",
                nullable: true);

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

            migrationBuilder.UpdateData(
                table: "Reciepts",
                keyColumn: "Reciept_id",
                keyValue: 1,
                column: "DrugId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reciepts",
                keyColumn: "Reciept_id",
                keyValue: 2,
                column: "DrugId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reciepts",
                keyColumn: "Reciept_id",
                keyValue: 3,
                column: "DrugId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Reciepts_DrugId",
                table: "Reciepts",
                column: "DrugId");

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
                name: "FK_Reciepts_Drugs_DrugId",
                table: "Reciepts");

            migrationBuilder.DropIndex(
                name: "IX_Reciepts_DrugId",
                table: "Reciepts");

            migrationBuilder.DropColumn(
                name: "DrugId",
                table: "Reciepts");

            migrationBuilder.AddColumn<int>(
                name: "RecieptId",
                table: "Drugs",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "DrugTypes",
                keyColumn: "DrugType_id",
                keyValue: 1,
                column: "Pharmacy_mId",
                value: null);

            migrationBuilder.UpdateData(
                table: "DrugTypes",
                keyColumn: "DrugType_id",
                keyValue: 2,
                column: "Pharmacy_mId",
                value: null);

            migrationBuilder.UpdateData(
                table: "DrugTypes",
                keyColumn: "DrugType_id",
                keyValue: 3,
                column: "Pharmacy_mId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Drug_id",
                keyValue: 1,
                column: "RecieptId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Drug_id",
                keyValue: 2,
                column: "RecieptId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Drug_id",
                keyValue: 3,
                column: "RecieptId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Drugs_RecieptId",
                table: "Drugs",
                column: "RecieptId");

            migrationBuilder.AddForeignKey(
                name: "FK_Drugs_Reciepts_RecieptId",
                table: "Drugs",
                column: "RecieptId",
                principalTable: "Reciepts",
                principalColumn: "Reciept_id");
        }
    }
}
