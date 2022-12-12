using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pharmacy.Migrations
{
    /// <inheritdoc />
    public partial class virt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
