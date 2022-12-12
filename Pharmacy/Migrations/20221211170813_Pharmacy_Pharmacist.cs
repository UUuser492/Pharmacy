using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pharmacy.Migrations
{
    /// <inheritdoc />
    public partial class PharmacyPharmacist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PharmacyId",
                table: "Pharmacists",
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
                table: "Pharmacists",
                keyColumn: "Pharmacist_id",
                keyValue: 1,
                column: "PharmacyId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Pharmacists",
                keyColumn: "Pharmacist_id",
                keyValue: 2,
                column: "PharmacyId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Pharmacists",
                keyColumn: "Pharmacist_id",
                keyValue: 3,
                column: "PharmacyId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Pharmacists_PharmacyId",
                table: "Pharmacists",
                column: "PharmacyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pharmacists_Pharmacies_PharmacyId",
                table: "Pharmacists",
                column: "PharmacyId",
                principalTable: "Pharmacies",
                principalColumn: "Pharmacy_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pharmacists_Pharmacies_PharmacyId",
                table: "Pharmacists");

            migrationBuilder.DropIndex(
                name: "IX_Pharmacists_PharmacyId",
                table: "Pharmacists");

            migrationBuilder.DropColumn(
                name: "PharmacyId",
                table: "Pharmacists");

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
        }
    }
}
